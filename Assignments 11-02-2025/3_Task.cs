using System;

// Node Class: Represents a Task
class TaskNode {
    public int taskId;
    public string taskName;
    public int priority;
    public string dueDate;
    public TaskNode next;

    // Constructor
    public TaskNode(int taskId, string taskName, int priority, string dueDate) {
        this.taskId = taskId;
        this.taskName = taskName;
        this.priority = priority;
        this.dueDate = dueDate;
        this.next = this; // Points to itself for circular behavior
    }
}

// Circular Linked List Class
class TaskScheduler {
    private TaskNode head = null;
    private TaskNode tail = null;
    private TaskNode currentTask = null; // Tracks the current task

    // Add Task at Beginning
    public void AddAtBeginning(int taskId, string taskName, int priority, string dueDate) {
        TaskNode newTask = new TaskNode(taskId, taskName, priority, dueDate);
        if (head == null) {
            head = tail = newTask;
            tail.next = head;
        } else {
            newTask.next = head;
            tail.next = newTask;
            head = newTask;
        }
        if (currentTask == null) currentTask = head;
    }

    // Add Task at End
    public void AddAtEnd(int taskId, string taskName, int priority, string dueDate) {
        TaskNode newTask = new TaskNode(taskId, taskName, priority, dueDate);
        if (head == null) {
            head = tail = newTask;
            tail.next = head;
        } else {
            tail.next = newTask;
            newTask.next = head;
            tail = newTask;
        }
        if (currentTask == null) currentTask = head;
    }

    // Add Task at Specific Position (1-based index)
    public void AddAtPosition(int position, int taskId, string taskName, int priority, string dueDate) {
        if (position < 1) {
            Console.WriteLine("Invalid position");
            return;
        }
        if (position == 1) {
            AddAtBeginning(taskId, taskName, priority, dueDate);
            return;
        }
        TaskNode newTask = new TaskNode(taskId, taskName, priority, dueDate);
        TaskNode temp = head;
        for (int i = 1; temp != tail && i < position - 1; i++) {
            temp = temp.next;
        }
        newTask.next = temp.next;
        temp.next = newTask;
        if (temp == tail) tail = newTask;
    }

    // Remove Task by Task ID
    public void RemoveByTaskId(int taskId) {
        if (head == null) {
            Console.WriteLine("Task list is empty");
            return;
        }
        if (head.taskId == taskId) {
            if (head == tail) {
                head = tail = null;
            } else {
                tail.next = head.next;
                head = head.next;
            }
            return;
        }
        TaskNode temp = head;
        do {
            if (temp.next.taskId == taskId) {
                if (temp.next == tail) tail = temp;
                temp.next = temp.next.next;
                return;
            }
            temp = temp.next;
        } while (temp != head);
        Console.WriteLine("Task not found");
    }

    // View Current Task and Move to Next Task
    public void ViewCurrentTask() {
        if (currentTask == null) {
            Console.WriteLine("No tasks available");
            return;
        }
        Console.WriteLine("Current Task -> ID: " + currentTask.taskId + ", Name: " + currentTask.taskName +
                          ", Priority: " + currentTask.priority + ", Due Date: " + currentTask.dueDate);
        currentTask = currentTask.next;
    }

    // Display All Tasks from Head
    public void DisplayAllTasks() {
        if (head == null) {
            Console.WriteLine("No tasks available");
            return;
        }
        TaskNode temp = head;
        do {
            Console.WriteLine("ID: " + temp.taskId + ", Name: " + temp.taskName +
                              ", Priority: " + temp.priority + ", Due Date: " + temp.dueDate);
            temp = temp.next;
        } while (temp != head);
    }

    // Search Task by Priority
    public void SearchByPriority(int priority) {
        if (head == null) {
            Console.WriteLine("No tasks available");
            return;
        }
        TaskNode temp = head;
        bool found = false;
        do {
            if (temp.priority == priority) {
                Console.WriteLine("ID: " + temp.taskId + ", Name: " + temp.taskName + ", Due Date: " + temp.dueDate);
                found = true;
            }
            temp = temp.next;
        } while (temp != head);
        if (!found) Console.WriteLine("No tasks found with the given priority");
    }
}

// Main Program
class Program {
    static void Main() {
        TaskScheduler scheduler = new TaskScheduler();

        // Adding tasks
        scheduler.AddAtBeginning(101, "Task A", 1, "2025-02-10");
        scheduler.AddAtEnd(102, "Task B", 2, "2025-02-12");
        scheduler.AddAtPosition(2, 103, "Task C", 1, "2025-02-11");

        // Display all tasks
        Console.WriteLine("All Tasks:");
        scheduler.DisplayAllTasks();

        // View current task and move to the next
        Console.WriteLine("\nViewing Current Task:");
        scheduler.ViewCurrentTask();
        scheduler.ViewCurrentTask();

        // Search by Priority
        Console.WriteLine("\nSearching for Tasks with Priority 1:");
        scheduler.SearchByPriority(1);

        // Remove a task
        Console.WriteLine("\nRemoving Task with ID 103:");
        scheduler.RemoveByTaskId(103);
        scheduler.DisplayAllTasks();
    }
}
