namespace practica2
{
    internal class Program
    {

        static void Main()
        {
            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            PoliceCar policeCar1 = new PoliceCar("0001 CNP");
            PoliceCar policeCar2 = new PoliceCar("0002 CNP");
            PoliceStation policeStation = new PoliceStation();
            City city = new City("Madrid", policeStation);
            Console.WriteLine(taxi1.WriteMessage("Created"));
            Console.WriteLine(taxi2.WriteMessage("Created"));
            Console.WriteLine(policeCar1.WriteMessage("Created"));
            Console.WriteLine(policeCar2.WriteMessage("Created"));
            Console.WriteLine(policeStation.WriteMessage("Created"));

            city.RegisterTaxi(taxi1);
            city.RegisterTaxi(taxi1);
            city.RegisterTaxi(taxi2);
            city.PrintLicenses();
            policeStation.RegisterCar(policeCar1);
            policeStation.RegisterCar(policeCar2);
            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);
            policeStation.SendAlert(taxi1.GetPlate());

            taxi2.StartRide();
            policeCar2.UseRadar(taxi2);
            policeCar2.StartPatrolling();
            policeCar2.UseRadar(taxi2);
            taxi2.StopRide();
            policeCar2.EndPatrolling();

            taxi1.StartRide();
            taxi1.StartRide();
            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);
            taxi1.StopRide();
            taxi1.StopRide();
            policeCar1.EndPatrolling();

            policeCar1.PrintRadarHistory();
            policeCar2.PrintRadarHistory();
            city.PrintLicenses();
        }
    }
}


