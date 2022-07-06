
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

void numberCheck(string sign)
{
	if (sign[0] == sign[4] || sign[1] == sign[3])
	{
		Console.WriteLine("Ваше число - палиндром.");
	}
	else Console.WriteLine("Ваше число -  не палиндром.");
}

if (number.Length == 5)
{
	numberCheck(number);
}
else Console.WriteLine("Введи пятизначное число");
