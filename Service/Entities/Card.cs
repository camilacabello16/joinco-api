﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Entities
{
    public class Card : BaseEntity
    {
        public string? Name { get; set; }
        public string? BoardId { get; set; }
    }
}
