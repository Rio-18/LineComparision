namespace LineComaprison
{
    public class CompareTwoLines
    {
        private int v1;
        private int v2;
        private int v3;
        private int v4;
        public CompareTwoLines(int v1,int v2,int v3,int v4)
        { 
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;

        }
        static void Main(string[] args)
        {
            CompareTwoLines length_One = new CompareTwoLines(4, 2, 7, 3);
            double length = length_One.CalculateOne();

            CompareTwoLines length_Two = new CompareTwoLines(5, 4, 5, 6);
            double length_ = length_Two.CalculateTwo();

            if (length.CompareTo(length_) == 0)
                Console.WriteLine("Both lines are equal ");
            else if (length.CompareTo(length_) > 0)
                Console.WriteLine("Line one is greater");
            else
                Console.WriteLine("Line two is greater");
            Console.ReadLine();
        }
        private double CalculateOne()
        {
            throw new NotImplementedException();
        }
        private double CalculateTwo()
        {
            throw new NotImplementedException();
        }
    }
}