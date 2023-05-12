using NewClassLibrary.Rooms;

namespace NewClassLibrary.Vacuum_Cleaner;

public class ManualVacuum : VacuumClass
{
    public ManualVacuum(double maxVolume, string model) : base(maxVolume, model)
    {
    }

    public override string Model
    {
        get => "Manual Vacuum Toshiba XN-145";
        set => _model = value;
    }

    public override double MaxVolume { get; set; }

    public override string StartCleaning(RoomClass targetRoom)
    {
        return $"{Model}, {base.StartCleaning(targetRoom)}";
    }
}