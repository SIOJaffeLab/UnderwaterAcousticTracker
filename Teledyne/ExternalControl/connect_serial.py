import serial.tools.list_ports as port_list
import serial 

from mmp_defs import *  # Import the command class


def find_ports():
    ports = list(port_list.comports())
    if not ports:
        print("No serial ports found")
        return None
    for p in ports:
        try:
            print("trying", p)
            #            if(p[len(p)-3:]=="n/a"):
            #                continue
            if (p.__str__()[-3:] == 'n/a'):
                print("N/A port")
                continue
            ser = serial.Serial(p.device, 9600, timeout=1)
            if ser.is_open:
                print("Connected to", p.device)
                return ser 
            ser.close()
        except serial.SerialException as exception:
            print("failed to connect to", p.device, exception)



def send_ranging_command(serial_connection, modem_id):
    print(dir(mmp_remote_t))

    my_message = mmp_remote_t.__call__()



def connect_port(serial_connection):
    if not  serial_connection:
        print("Bad Connection")
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
connect_port(ser)
