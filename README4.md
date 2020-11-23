Algorithms
============
1. Linked lists
2. Stack
3. Queue
4. Binary search
5. Linear search

An algorithm is a self contained sequnce of actions that solve a task e.g. performing calculations, data processing, automated tasks

Linkd lists
-------------
There are many types of linked lists

Singly linked list:
Adding items to beginning or end of list.  
1. Create singly linked list class
2. Create methods
3. Create a node class
4. In the node class enter data and then add node class (to make it recursive)
5. Display content

Stack
-----
A stack is an abstract data type that serves as a collection of elements. (Things piled on top of each other). There are two operations - push and pop.

Push - add element to collection

pop - remove most recently added item (last in first out).

To manually create a stack
1. Create a class
2. In the class define variables e.g. maxsie array, index of last position
3. Create a constructor with max size, array and index settings
4. Create push method that takes in parameters. Chec if array is full else add to array
5. Create pop method - chec if it is empty else remove one and return stack array

N.b. .NET has the method .Push and Pop and .Peek which you can use instead of creating a stack manually.

Queue
-----
imilar to stack, a queue is a data structure that serves as a collection of elements.  Two features enquue and dequeue (first in first out)

To manually create a queue:
1. Create a cass with variales
2. Create a constructor

N.b. .NET has the methods .Enqueue() and .Dequeue()

Binary search
------------
Finds the position of a target value within a sorted array.

Continuously compares the target value to the middle element of the array and elimentates irrelevant half of the array.  
Search continues on remaining half until value is found or confirms
does notexist.

1. Create a function that accepts parameters
Set start to 0
set end to n (length of array)
while start <=end/2 // to find the midpoint
if value < start // midpoint
then set end = mid -1 // to find new midpoint
else if value > array midpoint // to know hether to eliminate left or right side

Linear search
--------------
Searches target value within list. Checks each element until target found (or no results).  This type of search is less efficient

.IndexOf()  - searches for object returns index of first one found
