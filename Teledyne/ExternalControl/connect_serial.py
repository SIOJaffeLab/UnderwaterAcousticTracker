import serial.tools.list_ports as port_list
import time
import serial 
import threading

from mmp_defs import *  # Import the command class


def find_ports():
    ports = list(port_list.comports())
    if not ports:
        print("No serial ports found")
        return None
    for p in ports:
        try:
            print("trying", p)
            # filter out non possible modem connections
            if (p.__str__()[-3:] == 'n/a'):
                print("N/A port")
                continue


            #try connecting to the serial port 
            ser = serial.Serial(p.device, 9600, timeout=1)
            if ser.is_open:
                print("Connected to", p.device)
                return ser 
            ser.close()

        except serial.SerialException as exception:
            print("failed to connect to", p.device, exception)



def send_ranging_command(serial_connection, modem_id):
    #print type of mmp_remote_t
    print(dir(mmp_remote_t))

    for _ in range(100):
        ranging_command = mmp_remote_t()
        
        serialized_ranging_command = ranging_command.serialize()

        serial_connection.write(serialized_ranging_command)

        time.sleep(5)



def display_input(serial_connection):
    if not  serial_connection:
        print("Error: Bad Serial Connection")
        raise
        return
    try:
        while True:
            try:
                data_out = serial_connection.readline().decode('utf-8').strip()
            except:
                print("couldn't decode", serial_connection.readline())
            if data_out:
                print(data_out)
            send_ranging_command(serial_connection, 1)
            time.sleep(5)


    except KeyboardInterrupt:
        print("Keyboard Interrupt\n Exiting...")
    finally:
        serial_connection.close()


ser = find_ports()
display_input_thread = threading.Thread(target=display_input, args=(ser))
send_range_thread = threading.Thread(target=send_ranging_command, args=(ser, 1))

#display input while sending range command
display_input_thread.start()
send_range_thread.start()


#close threads
display_input_thread.join()
send_range_thread.join()
