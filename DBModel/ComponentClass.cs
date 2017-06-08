﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModel
{
    public class ComponentClass
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public Guid ComponentClassId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ComponentClass> ComponentClasses { get; set; }

    }
}
