﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("VC_WORK_PLAN_LOG")]
public partial class VcWorkPlanLog
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("WPCODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string Wpcode { get; set; }

    [Column("CURRENTTIME")]
    public DateTime? Currenttime { get; set; }

    [Column("CURRENTSTATUS")]
    [StringLength(50)]
    public string Currentstatus { get; set; }

    [Column("PERCENT")]
    public float? Percent { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
