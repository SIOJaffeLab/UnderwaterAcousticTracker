import os
import re
import json
from loguru import logger
from collections import defaultdict
from datetime import datetime, timezone

# Define patterns for the different log types
characterization_command_pattern = re.compile(r"SER_OUT \| (?P<command>ATX\d+)")
characterization_response_pattern = re.compile(r"SER_IN \| (MOD:(?P<MOD>\d+) TXP:(?P<TXP>\d+) ERR:(?P<ERR>\d+) PSNR:(?P<PSNR>[\d.]+) AGC:(?P<AGC>\d+) SPD:(?P<SPD>[+-]?[\d.]+) CCERR:(?P<CCERR>\d+))")
range_request_command_pattern = re.compile(r"SER_OUT \| (?P<command>atr\d+)")
range_response_pattern = re.compile(r"SER_IN \| Range \d+ to \d+ : (?P<distance>[\d.]+) m")
no_response_pattern = re.compile(r"SER_IN \| Response Not Received")

# Configure loguru for detailed logging
logger.add("conversion.log", level="DEBUG", format="{time} {level} {message}", backtrace=True, diagnose=True)

<<<<<<< Updated upstream
TIME_DELAY = 5
BOOT_DELAY = 50
NUMBER_OF_RANGES =  10
REMOTE_MODEM_ID = 0
JOIN_THREAD_TIME = 2


def setup_logger():
    current_time = datetime.now().strftime("%Y-%m-%d_%H-%M-%S")
    log_filename = Path('./logs/' + f"log_{current_time}.log")

    logger.level("SER_IN", no=50, color="<magenta><bold>", icon='->->->')
    logger.level("SER_OUT", no=50, color="<magenta><bold>", icon='<-<-<-<')

    logger.add(log_filename, colorize = True, format="{time:MMMM D, YYYY > HH:mm:ss} | {level} | {message} ")

def find_ports():
    ports = list(port_list.comports())
    if not ports:
        logger.error("No serial ports found")
=======
# Function to extract and convert time from timestamp, assuming it's in UTC
def extract_and_convert_time(timestamp):
    """Extract and convert timestamp string 'Month day, year > HH:MM:SS' to a UTC datetime object."""
    try:
        datetime_str = timestamp.split(">")[1].strip()
        full_date_str = timestamp.split(">")[0].strip() + " " + datetime_str
        # Parse the datetime string as UTC
        datetime_obj = datetime.strptime(full_date_str, "%B %d, %Y %H:%M:%S")
        utc_time = datetime_obj.replace(tzinfo=timezone.utc)
        logger.debug(f"Original timestamp: '{timestamp}', Treated as UTC: '{utc_time}', Systime: {int(utc_time.timestamp() * 1000)}")
        return utc_time
    except (IndexError, ValueError) as e:
        logger.error(f"Failed to convert timestamp '{timestamp}': {e}")
>>>>>>> Stashed changes
        return None

# Function to calculate the average distance, ignoring None values
def calculate_average_distance(ranges):
    valid_distances = [float(r["distance"]) for r in ranges if r["distance"] is not None]
    if valid_distances:
        return sum(valid_distances) / len(valid_distances)
    else:
        logger.warning("No valid distances found to calculate the average.")
        return None

# Function to parse a single log file
def parse_log_file(file_path):
    log_data = defaultdict(lambda: {
        "test_start": None,
        "test_stop": None,
        "ranges": [],
        "characterizations": [],
        "average_distance": None
    })

    first_timestamp = None
    last_timestamp = None
    current_characterization = None
    current_range_request = None

    with open(file_path, 'r') as file:
        for line in file:
            if " | " not in line:
                logger.warning(f"Line doesn't match expected format and will be skipped: {line}")
                continue  # Skip lines that don't match the expected format

            timestamp = line.split(" | ")[0].strip()

            if not first_timestamp:
                first_timestamp = timestamp  # Set the first timestamp

            last_timestamp = timestamp  # Update the last timestamp for each line

<<<<<<< Updated upstream
    logger.info("Sleeping for " + str(BOOT_DELAY) + " seconds to boot")
    time.sleep(BOOT_DELAY)

    logger.debug("Getting underwater connection properties")
    send_command(serial_connection, "ATX"+str(modem_id))
=======
            # Convert timestamp to UTC datetime object
            utc_time = extract_and_convert_time(timestamp)
            if utc_time is None:
                logger.warning(f"Skipping line due to failed timestamp conversion: {line}")
                continue  # Skip if timestamp conversion failed
>>>>>>> Stashed changes

            # Match characterization commands
            if match := characterization_command_pattern.search(line):
                current_characterization = {
                    "sent_timestamp": utc_time.strftime("%H:%M:%S"),
                    "response_timestamp": None,
                    "stats": {
                        "MOD": None,
                        "TXP": None,
                        "ERR": None,
                        "PSNR": None,
                        "AGC": None,
                        "SPD": None,
                        "CCERR": None
                    }
                }
            # Match characterization responses
            elif current_characterization and (match := characterization_response_pattern.search(line)):
                current_characterization["response_timestamp"] = utc_time.strftime("%H:%M:%S")
                current_characterization["stats"].update({
                    "MOD": match.group("MOD"),
                    "TXP": match.group("TXP"),
                    "ERR": match.group("ERR"),
                    "PSNR": match.group("PSNR"),
                    "AGC": match.group("AGC"),
                    "SPD": match.group("SPD"),
                    "CCERR": match.group("CCERR")
                })
                # Add the completed characterization to the log data
                log_data[first_timestamp]["characterizations"].append(current_characterization)
                current_characterization = None

            # Match range requests
            elif match := range_request_command_pattern.search(line):
                current_range_request = {
                    "sent_timestamp": utc_time.strftime("%H:%M:%S"),
                    "response_timestamp": None,
                    "distance": None,
                }

            # Match range responses
            elif current_range_request and (match := range_response_pattern.search(line)):
                current_range_request["response_timestamp"] = utc_time.strftime("%H:%M:%S")
                current_range_request["distance"] = match.group("distance")
                # Add the completed range request to the log data
                log_data[first_timestamp]["ranges"].append(current_range_request)
                current_range_request = None
            # Match no response
            elif current_range_request and (match := no_response_pattern.search(line)):
                current_range_request["response_timestamp"] = utc_time.strftime("%H:%M:%S")
                current_range_request["distance"] = None  # Set distance to None if response not received
                # Add the completed range request to the log data
                log_data[first_timestamp]["ranges"].append(current_range_request)
                current_range_request = None

    # Set the start and stop times for the log
    if first_timestamp and last_timestamp:
        log_data[first_timestamp]["test_start"] = extract_and_convert_time(first_timestamp).strftime("%H:%M:%S")
        log_data[first_timestamp]["test_stop"] = extract_and_convert_time(last_timestamp).strftime("%H:%M:%S")

    # Calculate the average distance and add it to the log data
    log_data[first_timestamp]["average_distance"] = calculate_average_distance(log_data[first_timestamp]["ranges"])

    return dict(log_data)  # Convert defaultdict to a regular dict

# Function to parse all logs in a directory and save as one JSON file
def parse_all_logs_in_directory(log_directory, output_file):
    all_logs_data = {}

    # Get the list of all log files in the directory
    log_files = [os.path.join(log_directory, f) for f in os.listdir(log_directory) if f.endswith('.log')]
    
    # Parse each log file and merge results
    for file_path in log_files:
        log_data = parse_log_file(file_path)
        all_logs_data.update(log_data)  # Merge log data from each file

    # Sort log data by average distance
    sorted_log_data = dict(sorted(all_logs_data.items(), key=lambda x: (x[1]["average_distance"] or float('inf'))))

    # Save the sorted data to a JSON file
    with open(output_file, "w") as json_file:
        json.dump(sorted_log_data, json_file, indent=4)

    logger.info(f"Logs have been parsed, sorted by average distance, and saved to '{output_file}'")

if __name__ == "__main__":
    # Directory containing the log files
    log_directory = "./logs/"
    # Output file for the combined JSON
    output_file = "./parsed_rpi_logs.json"
    
    # Parse all log files in the directory and save the results to a JSON file
    parse_all_logs_in_directory(log_directory, output_file)
