using System;

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
        public void Process()
        {
            int size = inputData.GetSize();
            int[,] arrayOfRelations = inputData.GetArrayOfRelations();
            bool[] arrayOfPositions = inputData.GetArrayOfPositions();
            int[] result = new int[size];
            bool[] attend = new bool[size];

            for (int i = 0; i < size; ++i)
            {
                attend[i] = false;
                if (arrayOfPositions[i])
                {
                    result[i] = -1;
                }
                else
                {
                    result[i] = 0;
                }
            }

            int position = size;

            for (int i = 0; i < size; ++i)
            {
                if (arrayOfPositions[i])
                {
                    position = i;
                    break;
                }
            }

            if (position == size)
            {
                win = true;
                return;
            }

            TeleportationProcess(arrayOfRelations, arrayOfPositions, ref result, ref attend, position);

            int amountOfBlackNodes = 0;
            int amountOfWhiteNodes = 0;
            for (int i = 0; i < size; ++i)
            {
                if (result[i] == -1)
                {
                    ++amountOfBlackNodes;
                }

                if (result[i] == 1)
                {
                    ++amountOfWhiteNodes;
                }
            }

            if ((amountOfBlackNodes == 0 || amountOfBlackNodes > 1) && (amountOfWhiteNodes == 0 || amountOfWhiteNodes > 1))
            {
                win = true;
            }
        }

        /// <summary>
        /// Teleportation robots in the graph.
        /// </summary>
        /// <param name="arrayOfRelations"> Array of relations in the graph.</param>
        /// <param name="arrayOfPositions"> Array of positions of robots.</param>
        /// <param name="result"> Array with result of teleportation.</param>
        /// <param name="attend"> Array with attended vertices.</param>
        /// <param name="position"> Current position.</param>
        private void TeleportationProcess(int[,] arrayOfRelations, bool[] arrayOfPositions, ref int[] result, ref bool[] attend, int position)
        {
            int size = inputData.GetSize();    
            for (int j = 0; j < size; ++j)
            {
                if (arrayOfRelations[position, j] == 1)
                {
                    for (int vertex = 0; vertex < size; ++vertex)
                    {
                        if (arrayOfRelations[j, vertex] == 1 && !attend[vertex])
                        {
                            if (arrayOfPositions[vertex])
                            {
                                result[vertex] = 1;
                            }

                            attend[vertex] = true;
                            position = vertex;
                            TeleportationProcess(arrayOfRelations, arrayOfPositions, ref result, ref attend, position);              
                        }
                    }
                }
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
