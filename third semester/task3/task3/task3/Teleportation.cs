using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    /// <summary>
    /// Class for processing of teleportation.
    /// </summary>
    public class Teleportation
    {
        private StorageInputData inputData;
        private bool win = false;

        public Teleportation(StorageInputData input)
        {
            inputData = input;
        }
        
        /// <summary>
        /// Processing of teleportation.
        /// </summary>
        public void Processing()
        {
            int size = inputData.GetSize();
            int[,] arrayOfRelations = inputData.GetArrayOfRelations();
            bool[] arrayOfPositions = inputData.GetArrayOfPositions();
            int[] result = new int[size];

            for (int i = 0; i < size; ++i)
            {
                if (arrayOfPositions[i])
                {
                    result[i] = -1;
                }
                else
                {
                    result[i] = 0;
                }
            }

            int temp = size;

            for (int i = 0; i < size; ++i)
            {
                if (arrayOfPositions[i])
                {
                    temp = i;
                    break;
                }
            }

            for (int j = 0; j < size; ++j)
            {
                if (arrayOfRelations[temp, j] == 1)
                {
                    for (int z = 0; z < size; ++z)
                    {
                        if (arrayOfRelations[j, z] == 1)
                        {
                            if (arrayOfPositions[z])
                            {
                                result[z] = 1;
                                temp = z;
                            }
                        }
                    }
                }
            }

            int amount = 0;
            for (int i = 0; i < size; ++i)
            {
                if (result[i] == -1)
                {
                    ++amount;
                }
            }

            if (amount == 0 || amount > 1)
            {
                win = true;
            }
        }

        /// <summary>
        /// Get an answer about the destruction of robots.
        /// </summary>
        /// <returns> Answer.</returns>
        public bool GetAnswer()
        {
            return win;
        }
    }
}
