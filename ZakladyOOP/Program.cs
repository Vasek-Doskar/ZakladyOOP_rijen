namespace ZakladyOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vytvoření instance třídy Pocitac
            Pocitac Dell = new Pocitac(64,"i5","GeForce RTX 950","dell");
            Dell.Zapnout();
            Console.WriteLine(Dell.JeZapnuty() ? "Počítač je zapnutý":"Počítač je vypnutý");
            //Dell.Vypnout();
            //Console.WriteLine(Dell.JeZapnuty() ? "Počítač je zapnutý" : "Počítač je vypnutý");
            Dell.PustitFilm();

            Pocitac HP = new Pocitac(16, "i5", "GeForce RTX 950","hp");
            Dell.OdesliZpravu("Hello World", HP);
        }
    }
}
