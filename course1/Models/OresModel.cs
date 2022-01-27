using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace course1.Models
{
    public class OresModel
    {
        [DisplayName("Id Number")]
        public int ID { get; set; }
        [DisplayName("Ore Name")]
        public string Name { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Price Per tonne")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DisplayName("Last Ordered")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
    }
}
