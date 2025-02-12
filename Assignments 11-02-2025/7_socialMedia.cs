using System;
using System.Collections.Generic;

// Node Class: Represents a User
class UserNode {
    public int userId;
    public string name;
    public int age;
    public List<int> friends;
    public UserNode next;

    // Constructor
    public UserNode(int userId, string name, int age) {
        this.userId = userId;
        this.name = name;
        this.age = age;
        this.friends = new List<int>();
        this.next = null;
    }
}

// Singly Linked List Class
class SocialNetwork {
    private UserNode head;

    // Add a New User
    public void AddUser(int userId, string name, int age) {
        UserNode newUser = new UserNode(userId, name, age);
        if (head == null) {
            head = newUser;
            return;
        }
        UserNode temp = head;
        while (temp.next != null) {
            temp = temp.next;
        }
        temp.next = newUser;
    }

    // Find a User by ID
    private UserNode FindUser(int userId) {
        UserNode temp = head;
        while (temp != null) {
            if (temp.userId == userId) {
                return temp;
            }
            temp = temp.next;
        }
        return null;
    }

    // Add a Friend Connection
    public void AddFriend(int userId1, int userId2) {
        UserNode user1 = FindUser(userId1);
        UserNode user2 = FindUser(userId2);

        if (user1 == null || user2 == null) {
            Console.WriteLine("User not found");
            return;
        }
        if (!user1.friends.Contains(userId2)) {
            user1.friends.Add(userId2);
        }
        if (!user2.friends.Contains(userId1)) {
            user2.friends.Add(userId1);
        }
    }

    // Remove a Friend Connection
    public void RemoveFriend(int userId1, int userId2) {
        UserNode user1 = FindUser(userId1);
        UserNode user2 = FindUser(userId2);

        if (user1 == null || user2 == null) {
            Console.WriteLine("User not found");
            return;
        }
        user1.friends.Remove(userId2);
        user2.friends.Remove(userId1);
    }

    // Find Mutual Friends Between Two Users
    public void FindMutualFriends(int userId1, int userId2) {
        UserNode user1 = FindUser(userId1);
        UserNode user2 = FindUser(userId2);

        if (user1 == null || user2 == null) {
            Console.WriteLine("User not found");
            return;
        }

        List<int> mutualFriends = new List<int>();
        foreach (int friend in user1.friends) {
            if (user2.friends.Contains(friend)) {
                mutualFriends.Add(friend);
            }
        }

        Console.Write("Mutual Friends: ");
        if (mutualFriends.Count == 0) {
            Console.WriteLine("None");
        } else {
            Console.WriteLine(string.Join(", ", mutualFriends));
        }
    }

    // Display All Friends of a User
    public void DisplayFriends(int userId) {
        UserNode user = FindUser(userId);
        if (user == null) {
            Console.WriteLine("User not found");
            return;
        }
        Console.Write("Friends of " + user.name + ": ");
        if (user.friends.Count == 0) {
            Console.WriteLine("None");
        } else {
            Console.WriteLine(string.Join(", ", user.friends));
        }
    }

    // Search User by Name or User ID
    public void SearchUser(string nameOrId) {
        UserNode temp = head;
        bool found = false;
        while (temp != null) {
            if (temp.userId.ToString() == nameOrId || temp.name.Equals(nameOrId, StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("User ID: " + temp.userId + ", Name: " + temp.name + ", Age: " + temp.age);
                found = true;
            }
            temp = temp.next;
        }
        if (!found) {
            Console.WriteLine("User not found");
        }
    }

    // Count the Number of Friends for Each User
    public void CountFriends() {
        UserNode temp = head;
        while (temp != null) {
            Console.WriteLine("User " + temp.name + " has " + temp.friends.Count + " friends.");
            temp = temp.next;
        }
    }
}

// Main Program
class Program {
    static void Main() {
        SocialNetwork network = new SocialNetwork();

        // Adding users
        network.AddUser(1, "Alice", 25);
        network.AddUser(2, "Bob", 24);
        network.AddUser(3, "Charlie", 27);
        network.AddUser(4, "David", 26);

        // Adding friendships
        network.AddFriend(1, 2);
        network.AddFriend(1, 3);
        network.AddFriend(2, 3);
        network.AddFriend(3, 4);

        // Display friends of each user
        Console.WriteLine("\nDisplaying Friends:");
        network.DisplayFriends(1);
        network.DisplayFriends(2);
        network.DisplayFriends(3);
        network.DisplayFriends(4);

        // Find mutual friends
        Console.WriteLine("\nFinding Mutual Friends:");
        network.FindMutualFriends(1, 3);
        network.FindMutualFriends(2, 4);

        // Searching users
        Console.WriteLine("\nSearching Users:");
        network.SearchUser("Alice");
        network.SearchUser("3");

        // Counting friends for each user
        Console.WriteLine("\nCounting Friends:");
        network.CountFriends();

        // Removing a friend connection
        Console.WriteLine("\nRemoving Friend Connection:");
        network.RemoveFriend(1, 3);
        network.DisplayFriends(1);
        network.DisplayFriends(3);
    }
}
