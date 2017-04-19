﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdWorker
{
    public class ExpenditureReason
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public List<CellConsumption> CellConsumptions { get; set; }
    }
}
