﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.Entity
{
    [Table(PrimaryColumn ="islemno",TableName = "Islem")]
    public class Islem : Table
    {
        public int islemno { get; set; }
        public int ogrno { get; set; }
        public int kitapno { get; set; }
        public DateTime atarih { get; set; }
        public DateTime vtarih { get; set; }

    }
}
