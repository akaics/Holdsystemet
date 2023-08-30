using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holdsystemet
{
    public class Hold
    {

        //Instansfelter

        private string _type;
        private string _lokation;
        private string _betegnelse;
        private int _optagelsesÅr;
        private bool _vinterOptag;

        private Dictionary<int, Studerende> AlleStuderende;


        //properties

        public string Type { get; }
        public string Lokation { get; }
        public string Betegnelse { get; }
        public int OptagelsesÅr { get; }
        public bool VinterOptag { get; }

        //konstruktør + dictionary instansiering:

        public Hold(string type, string lokation, string betegnelse, int optagelsesÅr, bool vinterOptag)
        {
            Type = type; 
            Lokation = lokation;
            Betegnelse = betegnelse;
            OptagelsesÅr = optagelsesÅr;
            VinterOptag = vinterOptag;

            
            
            AlleStuderende = new Dictionary<int, Studerende>();

        }

        //AdderStuderende metode:

        public void AdderStuderende(Studerende studerende)
        {
            AlleStuderende.Add(studerende.ID, studerende);
        }

        //SletStuderende metode: 

        public void SletStuderende(int id)
        {
            AlleStuderende.Remove(id);
        }


        //ToString() metode

        public override string ToString()
        {
            string _result =
             $"Type: {Type}, Lokation: {Lokation}, Betegnelse: {Betegnelse}, VinterOptag: {VinterOptag} ";

            foreach (Studerende s in AlleStuderende.Values)
            {
                _result = _result + s.ToString();
            }

            return _result;

        }

    }

}
