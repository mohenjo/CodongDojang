using System.Linq;

namespace 배열의최대값최소값중간값을출력해보기
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 1, 2, 3, 4, 5 };
            var rst = GetAnswer(inputArray);
            System.Console.WriteLine($"min: {rst.Item1}\nmid: {rst.Item2}\nmax: {rst.Item3}");
        }

        static (int, int, int) GetAnswer(int[] anArray)
        {
            BubbleSort(anArray);
            int minVal = anArray[0];
            int maxVal = anArray.Last();
            int midVal = anArray[anArray.Length / 2];
            return (minVal, midVal, maxVal);
        }

        // for, if 문을 사용하여 배열 소트
        static void BubbleSort(int[] anArray)
        {
            int len = anArray.Length;
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - i - 1; j++)
                {
                    if (anArray[j] > anArray[j + 1])
                    {
                        int tmp = anArray[j];
                        anArray[j] = anArray[j + 1];
                        anArray[j + 1] = tmp;
                    }
                }
            }
        }

    }
}
