using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANIMAL
{
    public class Program
    {
        public class animal
        {
            private string nameOfAnimal;
            private string habitat_area;
            private string sound;
            private int weight;
            private int height;

            public Animal()
            {
                this.nameOfAnimal = nameOfAnimal;
                this.habitat_area = habitat_area;
                this.sound = sound;
                this.weight = weight;
                this.height = height;

            }
            public string NameOfAnimal
            {
                get { return nameOfAnimal;}
                set { nameOfAnimal = value;}
            }
            public string HabitatArea
            {
                get { return habitat_area;}
                set { habitat_area = value;}
            }
            public int Height
            {
                get { return height;}
                set { height = value;}
            }

        }
        static void Main(string[] args)
        {
        }
    }
}
