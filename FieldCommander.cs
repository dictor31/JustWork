// класс для рисования поля
internal class FieldCommander : ICommander
{
	public FieldCommander()
	{ }

	public void Execute(int[] value)
	{
		// получение ссылки на Graphics для рисования
		Paint paint = Paint.GetInstance();
		// происходит рисование поля, цифры заносятся
		// в объект Field заносятся цифры (одномерный массив
		// в 25 ячеек преобразовываем в двумерный массив 5х5)
		// в объект Robot заносятся координаты

		int[,] characters = new int[5, 5];
		int k = 0;

		for (int i = 0; i < characters.GetLength(0); i++)
		{
			for (int j = 0; j < characters.GetLength(1); j++)
			{
				characters[i, j] = value[k];
				k++;
				Console.Write(characters[i, j] + " ");
			}
			Console.WriteLine();
		}
	}
}