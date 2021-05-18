using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NLayerProject.Core.Models
{
    public class BaseModel
    {
        [StringLength(20)]
        public string KayitBy { get; set; }

        [Column(TypeName ="datetime")]
        public DateTime KayitDate { get; set; }

        [StringLength(20)]
        public string DegisBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DegisDate { get; set; }

        [DefaultValue(false)]
        public bool Silindi { get; set; }
    }
}
