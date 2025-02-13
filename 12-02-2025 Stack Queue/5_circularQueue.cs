using System;
using System.Collections.Generic;

class CircularTour {
    public static int FindStartingPump(int[] petrol, int[] distance) {
        int totalPetrol = 0, totalDistance = 0;
        int start = 0, fuel = 0;

        for (int i = 0; i < petrol.Length; i++) {
            totalPetrol += petrol[i];
            totalDistance += distance[i];
            fuel += petrol[i] - distance[i];

            if (fuel < 0) {
                start = i + 1; // Reset start point
                fuel = 0; // Reset fuel balance
            }
        }

        return (totalPetrol >= totalDistance) ? start : -1;
    }

    static void Main() {
        int[] petrol = {4, 6, 7, 4};
        int[] distance = {6, 5, 3, 5};

        int startPump = FindStartingPump(petrol, distance);
        Console.WriteLine(startPump == -1 ? "No Solution" : "Starting Pump: " + startPump);
    }
}
