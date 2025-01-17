﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SiGaHRMS.Data.Model.Enum;
using SiGaHRMS.Data.Model.Entity;

namespace Siga_Hrms.Data.Model;

public class LeaveRequest: FullAuditedEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long LeaveRequestId { get; set; }

    public LeaveType LeaveType { get; set; }

    [Required]
    public DateTime FromDate { get; set; }

    [Required]
    public DateTime ToDate { get; set; }

    public bool? IsHalfDay { get; set; }

    [Required]
    [MaxLength(2000)]
    public string Reason { get; set; }

    [MaxLength(20)]
    public LeaveRequestStatus LeaveRequestStatus { get; set; }

    [MaxLength(2000)]
    public string ApproverComment { get; set; }

    public long? Approver { get; set; }

    [Required]
    public long EmployeeId { get; set; }

    public Employee Employee { get; set; }
}
