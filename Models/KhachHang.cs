﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace qlks.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public String MaKH { get; set; }
        [AllowHtml]
        public String HoTenKH { get; set; }
        public String SoDT { get; set; }



    }
}