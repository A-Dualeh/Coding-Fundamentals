using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Need_for_Speed;

class Program
{
    static void Main(string[] args)
    {
        RemoteControlCar car = new RemoteControlCar(5, 4);
       
        car.Drive();
        Console.WriteLine($"Distance driven: {car.DistanceDriven()}");
        Console.WriteLine($"Battery % remaining: {car.Battery()}");
        Console.WriteLine($"Battery drained? {car.BatteryDrained()}");
        
        var Ncar = RemoteControlCar.Nitro();
        Ncar.Drive();
        Console.WriteLine($"\nNitro Distance driven: {Ncar.DistanceDriven()}");
        Console.WriteLine($"Nitro NitroBattery %: {Ncar.Battery()}");
   
        int distance = 100;
        var raceTrack = new RaceTrack(distance);
        Console.WriteLine($"\nCan finish Race? {raceTrack.TryFinishTrack(car)}");
        Console.WriteLine($"Distance driven: {car.DistanceDriven()}");
        Console.WriteLine($"Battery % remaining: {car.Battery()}");
    }
}

