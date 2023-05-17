﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("ASSET_ATTRIBUTE")]
public partial class AssetAttribute
{
    [Key]
    [Column("ATTR_ID")]
    public int AttrId { get; set; }

    [Column("ATTR_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string AttrCode { get; set; }

    [Column("ATTR_VALUE")]
    [StringLength(255)]
    public string AttrValue { get; set; }

    [Column("ATTR_GROUP")]
    [StringLength(255)]
    public string AttrGroup { get; set; }

    [Column("ASSET_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string AssetCode { get; set; }

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
    public bool? IsDeleted { get; set; }

    [Column("ATTR_NOTE")]
    [StringLength(255)]
    [Unicode(false)]
    public string AttrNote { get; set; }

    [Column("ATTR_UNIT")]
    [StringLength(50)]
    [Unicode(false)]
    public string AttrUnit { get; set; }

    [Column("ATTR_NAME")]
    [StringLength(255)]
    public string AttrName { get; set; }
}
