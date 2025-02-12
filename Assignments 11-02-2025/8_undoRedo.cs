using System;

// Node Class: Represents a state in the editor
class TextState {
    public string content; // Text content
    public TextState prev, next; // Pointers to previous and next states

    // Constructor
    public TextState(string content) {
        this.content = content;
        this.prev = this.next = null;
    }
}

// Doubly Linked List: Manages Undo/Redo History
class TextEditor {
    private TextState head, tail, current;
    private int historySize = 10; // Limit history to 10 states
    private int count = 0;

    // Add a new state when user types or performs an action
    public void AddState(string content) {
        TextState newState = new TextState(content);

        // If adding first state
        if (head == null) {
            head = tail = current = newState;
        } else {
            // Remove redo history if new action is performed
            current.next = null;
            tail = current;

            // Add new state to end
            tail.next = newState;
            newState.prev = tail;
            tail = newState;
            current = tail;

            // Maintain history limit
            if (count == historySize) {
                head = head.next;
                head.prev = null;
            } else {
                count++;
            }
        }
    }

    // Undo functionality (Move to previous state)
    public void Undo() {
        if (current != null && current.prev != null) {
            current = current.prev;
        } else {
            Console.WriteLine("No more undo available.");
        }
    }

    // Redo functionality (Move to next state)
    public void Redo() {
        if (current != null && current.next != null) {
            current = current.next;
        } else {
            Console.WriteLine("No more redo available.");
        }
    }

    // Display current state
    public void DisplayCurrentState() {
        if (current != null) {
            Console.WriteLine("Current Text: " + current.content);
        } else {
            Console.WriteLine("No text available.");
        }
    }
}

// Main Program
class Program {
    static void Main() {
        TextEditor editor = new TextEditor();

        // Adding text states
        editor.AddState("Hello");
        editor.AddState("Hello, World!");
        editor.AddState("Hello, World! This is a text editor.");
        editor.DisplayCurrentState(); // Latest state

        // Undo actions
        Console.WriteLine("\nPerforming Undo:");
        editor.Undo();
        editor.DisplayCurrentState();

        editor.Undo();
        editor.DisplayCurrentState();

        // Redo actions
        Console.WriteLine("\nPerforming Redo:");
        editor.Redo();
        editor.DisplayCurrentState();

        // Adding a new state after undo clears redo history
        editor.AddState("Hello, new world!");
        editor.DisplayCurrentState();
    }
}
