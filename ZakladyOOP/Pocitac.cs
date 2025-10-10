namespace ZakladyOOP
{// Třída je POUZE předpis (postup, návod) jak se objekty budou tvořit
    public class Pocitac
    {
        /// <summary>
        /// Toto je dokumentační komentář :)
        /// </summary>
        private int _ram;
        private string _grafika;
        private string _procesor;
        private string _name;
        private bool _zapnuty = false;
        private string _prijataZprava = "";


        public Pocitac(int ram, string grafika, string procesor, string name)
        {
            _ram = ram;
            _grafika = grafika;
            _procesor = procesor;
            _name = name;
        }


        public string VratJmeno() => _name;


        public void Zapnout()
        {
            if (!_zapnuty) // (zapnuty == false)
            {
                _zapnuty = true;
            }
        }

        public void Vypnout()
        {
            if (_zapnuty) // (zapnuty == true)
                _zapnuty = false;
        }

        public bool JeZapnuty() => _zapnuty;

        public void PustitFilm() => Console.WriteLine(
            _zapnuty ?
            "Sleduju fantastickou 4" :
            "Počítač je vypnutý!");


        public void OdesliZpravu(string zprava, Pocitac pocitac)
        {
            pocitac.PrijmiZpravu(zprava,_name);
        }

        private void PrijmiZpravu(string zprava,string jmeno)
        {
            _prijataZprava = zprava;
            Console.WriteLine($"{_name}: Byla přijata zpráva od {jmeno}: " + _prijataZprava);
        }
    }
}
