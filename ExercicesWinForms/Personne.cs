using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesWinForms
{
    class Personne
    {

        public Personne(int i, string lastname, string firstname, string birthdate)
        {
            id = i;
            nom = lastname;
            prenom = firstname;
            datenaissance = birthdate;
        }

        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nom;

        public string nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private string _prenom;

        public string prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        private string _datenaissance;

        public string datenaissance
        {
            get { return _datenaissance; }
            set { _datenaissance = value; }
        }

    }
}
