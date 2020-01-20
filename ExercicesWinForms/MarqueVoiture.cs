using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesWinForms
{
    class MarqueVoiture
    {
        public MarqueVoiture(int i, string l)
        {
            id = i;
            label = l;
        }

        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _label;

        public string label
        {
            get { return _label; }
            set { _label = value; }
        }
    }
}
