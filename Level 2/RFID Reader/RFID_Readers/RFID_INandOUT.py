#!/usr/bin/python

# This is required to include the time module.
import time;
import sched;


# This is required to include the url modules.
import urllib;
import urllib2;

# Function for the core workings of the Program - Reads in RFID adds to list, sends list at designate time.
def RFID_Main(a):
    register = []
    s = sched.scheduler(time.time, time.sleep)

# Infinite loop to allow for consistant use.
    while True:
        if s.empty() == true:
            s.enter(a,1, send_register(register))
            s.run()

        userId = raw_input('--> ')

        if len(register) == 0:
            tempStu = Student()
            tempStu.stuArrival(userId)
            register.append(tempStu)
        else:
          for stu in register:
            if userId == stu.get_stuId():
                stu.stuDepart()
            else:
                tempStu = Student()
                tempStu.stuArrival(userId)
                register.append(tempStu)

# Function to allow admin to allocate the time delay between "posts".
def Admin_Control():
    timeDelay = raw_input('Input the required Time Delay')
    return int(timeDelay)

# Function to send list to the Server.
def send_register(register):
        print 'sending'
		url = "http://194.80.55.33/"
		data = urllib.urlencode(register)
		req = urllib2.Request(url,data)
		response = urllib2.urlopen(req)
		the_page = response.read()

# Class to hold information about the Students present at the lecture/
class Student:

    # Default constructor to initalise the object.
    def __init__ (self):
            self.stuID = None
            self.timeIn = None
            self.timeOut = None

    # Called upon Arrival, sets StudentId and Arrival Time.
    def stuArrival(self, stuID):
            self.stuID = stuID
            self.timeIn = time.asctime( time.localtime(time.time()))

    # Called upon Departure, sets Departure Time.
    def stuDepart(self):
            self.timeOut =  time.asctime( time.localtime(time.time()))

    # Returns the StudentsId.
    def get_stuId(self):
            return self.stuID

    # Returns the Arrival Time.
    def get_timeIn(self):
            return self.timeIn

    # Returns the Departure Time.
    def get_timeOut(self):
            return self.timeOut

# Main starts here.

a = 15
RFID_Main(a)


