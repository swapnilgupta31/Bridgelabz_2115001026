using System;
using System.Collections.Generic;

class QueueUsingStack{
    //creating stacks.
    private Stack<int> stack1 = new Stack<int>();
    private Stack<int> stack2 = new Stack<int>();

    public void Enqueue(int item){
        stack1.Push(item); //Simply to push item in stack1 
    }

    public int Dequeue(){
        if (stack2.Count == 0){  //to check if the stack2 is empty
            if(stack1.Count == 0){ //to check if stack1 is also empty
                Console.WriteLine("Queue is Empty. ");
                return -1;
            }
            while (stack1.Count > 0){ //can only dequeue if stack1 has some elements.
                stack2.Push(stack1.Pop()); //to pop the element from stack1 and to push in stack2.

            }

        }
        return stack2.Pop(); //if stack2 is not empty then pop the element from stack2.
    }

    public void Display(){
        if (stack1.Count == 0 && stack2.Count == 0){ //if both the stack are empty
            Console.WriteLine("Queue is Empty .");
            return;
        }
        foreach (var item in stack2){ //to traverse stack2 and print
            Console.Write(item+ " ");
        }
        var tempList = new List<int>(stack1); //to convert stack1 into list.
        tempList.Reverse(); //reverse the elements.
        foreach (var item in tempList){
            Console.Write(item +" ");
        }
        Console.WriteLine();
    }
}
class Program{
    static void Main(){
        QueueUsingStack queue = new QueueUsingStack(); //to create instance of the class
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Display();
        Console.WriteLine("Dequeued: " + queue.Dequeue()); //will return the element been first added to stack1
        queue.Display();
        queue.Enqueue(4);
        queue.Display();
    }
}
