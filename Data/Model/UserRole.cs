﻿using SiGaHRMS.Data.Model.Entity;
using System.ComponentModel.DataAnnotations;

namespace Siga_Hrms.Data.Model;

public class UserRole: FullAuditedEntity
{
    [Key]
    public int UserRoleId { get; set; }

    [Required]
    [MaxLength(50)]
    public string RoleName { get; set; }
}
