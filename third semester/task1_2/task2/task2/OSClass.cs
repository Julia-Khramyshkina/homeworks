using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class OSClass
    {
        public OSClass(string input)
        {
            int space = input.IndexOf(' ');
            this.number = Convert.ToInt32(input.Substring(0, space));
            string temp = input.Substring(space + 1, input.Length - space - 1);
            this.probabilityOfInfection = Infection(temp);
        }

        private int Infection(string value)
        {
            if (value == "Windows")
                return 75;

            if (value == "Linux")
                return 66;

            return 80;
        }

        public int ProbabilityOfInfection()
        {
            return this.probabilityOfInfection;
        }

        public void Infected()
        {
            this.infection = true;
        }

        public bool IsInfected()
        {
            return this.infection;
        }

        public void TryInfect(int value)
        {
            if (this.probabilityOfInfection == value)
            {
                this.Infected();
            }
        }

        public int GetNumber()
        {
            return this.number;
        }


        private int number;
        private int probabilityOfInfection;
        private bool infection = false;
    }
}
