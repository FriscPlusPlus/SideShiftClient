﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SideShiftClient
{
    public class ShiftsQuery
    {
        [DataMember(Name = "ids")]
        public string Ids { get; set; }
    }
}
