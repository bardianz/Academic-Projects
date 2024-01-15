from PyQt5 import QtWidgets, uic
from PyQt5.QtCore import Qt

import sys
from PyQt5.QtWidgets import * 
from views.person import PersonList
from views.course import CoursesList
from views.room import RoomsList
from qt_material import apply_stylesheet

import os
def resource_path(relative_path):
    if hasattr(sys, '_MEIPASS'):
        return os.path.join(sys._MEIPASS, relative_path)
    return os.path.join(os.path.abspath('.'), relative_path)


class MainUi(QtWidgets.QMainWindow):
    def __init__(self,parent=None):
        super(MainUi, self).__init__(parent)
        uic.loadUi(resource_path('./forms/main.ui'), self)
        self.setWindowFlag(Qt.FramelessWindowHint)
        self.statusBar().setVisible(False)

        self.studentsBtn.clicked.connect(self.show_student_form)
        self.teachersBtn.clicked.connect(self.show_teacher_form)
        self.roomsBtn.clicked.connect(self.show_rooms)
        self.coursesBtn.clicked.connect(self.show_courses_form)
        self.empBtn.clicked.connect(self.show_employee)
        self.exitBtn.clicked.connect(self.exit)

    def exit(self):
        sys.exit()

    def show_student_form(self):
        PersonList(self,mode='student').show()
        
    def show_teacher_form(self):
        PersonList(self,mode='teacher').show()

    def show_courses_form(self):
        CoursesList(self).show()

    def show_rooms(self):
        RoomsList(self).show()

    def show_employee(self):
        PersonList(self,mode='employee').show()



app = QtWidgets.QApplication(sys.argv)
apply_stylesheet(app, theme='dark_teal.xml')

global window
window = MainUi()
window.show()
sys.exit(app.exec_())