namespace Address
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Address address = new Address();
            address.Index = 212;
            address.Country = "Ukraine";
            address.City = "Kyiv";
            address.Street = "Khreshchatyk";
            address.House = "12";
            address.Apartment = "34";

            Console.WriteLine(address.ToString());
        }
    }
}