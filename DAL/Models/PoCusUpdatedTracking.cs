﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("PO_CUS_UPDATED_TRACKING")]
public partial class PoCusUpdatedTracking
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PO_CUS_CODE")]
    [StringLength(255)]
    public string PoCusCode { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("CONFIRM")]
    [StringLength(255)]
    public string Confirm { get; set; }

    [Column("CONFIRM_TIME")]
    public DateTime? ConfirmTime { get; set; }

    [Column("UPDATE_CONTENT")]
    public string UpdateContent { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("APPROVED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string ApprovedBy { get; set; }

    [Column("APPROVED_TIME")]
    public DateTime? ApprovedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }
}
