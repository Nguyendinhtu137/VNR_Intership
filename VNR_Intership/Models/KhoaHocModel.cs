using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VNR_Intership.EFData;

namespace VNR_Intership.Models
{
    public class KhoaHocModel
    {
        public string Tenkhoahoc { get; set; }
        public List<KhoaHoc> KhoaHocs { get; set; }
        public List<MonHoc> MonHocs { get; set; }
    }
}