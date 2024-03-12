using System.ComponentModel.DataAnnotations;

public class Skill
{
    public int Id { get; set; }

    [Required]
    public string Technology { get; set; }

    [Required]
    public int YearsOfExperience { get; set; }

    [Required]
    public int SkillLevel { get; set; }
}



