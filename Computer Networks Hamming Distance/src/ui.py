from PyQt5 import QtWidgets, uic
from PyQt5.QtCore import Qt

import sys
from PyQt5.QtWidgets import * 

from hamming_distance import hamming_distance_calculator

import os
def resource_path(relative_path):
    if hasattr(sys, '_MEIPASS'):
        return os.path.join(sys._MEIPASS, relative_path)
    return os.path.join(os.path.abspath('.'), relative_path)


class MainUi(QtWidgets.QMainWindow):
    def __init__(self,parent=None):
        super(MainUi, self).__init__(parent)
        uic.loadUi(resource_path('./ui/main_window.ui'), self)
        # self.setWindowFlag(Qt.FramelessWindowHint)
        # self.statusBar().setVisible(False)

        self.btnCalculate.clicked.connect(self.calculate)
        self.actionClear.triggered.connect(self.clear)

    def calculate(self):
        str1_text = self.lineEditStr1.text()
        str2_text = self.lineEditStr2.text()
        try:
            result = str(hamming_distance_calculator(str1_text,str2_text))
            self.textEditResult.append(str1_text)
            self.textEditResult.append(str2_text)
            self.textEditResult.append("____________")
            self.textEditResult.append(result)
            self.textEditResult.append("\n")
        except Exception as e:
            self.textEditResult.clear()
            self.textEditResult.append("Error:")
            self.textEditResult.append(str(e))
    def clear(self):
        self.textEditResult.clear()
        self.lineEditStr1.setText("")
        self.lineEditStr2.setText("")
        
  


app = QtWidgets.QApplication(sys.argv)

global window
window = MainUi()
window.show()
sys.exit(app.exec_())