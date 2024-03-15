using System.Numerics;

namespace ChaosDevelopmentTests;

public class RobotTest
{
    Robot robot;

    [SetUp]
    public void Setup()
    {
        robot = new Robot();
    }

    [Test]
    public void Robot_ShouldExist()
    {
        Assert.That(robot, Is.Not.Null);
    }

    [Test]
    public void DefaultDirection_ShouldBeNorth()
    {
        Assert.That(robot.Direction, Is.EqualTo(Directions.NORTH));
    }

    [Test]
    public void DefaultPosition_ShouldBe00()
    {
        Assert.That(robot.Position, Is.EqualTo(new Vector2(0,0)));
    }
    
    [Test]
    public void DoCommanDF_ShouldMoveForwardBy1Step()
    {
        robot.DoCommand(Commands.DF);
        
        Assert.That(robot.Position, Is.EqualTo(new Vector2(0,1)));
    }

}