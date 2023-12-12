// класс для рисования поля
internal class FieldCommander : ICommander
{
    public FieldCommander()
    {
    }

    public void Execute(int[] value)
    {
        // получение ссылки на Graphics для рисования
        Paint paint = Paint.GetInstance();
        // происходит рисование поля, цифры заносятся
        // в объект Field заносятся цифры (одномерный массив
        // в 25 ячеек преобразовываем в двумерный массив 5х5)
        // в объект Robot заносятся координаты
        
    }
}
