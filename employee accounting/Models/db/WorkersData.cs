using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employee_accounting.Models.db;

public class WorkersData
{
    [Key]
    public int Id { get; set; }
    [Key]
    public int IdSubDivision { get; set; }
    [DisplayName("Имя")]
    public string Name { get; set; } = null!;
    [DisplayName("Табельный номер")]
    public int EmployeeNumber { get; set; }
    [DisplayName("Должность")]
    public string JobTitle { get; set; } = null!;
    [EmailAddress]
    [DisplayName("Почта")]
    public string Email { get; set; } = null!;
    [Phone]
    [DisplayName("Номер телефона")]
    public string PhoneNumber { get; set; } = null!;
    [DisplayName("Дата приёма")]
    public DateTime EmploymentDate { get; set; }
    [DisplayName("Дата увольнения")]
    public DateTime? DismissalDate { get; set; }
    [DisplayName("Состояние записи")]
    public bool State { get; set; }

    public virtual SubDivision IdSubDivisionNavigation { get; set; } = null!;

    public virtual ICollection<SubDivision> SubDivisions { get; } = new List<SubDivision>();
}
