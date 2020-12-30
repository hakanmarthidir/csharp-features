using System;
namespace Features_9
{

    public record FirstRecord(string Name);


    public record Project
    {
        public string ProjectName { get; set; }
        public byte ProjectMemberCount { get; set; }
        public int ProjectDuration { get; set; }

        public Project(string name, byte member, int month) => (ProjectName, ProjectMemberCount, ProjectDuration) = (name, member, month);

        public void Start() => Console.WriteLine($"Project started...{DateTime.UtcNow}");

    }

    //Inheritance is possible in record types
    public record SoftwareProject : Project
    {
        public string Language { get; set; }

        public SoftwareProject(string name, byte member, int month, string language) : base(name, member, month) => Language = language;

        public void Deconstruct(out string name, out byte member) => (name, member) = (ProjectName, ProjectMemberCount);

    }

    //In Addition you can use sealed keyword.
    //Another feature you can create this record without constructor
    public sealed record MachineProject(string Name, byte MemberCount, int Duration) : Project(Name, MemberCount, Duration);


}
