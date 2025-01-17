﻿using SiGaHRMS.Data.Model.Entity;
using System.ComponentModel.DataAnnotations;

namespace Siga_Hrms.Data.Model;

public class BillingPlatform: FullAuditedEntity
{
    [Key]
    public int BillingPlatformId { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
}
