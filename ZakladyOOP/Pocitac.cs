namespace ZakladyOOP
{// Třída je POUZE předpis (postup, návod) jak se objekty budou tvořit
    public class Pocitac
    {
        /// <summary>
        /// Toto je dokumentační komentář :)
        /// </summary>
        /// 
        // Atributy (členské proměnné)
        private int _ram;
        private string _grafika;
        private string _procesor;
        private string _jmeno;

        private bool _zapnuty = false;
        private string _prijataZprava = "";


        // konstruktor - první metoda která vytváří instanci objektu přes klíčové slovo new
        public Pocitac(int ram, string grafika, string procesor, string jmeno)
        {
            Ram = ram;
            Grafika = grafika;
            _procesor = procesor;
            Jmeno = jmeno;
        }


        //public bool JeZapnuty { get => _zapnuty; }
        public bool JeZapnuty => _zapnuty; // jen pro čtení
        public string Procesor
        {
            get => _procesor;
            set
            {
                if (value.Length > 0)
                {
                    _procesor = value;
                }
            }
        }

        public string Jmeno
        {
            get { return _jmeno; }
            set
            {
                if (value.Length > 0)
                {
                    _jmeno = value;
                }
            }
        }

        public string Grafika
        {
            get => _grafika;
            set
            {
                if (value.Length > 0)
                {
                    _grafika = value;
                }
            }
        }

        public int Ram
        {
            get => _ram;
            set
            {
                if (value > 0)
                {
                    _ram = value;
                }
            }
        }


        // metoda třídy Pocitac
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

        public void PustitFilm() => Console.WriteLine(
            _zapnuty ?
            "Sleduju fantastickou 4" :
            "Počítač je vypnutý!");


        public void OdesliZpravu(string zprava, Pocitac pocitac)
        {
            pocitac.PrijmiZpravu(zprava, _jmeno);
        }

        private void PrijmiZpravu(string zprava, string jmeno)
        {
            _prijataZprava = zprava;
            Console.WriteLine($"{_jmeno}: Byla přijata zpráva od {jmeno}: " + _prijataZprava);
        }
    }
}
