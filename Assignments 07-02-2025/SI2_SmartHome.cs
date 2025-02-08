using System;

class Device {
    public string DeviceId { get; set; } // Unique ID for the device
    public string Status { get; set; } // Device status (ON/OFF)

    public virtual void DisplayStatus() {
        Console.WriteLine("Device ID: " + DeviceId);
        Console.WriteLine("Status: " + Status);
    }
}

// Thermostat subclass that extends Device
class Thermostat : Device {
    public double TemperatureSetting { get; set; } // Current temperature setting

    public override void DisplayStatus() {
        base.DisplayStatus(); // Call base class method
        Console.WriteLine("Temperature Setting: " + TemperatureSetting + "°C");
    }
}

class Program {
    public static void Main(string[] args) {
        // Creating a Thermostat object (inherits from Device)
        Thermostat smartThermostat = new Thermostat {
            DeviceId = "TH123",
            Status = "ON",
            TemperatureSetting = 22.5
        };

        // Display thermostat status
        smartThermostat.DisplayStatus();
    }
}
