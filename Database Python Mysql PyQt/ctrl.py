import mysql.connector
from models import Student, Teacher,Room,Course,Employee
import pyautogui
from abc import abstractmethod,ABC


class AbsDatabase(ABC):
    def __init__(self) -> None:
        self._host = "localhost"
        self._username = "root"
        self._password = "mysqlpass"
        self._dbname = "schooldb"

    def connect(self,host,username,password,dbname):
        pass

    def close_database(self):
        pass


class Database(AbsDatabase):
    def connect(self):
        try:
            self.__connection = mysql.connector.connect(
                host = self._host,
                user = self._username,
                passwd = self._password,
                database = self._dbname,
            )
        except Exception as e:
            pyautogui.alert("unable to coonect database\n" + str(e))


    def delete(self, id, table_name):
        self.connect()
        try:
            cursor = self.__connection.cursor()
            sql = "DELETE FROM "+table_name + " WHERE id_"+table_name+"= "+str(id)
            cursor.execute(sql)
            self.__connection.commit()
            return "S"
        except Exception as e:
            pyautogui.alert("unable to coonect database\n" + str(e))
            return e
        finally:
            self.close_database()

    def fetch_all(self, table_name):
        try:
            self.connect()
            cursor = self.__connection.cursor()
            cursor.execute("SELECT * FROM " + table_name)

            return cursor.fetchall()
        except Exception as e:
            pyautogui.alert("unable to coonect database\n" + str(e))

    def close_database(self):
        self.__connection.close()


    def insert_person(self, m):

        if isinstance(m,Teacher):
            table_name = "teacher"
        elif isinstance(m,Student):
            table_name = "student"
        elif isinstance(m,Employee):
            table_name = "employee"

        try:
            self.connect()
            cursor = self.__connection.cursor()
            sql = "INSERT INTO "+table_name+" (id_"+table_name+",first_name, last_name) VALUES (%s,%s, %s)"
            val = (m.get_id(),m.get_first_name(), m.get_last_name())
            cursor.execute(sql, val)
            self.__connection.commit()
            return "S"
        except mysql.connector.Error as err:
                print(err)
                print("Error Code:", err.errno)
                print("SQLSTATE", err.sqlstate)
                print("Message", err.msg)
                print("Failed to insert")
                return "F"

    def update_person(self, m):
        if isinstance(m,Teacher):
            table_name = "teacher"
        elif isinstance(m,Student):
            table_name = "student"
        elif isinstance(m,Employee):
            table_name = "employee"
        try:
            self.connect()
            cursor = self.__connection.cursor()
            query = "UPDATE "+table_name+" SET first_name = %s , last_name = %s WHERE id_"+table_name+" = %s"
            data = (m.get_first_name(), m.get_last_name(),str(m.get_id()))
            cursor.execute(query, data)
            self.__connection.commit()
            print("Total rows updated: %d" % cursor.rowcount)
            return "S"
        except mysql.connector.Error as err:
                print(err)
                print("Error Code:", err.errno)
                print("SQLSTATE", err.sqlstate)
                print("Message", err.msg)
                print("Failed to update")
                pyautogui.alert("unable to coonect database\n" + str(err))
                return "F"

    def fetch_one(self, id, table_name):
        self.connect()
        try:
            self.connect()
            cursor = self.__connection.cursor()
            cursor.execute("SELECT * FROM " + table_name+" WHERE id_"+table_name+" ="+ str(id))
            return cursor.fetchone()
        except Exception as e:
            pyautogui.alert("unable to coonect database\n" + str(e))

    def insert_room(self, m: Room):
            try:
                self.connect()
                cursor = self.__connection.cursor()
                sql = "INSERT INTO room (room_name) VALUES (%s)"
                val = (m.get_room_name(),)
                cursor.execute(sql, val)
                self.__connection.commit()
                return "S"
            except mysql.connector.Error as err:
                print(err)
                print("Error Code:", err.errno)
                print("SQLSTATE", err.sqlstate)
                print("Message", err.msg)
                print("Failed to insert")
                pyautogui.alert("unable to coonect database\n" + str(err))
                return "F"


    def update_room(self,m:Room):
        try:
            self.connect()
            cursor = self.__connection.cursor()       
            query = "UPDATE room SET room_name = %s WHERE id_room = %s"
            data = (m.get_room_name(),m.get_id())
            cursor.execute(query, data)
            self.__connection.commit()
            
            print("Total rows updated: %d" % cursor.rowcount)
            return "S"

        except mysql.connector.Error as err:
            print(err)
            print("Error Code:", err.errno)
            print("SQLSTATE", err.sqlstate)
            print("Message", err.msg)
            print("Failed to insert")
            return "F"

        
    def insert_course(self, m: Course):
        self.connect()
        try:
            cursor = self.__connection.cursor()
            sql = "INSERT INTO course (id_student,id_teacher,id_room) VALUES (%s,%s,%s)"
            val = (m.get_id_student(),m.get_id_teacher(),m.get_id_room())
            cursor.execute(sql, val)
            self.__connection.commit()
            return "S"
        except mysql.connector.Error as err:
            print(err)
            print("Error Code:", err.errno)
            print("SQLSTATE", err.sqlstate)
            print("Message", err.msg)
            print("Failed to insert")
            pyautogui.alert(str(err))
            return "F"


    def update_course(self,m:Course):
        self.connect()
        try:
            cursor = self.__connection.cursor()
            query = "UPDATE course SET id_student = %s , id_teacher = %s , id_room = %s WHERE id_course = %s"
            data = (m.get_id_student() ,m.get_id_teacher() ,m.get_id_room(),int(m.get_id()))
            cursor.execute(query, data)
            self.__connection.commit()
            
            print("Total rows updated: %d" % cursor.rowcount)
            return "S"

        except mysql.connector.Error as err:
                print(err)
                print("Error Code:", err.errno)
                print("SQLSTATE", err.sqlstate)
                print("Message", err.msg)
                print("Failed to insert")
                pyautogui.alert(str(err))
                return err


    def search_person(self, table_name,text):
        self.connect()
        try:
            cursor = self.__connection.cursor()
            query = "SELECT * FROM {} WHERE first_name LIKE '%{}%' OR last_name LIKE '%{}%' ".format(table_name, text, text)
            cursor.execute(query)
            result = cursor.fetchall()
            return result
        except Exception as e:
            pyautogui.alert(str(e))
            return None

    def search_room(self, table_name,text):
        self.connect()
        try:
            cursor = self.__connection.cursor()
            query = "SELECT * FROM {} WHERE room_name LIKE '%{}%'  ".format(table_name,  text)
            cursor.execute(query)
            result = cursor.fetchall()
            return result
        except Exception as e:
            pyautogui.alert(str(e))
            return None