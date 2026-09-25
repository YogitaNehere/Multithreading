# Multithreading
A thread is the smallest unit of execution within a process.

Each thread has its own stack and local variables.

Program
  ↓
Process
  ↓
Threads (lightweight subprocesses)

A thread represents a path of execution inside a program.

A process can contain multiple threads

All threads share the same memory

Each thread has its own stack and execution flow

Multithreading in C#:-
Multithreading is a technique in which a single program (process) is divided into multiple threads that execute concurrently while sharing the same resources.

The thread has four different states:-

1)  Init State:-  When we create Thread Class Object

2)  Runnable State:-  When we start Thread

3) Waiting State:-  When we use sleep() in Thread

4) End State or Destroy State:-  When the process is completed then the end state

Join() makes the calling thread wait until the specified thread completes its execution.

Thread Synchronization

Thread synchronization is the process of controlling the execution of multiple threads so that shared resources are accessed in a safe and predictable manner.


Two threads try to access the same method

lock ensures only one thread executes it at a time