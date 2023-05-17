﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("VC_JNANA_FCM")]
public partial class VcJnanaFcm
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("TOKEN")]
    [StringLength(250)]
    public string Token { get; set; }

    [Column("USER_ID")]
    public int UserId { get; set; }
}
