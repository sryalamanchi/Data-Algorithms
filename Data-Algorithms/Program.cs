using System;

namespace Data_Algorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			//Sorting Descending
			int[] intArray = new int[] { 2, 3, 4, 5, 9 };
			int temp = 0;
			for (int i = 0; i <= intArray.Length - 1; i++)
			{
				for (int j = i + 1; j < intArray.Length; j++)
				{
					if (intArray[i] < intArray[j])
					{
						temp = intArray[i];
						intArray[i] = intArray[j];
						intArray[j] = temp;
					}
				}
			}

		}
	}
}
