using SmartHomeSystem;

internal class Program
{
    static void Main(string[] args)
    {
        Device device = new Thermostat(101, "ON", 24.5);

        device.DisplayStatus();
    }
}