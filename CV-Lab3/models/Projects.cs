using System;
using System.ComponentModel.DataAnnotations;

public class Project
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Project name is required")]
    public string ProjectName { get; set; }

    [Required(ErrorMessage = "Description is required")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Start date is required")]
    public DateTime StartDate { get; set; }

    [Required(ErrorMessage = "End date is required")]
    public DateTime EndDate { get; set; }

 
}


