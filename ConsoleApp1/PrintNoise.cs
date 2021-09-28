namespace ConsoleApp1
{
    class PrintNoise<T> where T: IAnimal
    {
        public string GetNoise(T animal)
        {
            return animal.Noise;
        }
    }
}
