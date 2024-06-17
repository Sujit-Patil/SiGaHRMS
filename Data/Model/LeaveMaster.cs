using SiGaHRMS.Data.Model.Entity;
using System.ComponentModel.DataAnnotations;

namespace Siga_Hrms.Data.Model;

public class LeaveMaster: FullAuditedEntity
{
    [Key]        
    public int LeaveMasterId { get; set; }

    [Required]
    [MaxLength(50)]
    public string LeaveType { get; set; }

    [Required]
    public int LeaveCount { get; set; }
}
