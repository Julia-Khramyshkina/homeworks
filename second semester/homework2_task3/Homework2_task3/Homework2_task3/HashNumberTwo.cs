namespace NameSpaceForHashAndList
{
    class HashNumberTwo : HashFunctionInterface
    {
        private override int HashFunction(int newElement)
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
