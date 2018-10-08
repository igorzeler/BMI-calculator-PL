namespace BMIConsole
{
    class Person
    {
        public int Weight { get; private set; }
        public double Height { get; private set; }

        public Person(int weight, double height)
        {
            Weight = weight;
            Height = height;
        }

        public double getBMI()
        {
            return Weight / (Height * Height);
        }
    }
}
