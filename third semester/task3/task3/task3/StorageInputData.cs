using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
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

        public int ExistingWay(int line, int column)
        {
            return arrayOfRelations[line, column];
        }

        public int[,] GetArrayOfRelations()
        {
            return arrayOfRelations;
        }

        public int GetSize()
        {
            return size;
        }

        public bool[] GetArrayOfPositions()
        {
            return startPosition;
        }
    }
}
