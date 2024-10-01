namespace practica2
{
    class City : IMessageWritter
    {
        //Radar doesn't know about Vehicles, just speed and plates
        private string city;
        private PoliceStation policeStation;
        public List<Taxi> RegisteredTaxis { get; private set; }

        public City(string city, PoliceStation policeStation)
        {
            this.city = city;
            this.policeStation = policeStation;
            RegisteredTaxis = new List<Taxi>();
        }

        public string GetCity()
        {
            return city;
        }

        public void RegisterTaxi(Taxi taxi)
        {
            string plate = taxi.GetPlate();

            if (!RegisteredTaxis.Contains(taxi))
            {
                RegisteredTaxis.Add(taxi);
                Console.WriteLine(WriteMessage($"License {plate} successfully registered in {city}"));
            }
            else
            {
                Console.WriteLine(WriteMessage($"License {plate} is already registered in {city}"));
            }
        }

        public void RemoveLicense(Taxi taxi)
        {
            string plate = taxi.GetPlate();
            if (RegisteredTaxis.Contains(taxi))
            {
                RegisteredTaxis.Remove(taxi);
                Console.WriteLine(WriteMessage($"License {plate} successfully unregistered in {city}"));
            }
            else
            {
                Console.WriteLine(WriteMessage($"License {plate} is not registered in {city}"));
            }
        }

        public void PrintLicenses()
        {
            Console.WriteLine(WriteMessage($"Registered taxi licenses in {city}:"));
            foreach (Taxi taxi in RegisteredTaxis)
            {
                Console.WriteLine(taxi.GetPlate());
            }
        }

        public string WriteMessage(string customMessage)
        {
            return $"{customMessage}";
        }
    }
}
