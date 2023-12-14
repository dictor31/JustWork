// класс робота
internal class Robot
{
	private static Robot instance;
	public static Robot GetInstance()
	{
		if (instance == null)
			instance = new Robot(); return instance;
	}
	public int X { get; internal set; }
	public int Y { get; internal set; }  // организовать синглтон и хранение текущих координат
}