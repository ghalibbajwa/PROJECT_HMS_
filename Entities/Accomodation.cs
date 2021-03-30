﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Accomodation
    {
        public int ID { get; set; }

        public int AccomodationPackageID { get; set; }
        public virtual AccomodationPackage AccomodationPackage { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
