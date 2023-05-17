﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET_INVENTORY_DETAIL")]
public partial class AssetInventoryDetail
{
    [Column("TICKET_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string TicketCode { get; set; }

    [Column("ASSET_NAME")]
    [StringLength(255)]
    public string AssetName { get; set; }

    [Column("STATUS_ASSET")]
    [StringLength(255)]
    public string StatusAsset { get; set; }

    [Column("QUANTITY")]
    public int? Quantity { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Key]
    [Column("ASSET_ID")]
    public int AssetId { get; set; }
}
