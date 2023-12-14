// класс для ввода данных
internal class MoveRobotUpCommand : IRobotCommand
{
	public void Execute()
	{// проверяем, может ли робот двигаться вверх, если да, меняем ему координаты
		if (Robot.GetInstance().Y - 1 == 1)
			throw new NotImplementedException();
	}
}