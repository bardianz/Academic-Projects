from PyQt5 import QtWidgets, uic
import sys
from PyQt5.QtWidgets import * 
from PyQt5.QtCore import Qt
import pyautogui

from ctrl import Database
from models import Course

import os
def resource_path(relative_path):
    if hasattr(sys, '_MEIPASS'):
        return os.path.join(sys._MEIPASS, relative_path)
    return os.path.join(os.path.abspath('.'), relative_path)

db = Database()


class Edit_Person_Form(QWidget):
    def __init__(self,id):
        super().__init__()
        uic.loadUi(resource_path('forms/add_course.ui'), self)
        self.setWindowFlag(Qt.FramelessWindowHint)

        self._id = id

        self.addBtn.clicked.connect(self.edit)
        self.cancelBtn.clicked.connect(self.cancel)
        self.addBtn.setText("Update")

        self.stu = db.fetch_all(table_name="student")
        self.tch = db.fetch_all(table_name="teacher")
        self.rom = db.fetch_all(table_name="room")
        self.comboStudent.addItem('')
        self.comboTeacher.addItem('')
        self.comboRoom.addItem('')
        for i in self.stu:
            self.comboStudent.addItem(i[1]+" "+i[2] +" (" + str(i[0]) +")")
        for i in self.tch:
            self.comboTeacher.addItem(i[1]+" "+i[2] +" (" + str(i[0]) +")")
        for i in self.rom:
            self.comboRoom.addItem(i[1] +" (" + str(i[0]) +")")




        self.this = db.fetch_one(id=id,table_name="course")

    def cancel(self):
        self.hide()

    def edit(self):
        student_combo_text = self.comboStudent.currentText()
        teacher_combo_text = self.comboTeacher.currentText()
        room_combo_text = self.comboRoom.currentText()

        if student_combo_text and teacher_combo_text and room_combo_text:
            id_student = find_id(student_combo_text)
            id_teacher = find_id(teacher_combo_text)
            id_room = find_id(room_combo_text)

            if id_student and id_teacher and id_room:
              # m = Student(id=self._id,first_name=new_fname,last_name=new_lname,student_num=None)
                m = Course(id=self._id,id_student=id_student,id_teacher=id_teacher,id_room=id_room)
                result = db.update_course(m)
                if  result== 'S':
                 self.hide()
                else:
                    print(result)



class Add_Course_Form(QWidget):
    def __init__(self):
        super().__init__()
        uic.loadUi(resource_path('forms/add_course.ui'), self)
        self.setWindowFlag(Qt.FramelessWindowHint)

        
        self.stu = db.fetch_all(table_name="student")
        self.tch = db.fetch_all(table_name="teacher")
        self.rom = db.fetch_all(table_name="room")
        for i in self.stu:
            self.comboStudent.addItem(i[1]+" "+i[2] +" (" + str(i[0]) +")")
        for i in self.tch:
            self.comboTeacher.addItem(i[1]+" "+i[2] +" (" + str(i[0]) +")")
        for i in self.rom:
            self.comboRoom.addItem(i[1] +" (" + str(i[0]) +")")

        print(self.stu)



        self.addBtn.clicked.connect(self.add)
        self.cancelBtn.clicked.connect(self.cancel)
        # self.addBtn.setText("Add")
    def cancel(self):
        self.hide()

    def cancel(self):
        self.hide()

    def add(self):

        student_combo_text = self.comboStudent.currentText()
        teacher_combo_text = self.comboTeacher.currentText()
        room_combo_text = self.comboRoom.currentText()


        id_student = find_id(student_combo_text)
        id_teacher = find_id(teacher_combo_text)
        id_room = find_id(room_combo_text)


        if id_student and id_teacher and id_room:
            m = Course(id_student=id_student,id_teacher=id_teacher,id=None,id_room=id_room)
            d = Database()
            d.insert_course(m)
            self.hide()


       
def find_id(input_str):
    x=input_str.split()
    res=[]
    for i in x:
        if i.find('(')==0 and i.find(')')==len(i)-1 :
            a=i.replace('(','')
            a=a.replace(')','')
            if a.isdigit():
                res.append(a)
    return(str(res[0]))


class CoursesList(QtWidgets.QMainWindow):
    def __init__(self,parent=None):
        super(CoursesList, self).__init__(parent)

        self.setWindowFlag(Qt.FramelessWindowHint)

        uic.loadUi(resource_path('forms/course_list_form.ui'), self)
        self.addBtn.clicked.connect(self.show_add_form)
        self.deleteBtn.clicked.connect(self.delete)
        self.updateBtn.clicked.connect(self.show_edit_form)
        self.refreshBtn.clicked.connect(self.fill_table)
        self.exitBtn.clicked.connect(self.exit)
        self.backBtn.clicked.connect(self.back)

        self.table = QTableWidgetItem()

        self.tableWidget = self.findChild(QTableWidget,'tableWidget')
        self.tableWidget.setSelectionBehavior(QAbstractItemView.SelectRows)
        self.refresh()


    def exit(self):
        sys.exit()

    def back(self):
        self.hide()



    def show_add_form(self):
        self.w = Add_Course_Form()
        self.w.show()
        self.refresh()
        



    def show_edit_form(self):
        try:
            index = self.tableWidget.currentRow()
            i = self.tableWidget.item(index,0).text()

            self.w = Edit_Person_Form(id=i)
            self.tableWidget.clear()

            self.w.show()
            self.refresh()
        except  Exception as e: print(e)

    def refresh(self):
        self.tableWidget.clear()
        self.tableWidget.setRowCount(10)
        self.tableWidget.setColumnCount(5)

        self.fill_table()

    def fill_table(self):
        result = db.fetch_all(table_name="course")
        print(result)
        if result:
            self.tableWidget.clear()
            header = self.tableWidget.horizontalHeader()
            header.setStretchLastSection(True)
            self.tableWidget.resizeColumnToContents(0)
            if len(result) > 0:    
                self.tableWidget.setRowCount(len(result))
                self.tableWidget.setColumnCount(len(result[0]))
                self.tableWidget.setHorizontalHeaderLabels(["ID", "Student Name", "Tacher Name","Room Name","Time"])
                header = self.tableWidget.horizontalHeader()       
                header.setSectionResizeMode(0, QHeaderView.ResizeMode.ResizeToContents)
                header.setSectionResizeMode(1, QHeaderView.ResizeMode.Stretch)
                header.setSectionResizeMode(2, QHeaderView.ResizeMode.Stretch)
                header.setSectionResizeMode(3, QHeaderView.ResizeMode.Stretch)
                header.setSectionResizeMode(4, QHeaderView.ResizeMode.Stretch)

                for i, (id, id_student,id_teacher,id_room,time) in enumerate(result):

                    item_id = QTableWidgetItem(str(id))
                    item_id.setTextAlignment(Qt.AlignHCenter)


                    try:
                        student_details = db.fetch_one(id_student,"student")
                        student_name = student_details[1]+ " " +student_details[2]
                    except:
                        student_name = "None"
                    item_student_name = QTableWidgetItem(str(student_name))
                    item_student_name.setTextAlignment(Qt.AlignHCenter)


                    try:
                        teacher_details = db.fetch_one(id_teacher,"teacher")
                        teacher_name = teacher_details[1]+ " " + teacher_details[2]
                    except:
                        teacher_name = "None"
                    item_teacher_name = QTableWidgetItem(str(teacher_name))
                    item_teacher_name.setTextAlignment(Qt.AlignHCenter)


                    try:
                        room_details = db.fetch_one(id_room,"room")
                        room_name = room_details[1]
                    except:
                        room_name = "None"
                    item_room_name = QTableWidgetItem(str(room_name))
                    item_room_name.setTextAlignment(Qt.AlignHCenter)

                    item_time = QTableWidgetItem(str(time))
                    item_time.setTextAlignment(Qt.AlignHCenter)

                    self.tableWidget.setItem(i, 0, item_id)
                    self.tableWidget.setItem(i, 1, item_student_name)
                    self.tableWidget.setItem(i, 2, item_teacher_name)
                    self.tableWidget.setItem(i, 3, item_room_name)
                    self.tableWidget.setItem(i, 4, item_time)


    
    def delete(self):
        try:
            index = self.tableWidget.currentRow()
            fname = self.tableWidget.item(index,1).text()
            lname = self.tableWidget.item(index,2).text()
            i = self.tableWidget.item(index,0).text()
            result = db.delete(i,table_name="course")
            if result=="S":
                pyautogui.alert(fname + " " + lname + ' Deleted !')
            self.refresh()
        except:
            print("error while deleting...")
