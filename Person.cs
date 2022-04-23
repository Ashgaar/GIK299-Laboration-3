using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

namespace Laboration_3
{
    public struct Hair
    {
        private int length;
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }
    }
    public class Person
    {
        private string name;
        private string gender;
        private DateTime birthday;
        private string eyeColor;
        private Hair hair;

        public Person(string na, string gen, DateTime birth, string eyeC, string hairC, int hairL)
        {
            this.name = na;
            this.gender = gen;
            this.birthday = birth;
            this.eyeColor = eyeC;
            this.hair.Length = hairL;
            this.hair.Color = hairC;
        }

        public Hair Hair
        {
            get { return hair; }
            set { hair = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public string EyeColor
        {
            get { return eyeColor; }
            set { eyeColor = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} är en {1}. Deras ögonfärg är {2} och de föddes den {3}. Deras hår är av färgen {4} och är {5} cm långt.", Name, Gender, EyeColor, Birthday.ToString("d"), Hair.Color, Hair.Length);
        }
    }
}