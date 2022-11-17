using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    internal class Building
    {
        private string Adress { get; set; }
        private float Length { get; set; }
        private float Width { get; set; }
        private float Height { get; set; }


        public Building(string adress, float length, float width, float height)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
        }

        public string Print()
        {
            return $"{Adress}\n{Length}\n{Width}\n{Height}";
        }
    }
}
