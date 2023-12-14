
// фасад для исполнителей команд
internal class MainCommander : ICommander
{
    ICommander commander;
    internal void SetInterpretator(ICommander commander)   
    {
        this.commander = commander;
    }

    public void Execute(int[] value)
    {
        commander.Execute(value);
    }
}