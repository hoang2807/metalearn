﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("ASSET_ENTITY_MAPPING")]
public partial class AssetEntityMapping
{
    [Key]
    public int Id { get; set; }

    [Column("WHS_CODE")]
    [StringLength(255)]
    public string WhsCode { get; set; }

    [Column("FLOOR_CODE")]
    [StringLength(255)]
    public string FloorCode { get; set; }

    [Column("LINE_CODE")]
    [StringLength(255)]
    public string LineCode { get; set; }

    [Column("RACK_CODE")]
    [StringLength(255)]
    public string RackCode { get; set; }

    [Column("RACK_POSITION")]
    [StringLength(255)]
    public string RackPosition { get; set; }

    [Column("ORDERING")]
    [StringLength(255)]
    public string Ordering { get; set; }

    [Column("PRODUCT_QR_CODE")]
    [StringLength(255)]
    public string ProductQrCode { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("QUANTITY", TypeName = "decimal(18, 2)")]
    public decimal? Quantity { get; set; }

    [Column("UNIT")]
    [StringLength(50)]
    public string Unit { get; set; }

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

    [Column("ASSET_CODE")]
    [StringLength(255)]
    public string AssetCode { get; set; }
}
