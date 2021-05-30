
import obd
from tkinter.scrolledtext import ScrolledText
from tkinter import *
from PIL import ImageTk, Image
import tkinter.font
import time

from ttkthemes import ThemedTk
from tkinter.ttk import Combobox
import json
from tkinter import messagebox



def connected():
    pass

def clear_view():
    for slave in tk.grid_slaves():
        slave.destroy()


def render_main_view():
    clear_view()
    Label(tk, text = "Welcome to Racing Pation").grid(column = 0, row = 1, padx = 150, pady = 50)
    Label(tk, text="Please connect to car").grid(column = 0, row = 2, padx = 20, pady = 20)
    Button(tk, text = "Connect to the car computer", bg="lightblue", fg="black", width = 25, command=connectionOBD).grid(column = 0, row = 3, padx = 20, pady = 20)
    Button(tk, text="Exit", bg="lightblue", fg="black", width = 25,  command=tk.destroy).grid(column=0, row=4, padx=20, pady=20)


def connectionOBD():
    clear_view()
    connection = obd.Async(fast = False, timeout = 30)

    #connection = obd.OBD()
    #if connection == True:

    if connection:
        Label(tk, text="Connection sucsessfull").grid(column = 0, row = 0,padx = 150, pady = 50)
        # Entry(tk).grid(column = 0, row = 1, padx = 10, pady = 10)
        Button(tk, text="Show car outputs", bg="lightblue", fg="black", width = 25, command=car_outputs).grid(column=0,row=1, padx = 20, pady = 20)
        Button(tk, text="Back", bg="lightblue", fg="black", width = 25, command=render_main_view).grid(column=0,row=5, padx = 20, pady = 20)

    else:
        Label(tk, text="Can't connect check OBD adapter").grid(column = 0, row = 0,padx = 150, pady = 50)
        Button(tk, text="Connect",bg="lightblue", fg="black", width = 25, command=connectionOBD).grid(column=0,row=1, padx = 50, pady = 100)
        Button(tk, text="Back", bg="lightblue", fg="black", width=25, command=render_main_view).grid(column=0, row=5,padx=20, pady=20)

def car_outputs():
    pass
    #TODO needed car ouptputs RPM's speed temt and etc....
    clear_view()
    rpm_label = Label(tk, text="")
    rpm_label.grid(column = 1, row = 0, padx = 20, pady =20)

    speed_label = Label(tk, text="")
    speed_label.grid(column=1, row=1, padx=20, pady=20)

    temp_label = Label(tk, text="")
    temp_label.grid(column=1, row=2, padx=20, pady=20)

    voltage_label = Label(tk, text="")
    voltage_label.grid(column=1, row=3, padx=20, pady=20)

    fuel_label = Label(tk, text="")
    fuel_label.grid(column=1, row=4, padx=20, pady=20)

    air_label = Label(tk, text="")
    air_label.grid(column=1, row=5, padx=20, pady=20)

    test = 'Testing output'

    rpms = obd.commands.RPM
    speed = obd.commands.SPEED
    coolant = obd.commands.COOLANT_TEMP
    voltage = obd.commands.ELM_VOLTAGE
    fuel = obd.commands.FUEL_STATUS
    air = obd.commands.AIR_STATUS

    Label(tk, text="RPM: ").grid(column=0, row=0, padx=20, pady=20)
    rpm_label.configure(text=str(rpms))

    Label(tk, text="Speed: ").grid(column=0, row=1, padx=20, pady=20)
    speed_label.configure(text = str(speed))

    Label(tk, text="Engine temperature: ").grid(column=0, row=2, padx=20, pady=20)
    temp_label.configure(text = str(coolant))

    Label(tk, text="Voltage: ").grid(column=0, row=3, padx=20, pady=20)
    voltage_label.configure(text = str(voltage))

    Label(tk, text="Fuel status: ").grid(column=0, row=4, padx=20, pady=20)
    fuel_label.configure(text=str(fuel))

    Label(tk, text="Air status: ").grid(column=0, row=5, padx=20, pady=20)
    air_label.configure(text=str(air))

    Button(tk, text="Back", bg="lightblue", fg="black", width=10, command=render_main_view).grid(column=5, row=7, padx=150,pady=90)
    rpm_label.update()
    speed_label.update()

# def read_every_second():
#     #updates output information
#     car_outputs()
#     tk.after(1000, read_every_second())

def error_codes():
    pass
    #TODO needed car error codes
def show_map():
    pass
    #TODO shows live map


if __name__ == '__main__':

    tk = Tk()
    tk.geometry("700x500")
    tk.title("Racing Passion")
    icon = PhotoImage(file ="D:\RacingPassionProject\photos\logo1.png")
    tk.iconphoto(False, icon)
    #tk.configure(background ='black')
    # read_every_second()
    render_main_view()
    tk.update_idletasks()
    tk.mainloop()
