using System.Security.Cryptography;

namespace Core.Random;

public class Dice
{
    public static Dice Instance { get; set; } = new Dice();

    private Dice() { }

    public int RollK4() => RandomNumberGenerator.GetInt32(3) + 1;
    public int RollK6() => RandomNumberGenerator.GetInt32(5) + 1;
    public int RollK8() => RandomNumberGenerator.GetInt32(7) + 1;
    public int RollK10() => RandomNumberGenerator.GetInt32(9) + 1;
    public int RollK12() => RandomNumberGenerator.GetInt32(11) + 1;
    public int RollK20() => RandomNumberGenerator.GetInt32(19) + 1;
    public int RollK100() => RandomNumberGenerator.GetInt32(99) + 1;
}
