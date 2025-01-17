﻿using SiGaHRMS.Data.Model.Entity;
using System.ComponentModel.DataAnnotations;

namespace Siga_Hrms.Data.Model;

public class Designation: FullAuditedEntity
{
    [Key]
    public int DesignationId { get; set; }

    [Required]
    [MaxLength(100)]
    public string DesignationName { get; set; }
}
