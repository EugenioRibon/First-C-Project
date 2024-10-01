namespace practica2
{
    class PoliceCar : Vehicle
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car";
        private bool isPatrolling;
        private SpeedRadar speedRadar;
        private bool isChasing;

        public PoliceCar(string plate, SpeedRadar radar = null) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            speedRadar = radar;
            isChasing = false;
        }

        public void UseRadar(Vehicle vehicle)
        {
            if (isPatrolling)
            {
                if (speedRadar != null)
                {
                    speedRadar.TriggerRadar(vehicle);
                    string meassurement = speedRadar.GetLastReading();
                    Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));
                }
                else
                {
                    Console.WriteLine(WriteMessage($"has no active radar."));
                }
            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void ReceiveAlert(string offenderPlate)
        {
            if (!isChasing)
            {
                Console.WriteLine(WriteMessage($"Police car started chasing vehicle with plate {offenderPlate}"));
                isChasing = true;
            }
        }
        public void PrintRadarHistory()
        {
            if (speedRadar != null)
            {
                Console.WriteLine(WriteMessage("Report radar speed history:"));
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }
            }
            else
            {
                Console.WriteLine(WriteMessage("No radar to report history."));
            }
        }
    }
}