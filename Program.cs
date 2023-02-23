namespace Empwage257
{
    public class Program
    {
       public  static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Emp wage Calculation");
            //UC1 Employee is present or Absent
            const int EMP_PRESENT = 1;
            Random random = new Random();
            int randomInput = random.Next(0, 2);
            if (randomInput == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }



        }
    }
}