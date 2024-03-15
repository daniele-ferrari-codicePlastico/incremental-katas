using System.Numerics;

public class Robot
{
    public Directions Direction { get; set; }
    public Vector2 Position { get; set; }

    public void DoCommand(Command command)
    {
        throw new NotImplementedException();
    }
}

public class Command
{
}
