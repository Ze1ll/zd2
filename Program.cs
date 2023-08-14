class Program
{
	static void Main()
		{

			Console.WriteLine("Напишите номер задачи");
			int numzad = Convert.ToInt32(Console.ReadLine());
			switch (numzad)
		{
			case 1: //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
				{
					int temp = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine((temp / 10) % 10);    
				}
				break;
			case 2: //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
				{
					string temp = Console.ReadLine();

					try 
					{
						Console.WriteLine(temp[2]);
					}
					catch
					{
						Console.WriteLine("третья цифра отсутсвует");
					}


				}
				break;
			case 3: // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
				{
					int temp = Convert.ToInt32(Console.ReadLine());
					if (temp==6 || temp==7)
					{
						Console.WriteLine("Да");
					}
					else
					{
						Console.WriteLine("Нет");
					}
				}
				break;
		}

		}
}