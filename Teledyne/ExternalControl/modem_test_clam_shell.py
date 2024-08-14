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
    print("going into command mode")
    serial_connection.write(bytearray('+++\r','ascii'))
    print("going into datalog mode")
    serial_connection.write(bytearray('@OpMode=DataLog\r','ascii'))
    print("get underwater connection properties")
    serial_connection.write(bytearray('ATX0\r','ascii'))

    for _ in range(100):

        print("Sending Ranging Command")
        serial_connection.write(bytearray('atr0\r','ascii'))

        time.sleep(5)



def display_input(serial_connection, send_range_thread):
    started_ranging = False
    data_out = None
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
                if not started_ranging and data_out[:7]=='CONNECT':
                    time.sleep(5)
                    started_ranging = True
                    send_range_thread.start()
                    


                    


    except KeyboardInterrupt:
        print("Keyboard Interrupt\n Exiting...")
    finally:
        try:
            send_range_thread.join()
        except:
            pass
        serial_connection.close()


ser = find_ports()
send_range_thread = threading.Thread(target=send_ranging_command, args=(ser, 1,))
display_input_thread = threading.Thread(target=display_input, args=(ser,send_range_thread))

# wait for bootup

#display input while sending range command
display_input_thread.start()
#send_range_thread.start()


#close threads
display_input_thread.join()
