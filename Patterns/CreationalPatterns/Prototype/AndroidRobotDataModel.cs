namespace Patterns.CreationalPatterns.Prototype
{
    public class AndroidRobotDataModel(int id, string name, string model, string os, string cpu, string gpu)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Model { get; set; } = model;
        public string Os { get; set; } = os;
        public string Cpu { get; set; } = cpu;
        public string Gpu { get; set; } = gpu;
    }
}   