Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] arg)
{
	int counter = 0;
	int length = arg.Length;
	while (counter < length)
	{
		arg[counter] = Convert.ToInt32(Math.Pow(counter, 3));
		counter++;
	}
}

void PrintArray(int[] written)
{
	int count = written.Length;
	int index = 0;
	while (index < count)
	{
		Console.Write(written[index] + " ");
		index++;
	}
}

int[] array = new int[cube + 1];
Cube(array);
PrintArray(array);
