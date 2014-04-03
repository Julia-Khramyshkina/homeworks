namespace Homework2_task3
{
    /// <summary>
    /// Realization interface for hashfunction №2.
    /// </summary>
    public class HashNumberTwo : HashFunctionInterface
    {
        public int HashFunction(int newElement)
        {
            int valueOfHashFunction = 0;
            for (int i = 0; i < newElement; ++i)
            {
                valueOfHashFunction = (valueOfHashFunction + newElement * i + i * i) % 500;
            }
            return valueOfHashFunction;
        }
    }
}
