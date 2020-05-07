namespace MaskON
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Datum
    {
        public int Id { get; set; }

        public int Jumlah { get; set; }
    }
}
