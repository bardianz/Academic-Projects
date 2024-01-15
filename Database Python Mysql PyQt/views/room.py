from PyQt5 import QtWidgets, uic
import sys
from PyQt5.QtWidgets import * 
import pyautogui
from PyQt5.QtCore import Qt

from ctrl import Database
from models import Room

import os

def resource_path(relative_path):
    if hasattr(sys, '_MEIPASS'):
        return os.path.join(sys._MEIPASS, relative_path)
    return os.path.join(os.path.abspath('.'), relative_path)


db = Database()

class Edit_Room_Form(QWidget):
    def __init__(self,id,room_name):
        super().__init__()
        uic.loadUi(resource_path('forms/add_room.ui'), self)
        self.setWindowFlag(Qt.FramelessWindowHint)

        self._id = id
        self._room_name = room_name

        self.addBtn.clicked.connect(self.edit)
        self.addBtn.setText("Update")
        self.groupBox.setTitle("Edit")
        self.room_name_txt.setText(self._room_name)
        self.cancelBtn.clicked.connect(self.cancel)
    
    def cancel(self):
        self.hide()

    def edit(self):
        new_room_name = self.room_name_txt.text()
        m = Room(id= self._id,room_name=new_room_name)
        if db.update_room(m) == 'S':
            self.close()

    def cancel(self):
        self.hide()


class Add_Room_Form(QWidget):
    def __init__(self):
        super().__init__()
        uic.loadUi(resource_path('forms/add_room.ui'), self)
        self.setWindowFlag(Qt.FramelessWindowHint)
        self.addBtn.clicked.connect(self.add)
        self.addBtn.setText("Add")
        self.cancelBtn.clicked.connect(self.cancel)

    def add(self):
        rm_name = self.room_name_txt.text()
        if rm_name:
            s = Room(room_name=rm_name,id=None)
            d = Database()
            d.insert_room(s)
            self.hide()
    def cancel(self):
        self.hide()


class RoomsList(QtWidgets.QMainWindow):
    def __init__(self,parent=None):
        super(RoomsList, self).__init__(parent)
        uic.loadUi(resource_path('forms/room_list.ui'), self)

        self.addBtn.clicked.connect(self.show_add_form)
        self.deleteBtn.clicked.connect(self.delete)
        self.updateBtn.clicked.connect(self.show_edit_form)
        self.refreshBtn.clicked.connect(self.refresh)
        self.exitBtn.clicked.connect(self.exit)
        self.backBtn.clicked.connect(self.back)
        self.searchBtn.clicked.connect(self.search)
        self.tableWidget = self.findChild(QTableWidget,'tableWidget')
        self.setWindowFlag(Qt.FramelessWindowHint)
        self.refresh()

    def exit(self):
        sys.exit()

    def back(self):
        self.hide()

    def search(self):
        txt_search = self.txt_search.text()
        if txt_search:
            res = db.search_room('room',txt_search)
            if len(res)>0:
                self.fill_table(res)
            else:
                self.tableWidget.setRowCount(0)
        else:
            self.refresh()


    def show_add_form(self):
        self.w = Add_Room_Form()
        self.w.show()


    def show_edit_form(self):
        index = self.tableWidget.currentRow()
        Rname = self.tableWidget.item(index,1).text()
        i = self.tableWidget.item(index,0).text()

        self.w = Edit_Room_Form(i,Rname)
        self.w.show()


    def refresh(self):
        self.txt_search.setText("")
        self.tableWidget.clear()
        self.tableWidget.setHorizontalHeaderLabels(["ID", "Room Name"])
        self.fetch_all_data()


    def fetch_all_data(self):
        result = db.fetch_all(table_name="room")
        self.fill_table(result)

    def fill_table(self,result):
        if result:
            self.tableWidget.clear()
            header = self.tableWidget.horizontalHeader()
            header.setStretchLastSection(True)
            self.tableWidget.resizeColumnToContents(0)
            self.tableWidget.setColumnCount(3)
            header = self.tableWidget.horizontalHeader()       
            header.setSectionResizeMode(0, QHeaderView.ResizeMode.Stretch)
            header.setSectionResizeMode(1, QHeaderView.ResizeMode.Stretch)
            
            self.tableWidget.setHorizontalHeaderLabels(["ID", "Room Name",])
            if len(result) >0:    
                self.tableWidget.setRowCount(len(result))
                self.tableWidget.setColumnCount(len(result[0]))
                for i, (id, room_name) in enumerate(result):
                    item_id = QTableWidgetItem(str(id))
                    item_id.setTextAlignment(Qt.AlignHCenter)
                    item_room_name = QTableWidgetItem(str(room_name))
                    item_room_name.setTextAlignment(Qt.AlignHCenter)


                    self.tableWidget.setItem(i, 0, item_id)
                    self.tableWidget.setItem(i, 1, item_room_name)

    
    def delete(self):
        try:
            index = self.tableWidget.currentRow()
            room_name = self.tableWidget.item(index,1).text()
            i = self.tableWidget.item(index,0).text()
            result = db.delete(i,table_name="room")
            if result=="S":
                pyautogui.alert(room_name + ' Deleted !')
                self.refresh()
        except Exception as e :
            print(str(e) +"error while deleting...")
