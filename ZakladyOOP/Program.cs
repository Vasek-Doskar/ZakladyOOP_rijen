namespace ZakladyOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vytvoření instance třídy Pocitac
            Pocitac Dell = new Pocitac(64,"i5","GeForce RTX 950","dell");

            Dell.Jmeno = "";
            Console.WriteLine(Dell.Jmeno); // dell
            Dell.Jmeno = "Dell";
            Console.WriteLine(Dell.Jmeno); // Dell
            Dell.Zapnout();
            Console.WriteLine(Dell.JeZapnuty);

            Pocitac Acer = new(32, "i7", "GeForce RTX 950", "acer");

        }
    }
}
