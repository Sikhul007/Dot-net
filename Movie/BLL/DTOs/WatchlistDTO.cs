﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class WatchlistDTO
    {
        public int WId { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
    }
}
