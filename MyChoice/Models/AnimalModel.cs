using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyChoice.Models
{
    public class AnimalModel
    {
        public string name { get; set; }
        //critical, endangered, near threatened, vulnerable, least threatened
        public string classification { get; set; } = "critical";
        public double donation { get; set; } = 100.00;
    }
}