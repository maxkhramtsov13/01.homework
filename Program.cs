//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

internal class Program
{
	private static void Main(string[] args)
	{
		Console.Write($"Enter the number ->  ");
		int n = Convert.ToInt32(Console.ReadLine());

		for (int i = 1; i <= n; i++)  //Можно ( int i = 2; i <= n; i += 2)
			if (i % 2 == 0)
			{
				Console.Write($"| Even number ->  ");
				Console.WriteLine(i);
			}
	}

}