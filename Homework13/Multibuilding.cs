using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    sealed class Multibuilding : Building
    {
        private int levels;

        private int Levels
        {
            get
            {
                return levels;
            }
            set
            {
                if (value < 0)
                {
                    levels = 1;
                }
                else
                {
                    levels = value;
                }
            }
        }

        public Multibuilding(string adress, float length, float width, float heigt, int levels)
            : base(adress, length, width, heigt)
        {
            Levels = levels;
        }


        public string Print()
        {
            string result = base.Print();
            result += $"\n{levels}";
            return result;
        }
    }
}
