# This version of the program immediately sends the value from an RFID to the server along with the system clock time.
# This means everything is done server side.

#!/usr/bin/python

# This is required to include the time module.
import time;
import sched;

# This is required to include the url modules.
import urllib;
import urllib2;

# This is required to access the pyserial module allowing access to the serial ports.
import serial;

class Student:
    
    def __init__(self):
        self.stuID = None
        self.clockedTime = None
    
    def stuClock(self, stuID):
        self.stuID = stuID
        self.clockedTime = time.asctime( time.localtime(time.time()))
    
    def get_stuId(self):
        return self.stuID
    
    def get_clockedTime(self):
        return self.clockedTime
    
    def printinfo(self):
        print self.stuID
        print self.clockedTime

def send_Student(stu):
    sending =  stu.stuID
    url = ""
    data = urllib.urlencode(sending)
    req = urllib2.Request(url,data)
    response = urllib2.urlopen(req)
    the_page = response.read()

print 'begin'
memory = []
while True:
    tempStu = Student()
    port = serial.Serial('/dev/ttyUSB0', 2400, timeout = 10)
    temp = port.read(12)
    if len(memory) == 0:
        tempStu.stuClock(temp)
        memory.append(tempStu)
    else :
        for stu in memory:
            if temp == stu.get_stuID:
                print 'exists'
            else:
                tempStu.stuClock(temp)
                memory.append(tempStu)
            
        
        
        
        
        