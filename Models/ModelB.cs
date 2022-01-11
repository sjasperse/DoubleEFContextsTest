using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoubleEFContextsTest.Models
{
    public class ModelB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ModelBId { get; set; }
    }
}