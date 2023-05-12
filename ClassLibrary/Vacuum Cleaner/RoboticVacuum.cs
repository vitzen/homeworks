using System.Collections.Generic;
using ClassLibrary.Rooms;

namespace ClassLibrary.Vacuum_Cleaner;

public class RoboticVacuum : VacuumClass<string>
{
    public RoboticVacuum(double maxVolume, string model) : base(maxVolume, model)
    {
    }

    public override string Model
    {
        get => "Robotic Vacuum Xiaomi CZ18";
        set => _model = value;
    }

    public override double MaxVolume { get; set; }

    


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public override string StartCleaning(RoomClass targetRoom)
    {
        return $"{Model}, {base.StartCleaning(targetRoom)}";
    }
}