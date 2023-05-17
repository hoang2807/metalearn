﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CONTRACT_MEMBER_TASK")]
public partial class ContractMemberTask
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ASSIGNER")]
    public string Assigner { get; set; }

    [Column("ASSIGNER_TIME")]
    public DateTime? AssignerTime { get; set; }

    [Column("ASSIGNEE")]
    [StringLength(255)]
    public string Assignee { get; set; }

    [Column("CONFIRM_TIME")]
    public DateTime? ConfirmTime { get; set; }

    [Column("CONTRACT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ContractCode { get; set; }

    [Column("TASK_CODE")]
    [StringLength(100)]
    public string TaskCode { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

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
