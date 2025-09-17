namespace Library
{
    public class Program
    {
        public static int Collatz(int num)
        {
            int stepsCounter = 0;

            while (num != 1)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num = (num * 3) + 1;
                }

                stepsCounter++;
            }

            return stepsCounter;
        }
    }
}