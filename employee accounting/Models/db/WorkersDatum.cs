using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace employee_accounting.Models.db;

public partial class WorkersDatum
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int EmployeeNumber { get; set; }

    public string JobTitle { get; set; } = null!;

    public string SubDivision { get; set; } = null!;
    [EmailAddress]
    public string Email { get; set; } = null!;
    [Phone]
    public string PhoneNumber { get; set; } = null!;

    public DateTime EmploymentDate { get; set; }

    public DateTime? DismissalDate { get; set; }
}
