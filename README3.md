Design patterns
================

A design pattern is a reusable solution to a software problem.  Design patterns keep code clean and are easy to maintain, it also adheres to the princlples of OOP.

Three pillars of OOP = abstraction, inheritance, polymorphism

Design pattern categories

1. Creational - instantiating objects
2. Structural - code functionality to objects
3. Behavioural - communication between objects



Creational design patterns
================================
Factory method
----------------
Request objects

Abstract factory
-----------------
Related objects

Singleton pattern
------------------
Eliminate the option of instantiating more than one of some object

Structural design patterns
=============================
Decorator pattern
-----------------
Attach responsibilities to object dynamically

Behavioural design patterns
==============================

Observer pattern
-----------------
When object changes state dependencies are notified

Iterator pattern
--------------------
Access and iterate collections regardless of tye

Non-gang of four patterns used in NET.
=============================================
Repository pattern
---------------------
Abstraction between application and data layer.  Convert MVC project to repository pattern

1. Create interface e.g. with CRUD methods
2. Create class e.g. constructor and CRUD operations
3. Create controller e.g. with actions - edit, delete etc
4. Create a generic repository e.g. constructor

Unit of work
------------
Update and keep track of data changes.
