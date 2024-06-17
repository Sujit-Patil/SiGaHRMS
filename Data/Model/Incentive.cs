using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SiGaHRMS.Data.Model.Entity;

namespace Siga_Hrms.Data.Model;

public class Incentive: FullAuditedEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IncentiveId { get; set; }

    [Required]
    [MaxLength(50)]
    public IncentivePurpose IncentivePurpose { get; set; }

    public decimal Amount { get; set; }

    public string Description { get; set; }

    [Required]
    public long EmployeeId { get; set; }

    public Employee Employee { get; set; }
}
