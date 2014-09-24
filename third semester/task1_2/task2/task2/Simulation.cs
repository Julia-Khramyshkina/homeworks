using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    /// <summary>
    /// Class for simulation network.
    /// </summary>
    public class Simulation
    {
        private StorageNetworkTopology networkTopology = new StorageNetworkTopology();
        private Random rand;

        public Simulation(Random currentRand)
        {
            rand = currentRand;
            networkTopology.TryInfect(100, 0);
        }

        /// <summary>
        /// Change states of compurets. Try to infect them.
        /// </summary>
        public void ChangeNetworkState()
        {
            bool[] infected = new bool[networkTopology.SizeOfTopology()];
            for (int i = 0; i < networkTopology.SizeOfTopology(); ++i)
            {
                infected[i] = networkTopology.IsInfected(i);
            }

            int temp = rand.Next(1, 100);
            for (int i = 0; i < networkTopology.SizeOfTopology(); ++i)
            {
                if (infected[i])
                {
                    for (int j = 0; j < networkTopology.SizeOfTopology(); ++j)
                    {
                        if (networkTopology.Relations(i, j))
                        {
                            networkTopology.TryInfect(temp, j);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Show state of current computer.
        /// </summary>
        /// <param name="currentComputer">Number of computer.</param>
        /// <returns>State of computer.</returns>
        public string ShowState(int currentComputer)
        {
            if (networkTopology.IsInfected(currentComputer))
            {
                return "is infected.";
            }
            else
            {
                return "is healthy.";
            }
        }

        /// <summary>
        /// Get value about size of network.
        /// </summary>
        /// <returns>Size of this network.</returns>
        public int NumberOfComputers()
        {
            return networkTopology.SizeOfTopology();
        }

        /// <summary>
        /// Show states of all computers in network.
        /// </summary>
        public void ShowAllStates()
        {
            for (int i = 0; i < networkTopology.SizeOfTopology(); ++i)
            {
                System.Console.WriteLine(i.ToString() + ' ' + ShowState(i));   
            }
        }
    }
}
