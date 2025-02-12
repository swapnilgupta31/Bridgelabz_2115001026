using System;

// Node Class: Represents a Process
class ProcessNode {
    public int processId;
    public int burstTime;
    public int remainingTime;
    public int priority;
    public ProcessNode next;

    // Constructor
    public ProcessNode(int processId, int burstTime, int priority) {
        this.processId = processId;
        this.burstTime = burstTime;
        this.remainingTime = burstTime;
        this.priority = priority;
        this.next = null;
    }
}

// Circular Linked List Class for Round Robin Scheduling
class RoundRobinScheduler {
    private ProcessNode head = null;
    private ProcessNode tail = null;

    // Add Process at End
    public void AddProcess(int processId, int burstTime, int priority) {
        ProcessNode newProcess = new ProcessNode(processId, burstTime, priority);
        if (head == null) {
            head = tail = newProcess;
            tail.next = head; // Circular link
        } else {
            tail.next = newProcess;
            newProcess.next = head;
            tail = newProcess;
        }
    }

    // Remove Process by Process ID
    public void RemoveProcess(int processId) {
        if (head == null) {
            Console.WriteLine("No processes to remove");
            return;
        }
        ProcessNode temp = head, prev = null;
        do {
            if (temp.processId == processId) {
                if (temp == head) {
                    if (head == tail) {
                        head = tail = null;
                    } else {
                        head = head.next;
                        tail.next = head;
                    }
                } else if (temp == tail) {
                    prev.next = head;
                    tail = prev;
                } else {
                    prev.next = temp.next;
                }
                return;
            }
            prev = temp;
            temp = temp.next;
        } while (temp != head);
        Console.WriteLine("Process not found");
    }

    // Display Process List
    public void DisplayProcesses() {
        if (head == null) {
            Console.WriteLine("No processes available");
            return;
        }
        ProcessNode temp = head;
        do {
            Console.WriteLine("Process ID: " + temp.processId + ", Burst Time: " + temp.burstTime + ", Remaining Time: " + temp.remainingTime + ", Priority: " + temp.priority);
            temp = temp.next;
        } while (temp != head);
    }

    // Simulate Round Robin Scheduling
    public void ExecuteRoundRobin(int timeQuantum) {
        if (head == null) {
            Console.WriteLine("No processes to schedule");
            return;
        }
        int totalProcesses = 0, totalWaitingTime = 0, totalTurnaroundTime = 0;
        ProcessNode temp = head;
        do {
            totalProcesses++;
            temp = temp.next;
        } while (temp != head);

        int[] waitingTime = new int[totalProcesses];
        int[] turnaroundTime = new int[totalProcesses];
        int timeElapsed = 0;

        while (head != null) {
            ProcessNode current = head;
            do {
                if (current.remainingTime > 0) {
                    int executionTime = Math.Min(timeQuantum, current.remainingTime);
                    current.remainingTime -= executionTime;
                    timeElapsed += executionTime;

                    if (current.remainingTime == 0) {
                        int processIndex = current.processId - 1;
                        turnaroundTime[processIndex] = timeElapsed;
                        waitingTime[processIndex] = turnaroundTime[processIndex] - current.burstTime;
                        RemoveProcess(current.processId);
                    }
                }
                current = current.next;
            } while (current != head);
        }

        // Calculate and Display Average Waiting and Turnaround Time
        for (int i = 0; i < totalProcesses; i++) {
            totalWaitingTime += waitingTime[i];
            totalTurnaroundTime += turnaroundTime[i];
        }
        Console.WriteLine("\nAverage Waiting Time: " + (double)totalWaitingTime / totalProcesses);
        Console.WriteLine("Average Turnaround Time: " + (double)totalTurnaroundTime / totalProcesses);
    }
}

// Main Program
class Program {
    static void Main() {
        RoundRobinScheduler scheduler = new RoundRobinScheduler();

        // Adding processes
        scheduler.AddProcess(1, 10, 1);
        scheduler.AddProcess(2, 5, 2);
        scheduler.AddProcess(3, 8, 1);
        scheduler.AddProcess(4, 6, 3);

        // Display initial process list
        Console.WriteLine("Initial Process List:");
        scheduler.DisplayProcesses();

        // Execute Round Robin Scheduling with Time Quantum = 4
        Console.WriteLine("\nExecuting Round Robin Scheduling:");
        scheduler.ExecuteRoundRobin(4);
    }
}
