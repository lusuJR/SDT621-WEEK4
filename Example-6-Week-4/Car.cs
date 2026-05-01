namespace Example_6_Week_4
{
    struct Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car staring .... ");
        }

        public void Stop()
        {
            Console.WriteLine("Car Stopping .... ");
        }
    }
}
