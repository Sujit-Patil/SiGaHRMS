﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SiGaHRMS.Data.Model.Enum;
using SiGaHRMS.Data.Model.Entity;

namespace Siga_Hrms.Data.Model;

public class Employee: FullAuditedEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long EmployeeId { get; set; }

    [MaxLength(20)]
    public EmployeeStatus EmployeeStatus { get; set; }

    [Required]
    [ForeignKey("UserId")]
    public long UserId { get; set; }

    public User User { get; set; }

    [ForeignKey("TeamLead")]
    public long? TeamLeadId { get; set; } 

    public Employee TeamLead { get; set; }

    [ForeignKey("ReportingManagerId")]
    public long? ReportingManagerId { get; set; }

    public Employee ReportingManager { get; set; }
}

