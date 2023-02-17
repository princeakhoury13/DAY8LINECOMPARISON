namespace DAY8LINES
{
    public class Lines
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates for the first line: ");
            Console.WriteLine("Enter x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter coordinates for the second line: ");
            Console.WriteLine("Enter a1: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b1: ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a2: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b2: ");
            int b2 = Convert.ToInt32(Console.ReadLine());

            LineModelling newline = new LineModelling(x1, y1, x2, y2);
            double l1 = newline.Compare();
            LineModelling newLine2 = new LineModelling(a1, b1, a2, b2);
            double l2 = newLine2.Compare();

            if (l1 == l2)
            {
                Console.WriteLine("The lengths of Line 1 and Line 2 are equal.");
            }
            else if (l1 > l2)
            {
                Console.WriteLine("Line 1 is greater in length than line 2");
            }
            else
            {
                Console.WriteLine("Line 2 is greater in length than line 1");
            }
        }
    }
}