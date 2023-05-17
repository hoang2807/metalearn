﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("RECORDS_PACK_ATTR")]
public partial class RecordsPackAttr
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ZONE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Zone { get; set; }

    [Column("PACK_ATTR_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string PackAttrCode { get; set; }

    [Column("PACK_ATTR_NAME")]
    [StringLength(255)]
    public string PackAttrName { get; set; }

    [Column("PACK_ATTR_VALUE")]
    [StringLength(255)]
    public string PackAttrValue { get; set; }

    [Column("PACK_ATTR_UNIT")]
    [StringLength(255)]
    [Unicode(false)]
    public string PackAttrUnit { get; set; }

    [Column("PACK_ATTR_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string PackAttrType { get; set; }

    [Column("PACK_ATTR_SIZE")]
    [StringLength(255)]
    [Unicode(false)]
    public string PackAttrSize { get; set; }

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

    [Column("PACK_ATTR_DATA_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string PackAttrDataType { get; set; }

    [Column("PACK_ATTR_GROUP")]
    [StringLength(255)]
    [Unicode(false)]
    public string PackAttrGroup { get; set; }
}
