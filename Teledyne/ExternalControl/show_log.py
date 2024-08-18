import time
from watchdog.observers import Observer
from watchdog.events import FileSystemEventHandler
from loguru import logger
from pathlib import Path
import sys

# Custom log levels for SER_IN and SER_OUT
SER_IN_LEVEL = 25  # Custom log level between INFO (20) and WARNING (30)
SER_OUT_LEVEL = 25  # Custom log level between INFO (20) and WARNING (30)

def setup_logger():

    # Add custom log levels for SER_IN and SER_OUT
    logger.level("SER_IN", no=SER_IN_LEVEL, color="<magenta><bold>", icon="->->->")
    logger.level("SER_OUT", no=SER_OUT_LEVEL, color="<cyan><bold>", icon="<-<-<-")

class LogHandler(FileSystemEventHandler):
    def __init__(self, log_file):
        self.log_file = log_file
        self.last_position = self.display_existing_content()  # Initialize the position after displaying existing content

    def display_existing_content(self):
        """Reads and displays the entire content of the log file."""
        with open(self.log_file, "r") as f:
            content = f.readlines()
            for line in content:
                self.display_log_line(line.strip())
            return f.tell()  # Return the position after reading the file

    def on_modified(self, event):
        if event.src_path == str(self.log_file):
            with open(self.log_file, "r") as f:
                f.seek(self.last_position)  # Move to the last read position
                new_lines = f.readlines()
                self.last_position = f.tell()  # Update the position to the end of the file

                for line in new_lines:
                    self.display_log_line(line.strip())

    def display_log_line(self, line):
        """Display log line with recognition of command types."""
        if "| SER_IN |" in line:
            logger.log("SER_IN", line.split('| SER_IN |')[-1])
        elif "| SER_OUT |" in line:
            logger.log("SER_OUT", line.split('| SER_OUT |')[-1])
        elif "| DEBUG |" in line:
            logger.debug(line.split('| DEBUG |')[-1])
        elif "| INFO |" in line:
            logger.info(line.split('| INFO |')[-1])
        elif "| WARNING |" in line:
            logger.warning(line.split('| WARNING |')[-1])
        elif "| ERROR |" in line:
            logger.error(line.split('| ERROR |')[-1])
        elif "| CRITICAL |" in line:
            logger.critical(line.split('| CRITICAL |')[-1])
        elif "| SUCCESS |" in line:
            logger.success(line.split('| SUCCESS |')[-1])
        else:
            print("Couldn't figure out what kind of line")
            logger.info(line)  # Default case for lines without a recognized command

def get_most_recent_log_file(log_directory):
    log_files = list(Path(log_directory).glob("*.log"))
    if not log_files:
        logger.error("No log files found in the directory.")
        return None
    most_recent_log = max(log_files, key=lambda p: p.stat().st_mtime)
    logger.info(f"Monitoring the most recent log file: {most_recent_log}")
    return most_recent_log

def start_log_monitor(log_file):
    event_handler = LogHandler(log_file)
    observer = Observer()
    observer.schedule(event_handler, path=str(log_file.parent), recursive=False)
    observer.start()

    try:
        while True:
            time.sleep(1)
    except KeyboardInterrupt:
        observer.stop()
    observer.join()

if __name__ == "__main__":
    # Set the log directory
    log_directory = Path("./logs/")

    # Setup logger with custom levels
    setup_logger()

    # Get the most recent log file in the directory
    most_recent_log_file = get_most_recent_log_file(log_directory)
    if most_recent_log_file is None:
        sys.exit(1)

    # Start monitoring the most recent log file
    start_log_monitor(most_recent_log_file)
