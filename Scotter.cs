namespace practica2
{
    class Scooter : Vehicle
    {
        private const string typeOfVehicle = "Scooter";

        // Constructor que no requiere matrícula
        public Scooter() : base(typeOfVehicle, null) // Matrícula es null
        {
        }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} without plate"; // Representación específica para Scooter
        }

        // Opcional: Puedes agregar más métodos específicos para Scooter si es necesario
    }
}
