using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4,67,7,2};
            Console.Write("Yeni massivin olcusunu teyin edin:");
            int Size = Convert.ToInt32(Console.ReadLine());

            ChangeSize(ref arr, Size);
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }

        }

        static void ChangeSize(ref int[] arr,int Size)
        {
            int[] arr2 = new int[Size];
            if (arr2.Length <= arr.Length)
                for (int i = 0; i < Size; i++)
                {
                    arr2[i] = arr[i];
                }

            else
                for (int i = 0; i < arr.Length; i++)
                {
                    arr2[i] = arr[i];
                }

            arr = arr2;
        }

    }
}