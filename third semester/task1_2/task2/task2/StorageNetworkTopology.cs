using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    /// <summary>
    /// Creation and storage data about network.
    /// </summary>
    public class StorageNetworkTopology
    {
        private StreamReader input = new StreamReader("input.txt");
        private int size;
        private int[,] arrayOfRelations;
        private OSClass[] matrixOfComputers;

        public StorageNetworkTopology()
        {
            this.ProcessingDataOfNetwork();
        }

        /// <summary>
        /// Processing input data.
        /// </summary>
        public void ProcessingDataOfNetwork()
        {
            string line;
            string[] buf;
            size = int.Parse(input.ReadLine());
            arrayOfRelations = new int[size, size];

            matrixOfComputers = new OSClass[size];

            for (int i = 0; i < size; ++i)
            {
                line = input.ReadLine();
                matrixOfComputers[i] = new OSClass(line);
            }

            int variable = 0;
            line = input.ReadLine();
            while (line != null)
            {
                buf = line.Split(' ');
                for (int j = 0; j < buf.Length; ++j)
                {
                    arrayOfRelations[variable, j] = Convert.ToInt32(buf[j]);
                }
                ++variable;
                line = input.ReadLine();
            }
        }

        /// <summary>
        /// Get information about current state of this computer.
        /// </summary>
        /// <param name="currentNumber">Number of this computer.</param>
        /// <returns>Current state.</returns>
        public bool IsInfected(int currentNumber)
        {
            return matrixOfComputers[currentNumber].IsInfected();
        }

        /// <summary>
        /// Get size of this network.
        /// </summary>
        /// <returns>Value of size.</returns>
        public int SizeOfTopology()
        {
            return size;
        }

        /// <summary>
        /// Get information about availability of connect computers.
        /// </summary>
        /// <param name="computer1">First computer</param>
        /// <param name="computer2">Second computer</param>
        /// <returns>Availability of connect.</returns>
        public bool Relations(int computer1, int computer2)
        {
            return arrayOfRelations[computer1, computer2] == 1;
        }

        /// <summary>
        /// Try to infect this computer.
        /// </summary>
        /// <param name="value">Probability of infection.</param>
        /// <param name="computer">Current computer.</param>
        public void TryInfect(int value, int computer)
        {
            matrixOfComputers[computer].TryInfect(value);
        }
    }
}
