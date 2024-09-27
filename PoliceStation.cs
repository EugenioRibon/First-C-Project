namespace practica2
{
    class PoliceStation : IMessageWritter
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances.
        private List<PoliceCar> policeCars;
        private string ciudad = "Madrid";

        public PoliceStation()
        {
            //Values of atributes are set just when the instance is done if not needed before.
            policeCars = new List<PoliceCar>();
        }

        public void RegisterCar(PoliceCar car)
        {
            policeCars.Add(car);
            Console.WriteLine(WriteMessage($"Police car with plate: {car.GetPlate} registered"));
        }

        public void ActivateAlert(string offenderPlate)
        {
            Console.WriteLine(WriteMessage($"ALERT! Vehicle with plate {offenderPlate} detected above legal speed"));
            SendAlert(offenderPlate);
        }

        public void SendAlert(string offenderPlate)
        {
            foreach (var car in policeCars)
            {
                car.ReceiveAlert(offenderPlate);
            }
        }
        public string WriteMessage(string customMessage)
        {
            return $"[PoliceStation in {ciudad}] {customMessage}";
        }
    }
}