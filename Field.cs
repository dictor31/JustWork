// класс поляusing System.Drawing;
using System.Drawing;

internal class Field
{
	private static Field instance;
	public static Field GetInstance()
	{
		if (instance == null)
			instance = new Field(); return instance;
	}
	// тут организовать синглтон и хранение ячеек в свойстве Cells
	public int[,] Cells { get; set; }


	internal bool CheckRobotEndGame(/*Robot robot, Field field*/)
	{
		if (Cells[Robot.GetInstance().Y, Robot.GetInstance().X] == 4)
			return true;
		return false;
		// сравнение координат робота с координатами
		// финишной точки
	}
}
