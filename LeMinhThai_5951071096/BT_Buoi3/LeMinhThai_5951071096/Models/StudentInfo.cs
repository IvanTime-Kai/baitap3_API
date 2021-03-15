using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace LeMinhThai_5951071096.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "Ten")]
        public string tenSV { get; set; }
        [DataMember(Name = "Lop")]
        public string lopSV { get; set; }
        [DataMember(Name = "MSSV")]
        public string maSV { get; set; }
    }
}