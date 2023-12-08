namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program start");

            int tal1 = 7;
            int tal2 = 0;

            int tal3 = 0;

            try
            {
                tal3 = int.Parse("Halvtreds");
                tal3 = tal1 / tal2;
                Console.WriteLine("Slut af try");
            }
            
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero error");
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("All other exceptions");
                Console.WriteLine(e.ToString());
            }
            finally
            {

            }

            Console.WriteLine(tal3);


            Console.WriteLine("Program slut");

            Console.ReadLine();

        }
    }
}