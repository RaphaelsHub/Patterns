namespace Patterns.CreationalPatterns.Prototype;

public class AndroidRobot : IPrototype<AndroidRobot>
{
    public AndroidRobotDataModel Data { get; set; }
    
    public AndroidRobot Clone()
    {
        var newRobot = new AndroidRobot();
        return newRobot;
    }   
    
    public override string ToString() => $"Id: {Data.Id}, Name: {Data.Name}, Model: {Data.Model}, OS: {Data.Os}, CPU: {Data.Cpu}, GPU: {Data.Gpu}";
}