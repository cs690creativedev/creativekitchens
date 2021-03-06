﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ck_project.Models
{
    public class CLSA16
    {
        public string Responsible_Party_Or_Lead_Creator { get; set; }
        public string Designer { get; set; }
        public string Project_Type { get; set; }
        public string Project_Class { get; set; }
        public string Delivery_Status { get; set; }
        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public double Project_Total { get; set; }
        public string Primary_Phone { get; set; }
        public string Primary_Email { get; set; }
    }
}