import serial.tools.list_ports as port_list
import time
import serial 
import threading
import sys

from loguru import logger

from mmp_defs import *  # Import the command class

from datetime import datetime

TIME_DELAY = 5
NUMBER_OF_RANGES =  10
REMOTE_MODEM_ID = 0
JOIN_THREAD_TIME = 2


def setup_logger():
    current_time = datetime.now().strftime("%Y-%m-%d_%H-%M-%S")
    log_filename = f"log_{current_time}.log"

    logger.level("SER_IN", no=50, color="<magenta><bold>", icon='->->->')
    logger.level("SER_OUT", no=50, color="<magenta><bold>", icon='<-<-<-<')

    logger.add(log_filename, colorize = True, format="{time:MMMM D, YYYY > HH:mm:ss} | {level} | {message} ")

def find_ports():
    ports = list(port_list.comports())
    if not ports:
        logger.error("No serial ports found")
        return None
    for p in ports:
        try:
            logger.debug("trying " + str(p))

            # filter out non possible modem connections
            if (p.__str__()[-3:] == 'n/a'):
                logger.warning(str(p) + "is a N/A port")
                continue


            #try connecting to the serial port 
            logger.debug("Connecting to " + str(p.device))
            ser = serial.Serial(p.device, 9600, timeout=1)
            if ser.is_open:
                logger.success("Connected to " + str(p.device))
                return ser 
            ser.close()

        except serial.SerialException as exception:
            logger.critical("failed to connect to " + str(p.device) + str(exception))

def send_command(serial_connection, command):
    try:
        serial_connection.write(bytearray(str(command)+'\r','ascii'))
        logger.log("SER_OUT", str(command))
    except:
        logger.error("Couldn't send" + str(command) + "over serial")


def send_ranging_command(serial_connection, modem_id):
    #    print("going into datalog mode")
    #    serial_connection.write(bytearray('@OpMode=DataLog\r','ascii'))

    logger.debug("Getting underwater connection properties")
    send_command(serial_connection, "ATX"+str(modem_id))
    logger.info("Sleeping for " + str(TIME_DELAY) + " seconds")
    time.sleep(TIME_DELAY)

    try:
        for i in range(NUMBER_OF_RANGES):

            logger.debug("Sending Ranging Command: " + str(i))
            send_command(serial_connection, "atr"+str(modem_id))

            logger.info("Sleeping for " + str(TIME_DELAY) + " seconds")
            time.sleep(TIME_DELAY)

        logger.success("Done Ranging " + str(NUMBER_OF_RANGES) + " times")
        logger.debug("Joining display_input_thread")
        display_input_thread.join(2)
    except KeyboardInterrupt:
        logger.critical("Keyboard Interrupt\n Exiting...")
    finally:
        try:
            logger.debug("Joining display_input_thread")
            display_input_thread.join(2)
            logger.debug("Joining ranging thread")
            send_range_thread.join(2)
        except Exception as e:
            logger.error("Couldn't kill thread due to error: " + str(e))
            pass
        logger.success("Done! Exiting!")
        logger.debug("Closing Serial Connection (This will Errror Out)")
        #TODO: Find More Graceful way to exit the thread
        serial_connection.close()
        serial_connection = None
        
def display_input(serial_connection, send_range_thread):
    started_ranging = False
    data_out = None
    if not  serial_connection:
        logger.critical("Error: Bad Serial Connection")
        raise
        return
    try:
        while serial_connection.is_open:
            try:
                data_out = serial_connection.readline().decode('utf-8').strip()
            except:
                try:
                    logger.error("couldn't decode " + str(serial_connection.readline()))
                except:
                    logger.error("Having problems with the serial_connection")

            if not started_ranging:
                send_command(serial_connection, "+++")
                
            if data_out:
                logger.log("SER_IN", data_out)

                if not started_ranging and data_out[:5] == 'user:':
                    logger.debug("Booted and in Command Mode")
                    logger.info("Sleeping for "+str(TIME_DELAY)+" seconds")
                    time.sleep(TIME_DELAY)
                    started_ranging = True
                    send_range_thread.start()

    except KeyboardInterrupt:
        logger.critical("Keyboard Interrupt\n Exiting...")
    finally:
        try:
            send_range_thread.join(2)
        except:
            pass
        serial_connection.close()


if __name__ == "__main__":
    setup_logger()
    ser = find_ports()
    logger.debug("Creating Threads")
    send_range_thread = threading.Thread(target=send_ranging_command, args=(ser, REMOTE_MODEM_ID,))
    display_input_thread = threading.Thread(target=display_input, args=(ser,send_range_thread))

    # wait for bootup

    #display input while sending range command
    logger.debug("Starting Display Input Thread")
    display_input_thread.start()
    #send_range_thread.start()


    #close threads
