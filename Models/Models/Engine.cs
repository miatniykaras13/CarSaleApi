using Models.Enum;

namespace Models.Models;

public class Engine
{
    public double Volume { get; set; }
    public EngineEnum Type { get; set; }
    public double Consumption { get; set; }
}