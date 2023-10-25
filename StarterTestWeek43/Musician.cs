using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterTestWeek43
{
    public class Musician
    {
        private List<Instrument> _instruments;

        //implementer instance fields og properties ud fra klassediagrammet

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private int _experience;

        public int Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }

        public Musician(string name, string address, int experience)
        {
            _instruments = new List<Instrument>();
            _name = name;
            _address = address;
            _experience = experience;
        }

        /// <summary>
        /// Metoden skal tilføje et instrument til listen 
        /// Der må ikke forekomme to instrumenter med samme id
        /// </summary>
        /// <param name="intstrument"></param>
        public bool AddInstrument(Instrument instrument)
        {
            // TODO: Opgave 8 
            //Skriv sætninger der tilføjer et instrument til listen
            //Der må ikke forekomme to instrumenter der har samme id
            
            return false;
        }

        public override string ToString()
        {
            // TODO: Opgave 9 
            // Skriv sætninger der udskriver alle informationer om musikeren og alle instrumenter
            
            return "";
        }
    }
}
