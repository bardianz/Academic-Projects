import tkinter as tk
from tkinter import ttk ,PhotoImage
from tkinter.messagebox import showinfo
import os
import sys
import base64

def resource_path(relative_path):
    """ Get absolute path to resource, works for dev and for PyInstaller """
    try:
        # PyInstaller creates a temp folder and stores path in _MEIPASS
        base_path = sys._MEIPASS
    except Exception:
        base_path = os.path.abspath(".")

    return os.path.join(base_path, relative_path)

# root window
root = tk.Tk()
root.geometry("300x200")
root.resizable(False, False)
root.title('Average')
root.eval('tk::PlaceWindow . center')
icon_path = resource_path('assets/icon.ico')
root.iconbitmap(default=icon_path)

score = tk.StringVar()
unit = tk.StringVar()
lessons=[]

def error_show(e):
    msg = 'an error occurred'+'\n' + e
    showinfo(title='Error', message=msg )

def add_clicked():
    score = score_entry.get()
    unit = unit_entry.get()
    if score and unit:
        try:
            score = float(score)
            unit = int(unit)
            lessons.append({
                    'score':score,
                    'unit': unit,
                    })
            score_entry.delete(0, "end")
            unit_entry.delete(0, "end")
            score_entry.focus_set()
        except:
            error_show("")
    else:
        error_show('please fill all fields')

def calculate_clicked():
    unit_sum = 0
    unit_score = 0
    for item in lessons:
        unit_sum += item['unit']
        unit_score += item['unit'] * item['score']
    average = unit_score / unit_sum
    msg = average
    showinfo(title='Average', message=msg )
                
def focous_on_unit_entry():
    unit_entry.focus_set()

    
# container frame
container = ttk.Frame(root)
container.pack(padx=10, pady=10, fill='x', expand=True)


# Score
score_label = ttk.Label(container, text="Score:")
score_label.pack(fill='x', expand=True)

score_entry = ttk.Entry(container, textvariable=score)
score_entry.bind('<Return>',  (lambda event: focous_on_unit_entry()))
score_entry.pack(fill='x', expand=True)
score_entry.focus()

# Unit
unit_label = ttk.Label(container, text="Unit:")
unit_label.pack(fill='x', expand=True)

unit_entry = ttk.Entry(container, textvariable=unit)
unit_entry.bind('<Return>',  (lambda event: add_clicked()))
unit_entry.pack(fill='x', expand=True)

# Add button
add_button = ttk.Button(container, text="Add", command=add_clicked)
add_button.pack(expand=True, pady=10)

# Calculate button
calculate_button = ttk.Button(container, text="Calculate", command=calculate_clicked)
calculate_button.pack(fill='x', expand=True, pady=0)

root.mainloop()
