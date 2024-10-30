# Project Overview

This project involves creating a console application that manages products: Phones and Computers. Both classes inherit from a base class called BaseMachine, which contains common properties and methods.

Features
Properties
Phone

Production Date
Serial Number
Name
Description
Operating System
Turkish Licensed (Yes/No)
Computer

Production Date
Serial Number
Name
Description
Operating System
USB Port Count (must be 2 or 4)
Bluetooth (Yes/No)
Class Structure
Inheritance:

Phone and Computer classes inherit from BaseMachine.
Encapsulation:

The USB port count for Computers can only be set to 2 or 4. If any other value is provided, it will be set to -1 and an error message will be displayed.
Automatic Property Assignment:

The Production Date is automatically set when an object is created for both Phones and Computers.
Polymorphism:

A method named PrintInfo() is defined in the BaseMachine class to print common information. This method is overridden in the derived classes to include specific properties.
Abstraction:

An abstract method named GetProductName() is defined in the BaseMachine class. It is implemented in both Phone and Computer classes to print:
"Your phone's name ---> ......"
"Your computer's name ---> ......"
Program Flow
The console prompts the user to press 1 to create a Phone or 2 to create a Computer.
Based on the user's selection, an object is instantiated, and the relevant properties are collected from the user.
After all information is entered, a success message is displayed, asking if the user would like to create another product.
If the user responds with 'yes', the program returns to step 1. If 'no', a farewell message is displayed and the application terminates.
