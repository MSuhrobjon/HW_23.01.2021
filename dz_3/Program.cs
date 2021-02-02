using System;

namespace dz_3
{
    class Program
    {
        static void Main(string[] args)
        {
			// 1
			int a = Convert.ToInt32(Console.ReadLine());
			int b = Convert.ToInt32(Console.ReadLine());
			int sum = 0;
			Console.WriteLine("The odd numbers");
			for (int i = a + 1; i < b; i++)
			{
				sum += i;
				if (i % 2 != 0)
				{
					Console.WriteLine(i);
				}
			}
			Console.WriteLine("The summ of numbers");
			Console.WriteLine(sum);
			//2
			int len = 20;
			int len2 = 0;
			for (int d = 0; d < len; d++)
			{
				Console.Write(" ");
			}
			for (int i = 0; i < 46; i++)
			{
				if (i < 20)
				{
					Console.Write("*");
				}
				else if (i < 26)
				{

					Console.Write("\n");
					for (int d = 0; d < len; d++)
					{
						Console.Write(" ");
					}
					Console.Write("*");
					Console.Write("                  " + "*");
				}
			}
			Console.Write("\n");
			for (int j = 0; j < 20; j++)
			{
				Console.Write(" ");
			}
			for (int j = 0; j < 20; j++)
			{
				Console.Write("*");
			}
			Console.Write("\n");
			Console.Write("\n");
			for (int j = 0; j < 10; j++)
			{
				Console.Write("\n");
				for (int d = 0; d < len; d++)
				{
					Console.Write(" ");
				}
				Console.Write("*");
				for (int d = 0; d < j; d++)
				{
					Console.Write(" ");
				}
				Console.Write("*");
			}
			Console.Write("\n");
			for (int j = 0; j < 20; j++)
			{
				Console.Write(" ");
			}
			for (int j = 0; j < 12; j++)
			{
				Console.Write("*");
			}
			Console.Write("\n");
			Console.Write("\n");
			for (int j = 0; j < 10; j++)
			{
				for (int d = 0; d < len; d++)
				{
					Console.Write(" ");
				}
				Console.Write("*");
				for (int d = 0; d < len2; d++)
				{
					Console.Write(" ");
				}
				Console.Write("*");
				Console.Write("\n");
				len--;
				len2 += 2;
			}

			for (int j = 0; j < 10; j++)
			{
				Console.Write(" ");
			}
			for (int j = 0; j < 20; j++)
			{
				Console.Write("*");
			}
			Console.Write("\n");
			Console.Write("\n");
			len = 20;
			len2 = 0;
			for (int j = 0; j < 8; j++)
			{
				for (int d = 0; d < len; d++)
				{
					Console.Write(" ");
				}
				Console.Write("*");
				for (int d = 0; d < len2; d++)
				{
					Console.Write(" ");
				}
				Console.Write("*");
				Console.Write("\n");
				len -= 2;
				len2 += 4;
			}
			for (int j = 0; j < 9; j++)
			{
				for (int d = 0; d < len; d++)
				{
					Console.Write(" ");
				}
				Console.Write("*");
				for (int d = 0; d < len2; d++)
				{
					Console.Write(" ");
				}
				Console.Write("*");
				Console.Write("\n");
				len += 2;
				len2 -= 4;
			}
			//3
			Random rnd = new Random();
			double percent = rnd.Next(0, 25);
			double first_deposit = 1000;
			int mounth;
			Console.WriteLine(percent);
			for (mounth = 1; first_deposit < 1100; mounth++)
			{
				first_deposit = (first_deposit + (first_deposit * percent) / 100);

			}
			Console.WriteLine(mounth);
			Console.WriteLine(first_deposit);
			// 4
			Random rnd = new Random();
			int n = Convert.ToInt32(Console.ReadLine());
			int[] numb = new int[n];
			for (int i = 0; i < n; i++)
			{

				numb[i] = rnd.Next(0, 100);
			}
			foreach (int elem in numb)
			{
				Console.WriteLine(elem);
			}
			Array.Sort(numb);
			Console.WriteLine(numb[n - 1]);
			Console.WriteLine(numb[0]);
			double sum = 0;
			foreach (int elem in numb)
			{
				sum += elem;
			}
			Console.WriteLine(sum);
			Console.WriteLine(sum / n);
			foreach (int elem in numb)
			{
				if (elem % 2 != 0)
				{
					Console.WriteLine(elem);
				}
			}
			//5
			Console.WriteLine("Input size of array: ");
			int val = Convert.ToInt32(Console.ReadLine());
			int[] N = new int[val];
			for (int i = 0; i < val; i++)
			{
				Console.WriteLine("Input number " + i + " :");
				int number = Convert.ToInt32(Console.ReadLine());
				N[i] = number;
			}
			Array.Sort(N);
			Array.Reverse(N);
			foreach (int i in N)
			{
				Console.WriteLine(i);
			}
			// 6
			Console.WriteLine("Input size of array: ");
			int num = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[num];
			for (int i = 0; i < num; i++)
			{
				Console.WriteLine("Input number " + i + " :");
				int number = Convert.ToInt32(Console.ReadLine());
				arr[i] = number;
			}
			foreach (int i in arr)
			{
				Console.WriteLine(i);
			}
			int count = Convert.ToInt32(Console.ReadLine());
			int index = Convert.ToInt32(Console.ReadLine());
			int[] new_arr = new int[count];
			int index_elem = index;
			for (int j = 0; j < count; j++)
			{
				if (index < num)
				{
					new_arr[j] = arr[index];
					index++;
				}
				else
				{
					new_arr[j] = 1;
				}

			}
			foreach (int i in new_arr)
			{
				Console.WriteLine(i);
			}
		}
    }
}
