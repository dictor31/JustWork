// класс поля
internal class Field
{
    // тут организовать синглтон и хранение ячеек в свойстве Cells

    public int[,] Cells { get; set; }

    internal bool CheckRobotEndGame(Robot robot)
    {
        // сравнение координат робота с координатами
        // финишной точки
        return true;
    }
}