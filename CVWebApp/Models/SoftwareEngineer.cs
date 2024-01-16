// Models/SoftwareEngineer.cs
namespace Models.SoftwareEngineer;
public class SoftwareEngineer
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string[] Skills { get; set; }
    public WorkExperience WorkExperience { get; set; }
}

public class WorkExperience
{
    public string Company { get; set; }
    public string Position { get; set; }
    public string Duration { get; set; }
    public string Responsibilities { get; set; }
}
