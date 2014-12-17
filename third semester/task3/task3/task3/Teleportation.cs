
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

            int temp = size;
            int positionSave = size;

            for (int i = 0; i < size; ++i)
            {
                if (arrayOfPositions[i])
                {
                    temp = i;
                    positionSave = i;
                    break;
                }
            }
            TeleportationProcess(arrayOfRelations, arrayOfPositions, ref result, ref attend, temp, positionSave);



            //for (int j = 0; j < size; ++j)
            //{
            //    if (arrayOfRelations[temp, j] == 1)
            //    {
            //        for (int z = 0; z < size; ++z)
            //        {
            //            if (arrayOfRelations[j, z] == 1)
            //            {
            //                if (arrayOfPositions[z])
            //                {
            //                    result[z] = 1;
            //                }

            //                temp = z;
            //            }
            //        }
            //    }
            //}

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

        private void TeleportationProcess(int[,] arrayOfRelations, bool[] arrayOfPositions, ref int[] result, ref bool[] attend, int position, int positionSave)
        {
            int size = inputData.GetSize();
            bool attended = true;


            for (int i = 0; i < size; ++i)
            {
                if (arrayOfPositions[position])
                {
                    if (!attend[position])
                    {
                        attended = false;
                    }
                }
            }

            if (attended)
                return;
    
            

            for (int j = 0; j < size; ++j)
            {
                if (arrayOfRelations[position, j] == 1)
                {
                    for (int z = 0; z < size; ++z)
                    {
                        if (arrayOfRelations[j, z] == 1 && !attend[z])
                        {
                            if (arrayOfPositions[z])
                            {
                                result[z] = 1;
                                attend[z] = true;
                                position = z;
                            }

                            position = z;
                        }
                    }
                }
            }

            position = positionSave;
            TeleportationProcess(arrayOfRelations, arrayOfPositions, ref result, ref attend, position, positionSave);

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
