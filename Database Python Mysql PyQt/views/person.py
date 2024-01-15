from PyQt5 import QtWidgets, uic,QtCore
import sys
from PyQt5.QtWidgets import * 
from PyQt5.QtCore import Qt
import pyautogui

from ctrl import Database
from models import Student,Teacher,Employee

db = Database()
# mode = "student"

import os
def resource_path(relative_path):
    if hasattr(sys, '_MEIPASS'):
        return os.path.join(sys._MEIPASS, relative_path)
    return os.path.join(os.path.abspath('.'), relative_path)


class Edit_Person_Form(QWidget):
    def __init__(self,mode,id,fname,lname):
        super().__init__()
        uic.loadUi(resource_path('forms/add_person.ui'), self)
        self.__mode = mode
        self._id = id
        self._fname = fname
        self._lname = lname
        self.addBtn.clicked.connect(self.edit)
        self.cancelBtn.clicked.connect(self.cancel)
        self.addBtn.setText("Update")
        self.groupBox.setTitle("Edit")
        self.first_name_txt.setText(self._fname)
        self.last_name_txt.setText(self._lname)
        self.txt_number.setText(self._id)
        self.setWindowFlag(Qt.FramelessWindowHint)

    def cancel(self):
        self.hide()

    def edit(self):
        new_fname = self.first_name_txt.text()
        new_lname = self.last_name_txt.text()
        new_id = self.txt_number.text()
        if self.__mode == "student":
            m = Student(id=self._id,first_name=new_fname,last_name=new_lname,student_num=new_id)
        elif self.__mode == "teacher":
            m = Teacher(id=self._id,first_name=new_fname,last_name=new_lname,teacher_num=new_id)
        elif self.__mode == "employee":
            m = Employee(id=self._id,first_name=new_fname,last_name=new_lname,emp_num=new_id)

        if db.update_person(m) == 'S':
            self.hide()



class Add_Person_Form(QWidget):
    def __init__(self,mode):
        super().__init__()
        self.__mode = mode
        uic.loadUi(resource_path('forms/add_person.ui'), self)
        self.setWindowFlag(Qt.FramelessWindowHint)
        self.addBtn.clicked.connect(self.add)
        self.cancelBtn.clicked.connect(self.cancel)
        self.addBtn.setText("Add")

    def cancel(self):
        self.hide()

    def add(self):
        fname = self.first_name_txt.text()
        lname = self.last_name_txt.text()
        number = self.txt_number.text()
        if fname and lname and number and len(number)<14:
            try:
                number = int(number)
                if self.__mode == "student":
                    m = Student(first_name=fname,last_name=lname,id=number,student_num=number)
                elif self.__mode == "teacher":
                    m = Teacher(first_name=fname,last_name=lname,id=number,teacher_num=number)
                elif self.__mode == "employee":
                    m = Employee(first_name=fname,last_name=lname,id=number,emp_num=number)

                d = Database()
                d.insert_person(m)
                self.hide()
            except Exception as e: print(e)



class PersonList(QtWidgets.QMainWindow):
    def __init__(self,parent=None, **kwargs):
        super(PersonList, self).__init__(parent)
        self.__mode = kwargs['mode']
        self.setWindowFlag(Qt.FramelessWindowHint)


        uic.loadUi(resource_path('forms/person_list_form.ui'), self)

        self.addBtn.clicked.connect(self.show_add_form)
        self.deleteBtn.clicked.connect(self.delete)
        self.updateBtn.clicked.connect(self.show_edit_form)
        self.refreshBtn.clicked.connect(self.refresh)
        self.exitBtn.clicked.connect(self.exit)
        self.backBtn.clicked.connect(self.back)
        self.searchBtn.clicked.connect(self.search)

        self.table = QTableWidgetItem()

        self.tableWidget = self.findChild(QTableWidget,'tableWidget')
        self.tableWidget.setSelectionBehavior(QAbstractItemView.SelectRows)
        self.tableWidget.resizeRowsToContents()

        self.refresh()


    def exit(self):
        sys.exit()

    def back(self):
        self.hide()


    def search(self):
        txt_search = self.txt_search.text()
        if txt_search:
            res = db.search_person(self.__mode,txt_search)
            if len(res)>0:
                self.fill_table(res)
            else:
                self.tableWidget.setRowCount(0)
        else:
            self.refresh()


    def show_add_form(self):
        self.w = Add_Person_Form(mode=self.__mode)
        self.w.show()
        self.refresh()

        
    def show_edit_form(self):
        try:
            index = self.tableWidget.currentRow()
            fname = self.tableWidget.item(index,1).text()
            lname = self.tableWidget.item(index,2).text()
            i = self.tableWidget.item(index,0).text()

            self.w = Edit_Person_Form(mode=self.__mode,fname=fname,lname=lname,id=i)

            self.w.show()
        except:
            pass

    def refresh(self):
        self.txt_search.setText("")
        self.tableWidget.clear()
        self.tableWidget.setHorizontalHeaderLabels(["ID", "First Name","Last Name",])
        self.fetch_all_data()


    def fetch_all_data(self):
        result = db.fetch_all(table_name=self.__mode)
        self.fill_table(result)


    def fill_table(self,result):
        if result:
            self.tableWidget.setRowCount(len(result))
            self.tableWidget.clear()
            header = self.tableWidget.horizontalHeader()
            header.setStretchLastSection(True)
            self.tableWidget.resizeColumnToContents(0)
            self.tableWidget.setColumnCount(3)
            header = self.tableWidget.horizontalHeader()       
            header.setSectionResizeMode(0, QHeaderView.ResizeMode.Stretch)
            header.setSectionResizeMode(1, QHeaderView.ResizeMode.Stretch)
            header.setSectionResizeMode(2, QHeaderView.ResizeMode.Stretch)
            
            self.tableWidget.setHorizontalHeaderLabels(["ID", "First Name", "Last Name",])
            if len(result) >0:    
                self.tableWidget.setRowCount(len(result))
                self.tableWidget.setColumnCount(len(result[0]))
                for i, (id, first_name,last_name,) in enumerate(result):
                    item_id = QTableWidgetItem(str(id))
                    item_id.setTextAlignment(Qt.AlignHCenter)

                    item_fname = QTableWidgetItem(str(first_name))
                    item_fname.setTextAlignment(Qt.AlignHCenter)
                    
                    item_lname = QTableWidgetItem(str(last_name))
                    item_lname.setTextAlignment(Qt.AlignHCenter)

                    self.tableWidget.setItem(i, 0, item_id)
                    self.tableWidget.setItem(i, 1, item_fname)
                    self.tableWidget.setItem(i, 2, item_lname)

    
    def delete(self):
        try:
            index = self.tableWidget.currentRow()
            fname = self.tableWidget.item(index,1).text()
            lname = self.tableWidget.item(index,2).text()
            i = self.tableWidget.item(index,0).text()
            result = db.delete(i,table_name=self.__mode)
            if result=="S":
                pyautogui.alert(fname + " " + lname + ' Deleted !')
                self.refresh()
            else:
                print(result)
        except:
            print("error while deleting...")
