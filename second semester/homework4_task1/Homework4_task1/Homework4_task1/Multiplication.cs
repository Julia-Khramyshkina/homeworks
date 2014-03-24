namespace Homework4_task1
{
    public class Multiplication : Operation
    {
        public void MultiplicationOperation()
        {
            this.first().ValueOfInt = (this.first().Left.ValueOfInt) * (this.first().Right.ValueOfInt);
        }
    }
}
