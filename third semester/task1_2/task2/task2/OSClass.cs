using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    /// <summary>
    /// Class for simulation OS.
    /// </summary>
    public class OSClass
    {
        public OSClass(string input)
        {
            int space = input.IndexOf(' ');
            this.number = Convert.ToInt32(input.Substring(0, space));
            string temp = input.Substring(space + 1, input.Length - space - 1);
            this.probabilityOfInfection = Infection(temp);
        }

        /// <summary>
        /// Get value, which illustrates the probability of infection.
        /// </summary>
        /// <param name="value">Name of OS.</param>
        /// <returns></returns>
        private int Infection(string value)
        {
            if (value == "Windows")
                return 75;

            if (value == "Linux")
                return 66;

            return 80;
        }

        /// <summary>
        /// Get value about probabilty of infection.
        /// </summary>
        /// <returns></returns>
        public int ProbabilityOfInfection()
        {
            return this.probabilityOfInfection;
        }

        /// <summary>
        /// Infection occurs.
        /// </summary>
        public void Infected()
        {
            this.infection = true;
        }

        /// <summary>
        /// Check for infection.
        /// </summary>
        /// <returns></returns>
        public bool IsInfected()
        {
            return this.infection;
        }

        /// <summary>
        /// Attempt to infect.
        /// </summary>
        /// <param name="value">Value for attempt.</param>
        public void TryInfect(int value)
        {
            if (this.probabilityOfInfection <= value)
            {
                this.Infected();
            }
        }

        private int number;
        private int probabilityOfInfection;
        private bool infection = false;
    }
}
