namespace DAY8LINES
{
    public class Lines
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());


            LineModelling newline = new LineModelling(x1, y1, x2, y2);
            newline.Compare();
        }
    }
}