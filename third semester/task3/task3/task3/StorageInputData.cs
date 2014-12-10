using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    /// <summary>
    /// Class for data of input.
    /// </summary>
    public class StorageInputData
    {
        private StreamReader input;
        private int size;
        private int[,] arrayOfRelations;
        private bool[] startPosition;

        public StorageInputData(StreamReader input1)
        {
            input = input1;
            this.ProcessingInputData();
        }

        /// <summary>
        /// Processing data of input.
        /// </summary>
        public void ProcessingInputData()
        {
            string line;
            string[] buf;
            size = int.Parse(input.ReadLine());
            arrayOfRelations = new int[size, size];
            startPosition = new bool[size];

            int i = 0;
            line = input.ReadLine();
            while (line != "" && line != null)
            {
                buf = line.Split(' ');
                for (int j = 0; j < buf.Length; ++j)
                {
                    arrayOfRelations[i, j] = Convert.ToInt32(buf[j]);
                }
                ++i;
                line = input.ReadLine();
            }          

            for (int variable = 0; variable < size; ++variable)
            {
                startPosition[variable] = false;
            }

            line = input.ReadLine();

            while (line != "" && line != null)
            {
                int currentNumber = Convert.ToInt32(line);
                startPosition[currentNumber] = true;
                line = input.ReadLine();
            }
        }

        /// <summary>
        /// Get array of relationships between vertices.
        /// </summary>
        /// <returns> Array of relations.</returns>
        public int[,] GetArrayOfRelations()
        {
            return arrayOfRelations;
        }

        /// <summary>
        /// Get the number of vertices in the graph.
        /// </summary>
        /// <returns> Number of vertices.</returns>
        public int GetSize()
        {
            return size;
        }

        /// <summary>
        /// Get array of positions with robots.
        /// </summary>
        /// <returns> Array of relations.</returns>
        public bool[] GetArrayOfPositions()
        {
            return startPosition;
        }
    }
}
