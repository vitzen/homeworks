using ClassLibrary.Rooms;

namespace ClassLibrary.Vacuum_Cleaner;

public class VacuumClass
{
    private string _model;

    public VacuumClass(string model)
    {
        _model = model;
    }

    public virtual string Model
    {
        get => _model;
    }

    public virtual void StartCleaning()
    {
        Console.WriteLine("Началась уборка");
    }

    public virtual string StartCleaning(RoomClass targetRoom)
    {
        return $"Началась уборка в комнате: {targetRoom}";
    }
}