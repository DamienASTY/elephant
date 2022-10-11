using System;
using System.Collections.Generic;
using System.Text;

namespace elephant
{
    class Elephant
    {
        private string _nom;
        private uint _tailleOreille;
        public Elephant(string nom, uint tailleOreille)
        {
            this._nom = nom;
            this._tailleOreille = tailleOreille;
        }

        public uint tailleOreil()
        {
            return this._tailleOreille;
        }

        public string attr()
        {
            return $"nom : ${this._nom}; tailleOreille : ${this._tailleOreille}";
        }

        public override string ToString()
        {
            return $"Brrrriiieeeuuuuu je suis {this._nom} et mes orreilles font {this._tailleOreille} mêtre";
        }

        public void ecouteMessage(string message, Elephant quiDit)
        {
            Console.WriteLine(this._nom + " a entendu un message \n" + quiDit._nom + " a dit : " + message);
        }
        public void envoieMessage(string message, Elephant quiRecoit)
        {
            quiRecoit.ecouteMessage(message, this);
        }

        public static int quiALesPlusGrosse(Elephant e1, Elephant e2)
        {
            if(e1._tailleOreille > e2._tailleOreille)
            {
                Console.WriteLine($"{e1._nom} à les plus grande oreilles");
                return 0;
            }
            Console.WriteLine($"{e2._nom} à les plus grande oreilles");
            return 0;

        }
    }
}
