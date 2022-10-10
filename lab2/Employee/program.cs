namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Employee employee1 = new Employee("Maxim", "Priadka", Position.Developer, Experience.Junior);
            

            Console.WriteLine(employee1.ToString());
          
        }
    }
}