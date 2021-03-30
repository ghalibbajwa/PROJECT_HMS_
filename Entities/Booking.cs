﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Booking
    {
        public int ID { get; set; }

        public int AccomodationID { get; set; }
        public Accomodation Accomodation { get; set; }

        public DateTime FromDate { get; set; }

        /// <summary>
        /// No Of Stay Nights
        /// </summary>
        public int Duration { get; set; }
    }
}
