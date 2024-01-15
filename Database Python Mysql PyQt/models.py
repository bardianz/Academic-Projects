class Person:
    def __init__(self ,id,first_name, last_name):
        self.__id = id
        self.__first_name = first_name
        self.__last_name = last_name

    def get_id(self):
        return int(self.__id)

    def set_id(self, id):
        if id >= 0:
            self.__id = id

    def get_first_name(self):
        return self.__first_name

    def set_first_name(self, first_name):
        self.__first_name = first_name

    def get_last_name(self):
        return self.__last_name

    def set_last_name(self, last_name):
        self.__last_name = last_name



class Student(Person):
    def __init__(self, id, first_name, last_name,student_num):
        self._student_num = student_num
        super().__init__(id, first_name, last_name,)

    def get_student_num(self):
        return self._student_num

    def set_student_num(self, student_num):
        if id >= 0:
            self._student_num = student_num

    



class Teacher(Person):
    def __init__(self, id, first_name, last_name,teacher_num):
        self.__teacher_num = teacher_num
        super().__init__(id, first_name, last_name,)

    def get_student_num(self):
        return self.__teacher_num

    def set_student_num(self, teacher_num):
        if id >= 0:
            self.__teacher_num = teacher_num




class Employee(Person):
    def __init__(self, id, first_name, last_name,emp_num):
        self.__emp_num= emp_num
        super().__init__(id, first_name, last_name,)

    def get_emp_num(self):
        return self.__emp_num

    def set_emp_numm(self, emp_num):
        self.__emp_num = emp_num




class Room:
    def __init__(self, id, room_name):
        self.__room_name = room_name
        self.__id = id

        
    def get_id(self):
        return self.__id

    def set_id(self, id):
        if id >= 0:
            self.__id = id


    def get_room_name(self):
        return self.__room_name

    def set_room_name(self, room_name):
        self.room_name = room_name




class Course:
    def __init__(self,id,id_student,id_teacher,id_room) -> None:
        self.__id = id
        self.__id_student = id_student
        self.__id_teacher = id_teacher
        self.__id_room = id_room


    def get_id(self):
        return self.__id

    def set_id(self, id):
        if id >= 0:
            self.__id = id


    def get_id_student(self):
        return self.__id_student

    def set_id_student(self, id_student):
        if id >= 0:
            self.__id_student = id_student


    def get_id_teacher(self):
        return self.__id_teacher

    def set_id_teacher(self, id_teacher):
        if id >= 0:
            self.__id_teacher = id_teacher


    def get_id_room(self):
        return self.__id_room

    def set_id_room(self, id_room):
        if id >= 0:
            self.__id_room = id_room

