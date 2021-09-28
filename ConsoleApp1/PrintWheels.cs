namespace ConsoleApp1
{
    class PrintWheels<T> where T : IVehicle
    {
        public int GetWheels(T animal)
        {
            return animal.NumberOfWheels;
        }
    }
}
