namespace practica2
{
    internal class Program
    {

        static void Main()
        {
            PoliceStation policeStation = new PoliceStation();
            City city = new City("Madrid", policeStation);
            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            PoliceCar policeCar1 = new PoliceCar("0001 CNP", new SpeedRadar());
            PoliceCar policeCar2 = new PoliceCar("0002 CNP");

            city.RegisterTaxi(taxi1);
            city.RegisterTaxi(taxi1);
            city.RegisterTaxi(taxi2);
            city.PrintLicenses();
            policeStation.RegisterCar(policeCar1);
            policeStation.RegisterCar(policeCar2);
            policeCar1.StartPatrolling();
            policeCar2.StartPatrolling();
            policeCar1.UseRadar(taxi1);
            policeCar2.UseRadar(taxi1);

            taxi2.StartRide();
            policeCar1.UseRadar(taxi2);
            policeStation.SendAlert(taxi2.GetPlate());

            city.RemoveLicense(taxi2);
            city.PrintLicenses();
        }
    }
}


