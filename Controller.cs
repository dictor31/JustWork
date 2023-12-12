// класс для ввода данных
internal class Controller
{
	private MainCommander mainCommander;

	public Controller(MainCommander mainCommander)
	{
		this.mainCommander = mainCommander;
		mainCommander.SetInterpretator(new FieldCommander());
	}

	// цикл по запросу команды
	internal void StartListner()
	{
		// первый запрос на 25 символов (рисование поля) передается mainCommander в метод Execute
		// смена интерпретатора у mainCommander на RobotCommander
		// остальные запросы передаются туда же (цикл, пока робот не достигнет конечной точки)
		string request = Console.ReadLine();

		while (request.Length != 25)
		{
			Console.WriteLine("Дай мне 25 символов: «1», «2», «3» или «4».");
			request = Console.ReadLine();
		}

		mainCommander.Execute(request.Select(s=>int.Parse(s.ToString())).ToArray());

		mainCommander.SetInterpretator(new RobotCommander());
	}
}
