namespace b_delegate_event;

public delegate void TrafficLightChangeHandler(string color);

public class TrafficLight
{
    public event TrafficLightChangeHandler TrafficLightChanged;

    public void ChangeLight(string color)
    {
        Console.WriteLine("The traffic light is " + color + " color");
        TrafficLightChanged?.Invoke(color);
    }
}

public class Car
{
    public void ResponseToLight(string lightColor)
    {
        if (lightColor == "red")
        {
            Console.WriteLine("Car Stopped!");
        }
        else if (lightColor == "green")
        {
            Console.WriteLine("Car Moves");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TrafficLight light = new TrafficLight();
        Car car = new Car();

        light.TrafficLightChanged += car.ResponseToLight;

        light.ChangeLight("red");
        light.ChangeLight("green");
    }
}
