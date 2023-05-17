﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("FUND_EXCHANGE_RATE_copy")]
public partial class FundExchangeRateCopy
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CURRENCY")]
    [StringLength(100)]
    [Unicode(false)]
    public string Currency { get; set; }

    [Column("RATE", TypeName = "decimal(18, 6)")]
    public decimal? Rate { get; set; }

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

    /// <summary>
    /// 0
    /// </summary>
    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
