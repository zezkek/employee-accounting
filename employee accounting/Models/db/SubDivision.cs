using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace employee_accounting.Models.db;

public partial class SubDivision
{
    [Key]
    public int Id { get; set; }
    [DisplayName("Название подразделения")]
    public string SubDivisionName { get; set; } = null!;
    [DisplayName("Номер главы")]
    public int HeadEmployeeId { get; set; }
    [DisplayName("Состояние записи")]
    public bool State { get; set; }

    public virtual WorkersData HeadEmployee { get; set; } = null!;

    public virtual ICollection<WorkersData> WorkersData { get; } = new List<WorkersData>();
}
