// класс для ввода данных
internal class RobotCommander : ICommander
{
	Queue<IRobotCommand> robotCommands = new Queue<IRobotCommand>();

	public RobotCommander()
	{
		robotCommands.Enqueue(new DrawRobotCommand());
		Thread thread = new Thread(RunCommand);
		thread.Start();
	}

	public void Execute(int[] value)
	{
		// массив value перебирается сначала до конца
		// на каждую цифру создается соответствующая команда
		// и передается в очередь выполнения команд
		// здесь какой-нибудь switch, который по номеру создается команду
		// можно чередовать команды движения и рисования
		for (int i = 0; i < value.Length; i++) 
		{
			switch (value[i]) 
			{
				case 1: new MoveRobotUpCommand();
					break;
				case 2: new MoveRobotDownCommand();
					break;
				case 3: new MoveRobotLeftCommand();
					break;
				case 4: new MoveRobotRightCommand();
					break;
			}
		}
	}

	void RunCommand(object obj)
	{
		while (!Field.GetInstance().CheckRobotEndGame())
		{
			Thread.Sleep(1000);
			if (robotCommands.Count > 0)
			{
				var command = robotCommands.Dequeue();
				command.Execute();
			}
		}
	}
}

