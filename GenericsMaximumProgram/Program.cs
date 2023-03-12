namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {

            MaximumCheck fmax = new MaximumCheck();
            float fresult = fmax.MaximumFloat(4.2f, 2.2f, 2.3f);
            Console.WriteLine(fresult);

            fresult = fmax.MaximumFloat(2.4f, 4.6f, 3.4f);
            Console.WriteLine(fresult);

            fresult = fmax.MaximumFloat(2.4f, 4.6f, 6.9f);
            Console.WriteLine(fresult);
        }
    }
}