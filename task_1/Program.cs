namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Types
            //byte very_small_num = 255;
            //sbyte very_small_num_negative = -122;
            //short small_num = 32000;
            //ushort small_num_no_negative = 60000;
            //int number = -10;
            //uint num = 10;
            //long very_long_num = 10000000;
            //ulong very_long_no_negative = 999999999999;
            //float number1 = 3.14f;
            //decimal number2 = 3.14m;
            //double number3 = 3.14;
            //string name = "Michael";
            //char character = 'a';
            //bool y = true;

            //var only works when u initialize the variable
            var x = 10;

            //convert
            Console.WriteLine("Type your name:");
            string name = Console.ReadLine();
            Console.WriteLine("type your age:");
            //int age = Convert.ToInt16(Console.ReadLine());
            //or
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your name: {name}, your age {age}");
            //test


        }
    }
}
