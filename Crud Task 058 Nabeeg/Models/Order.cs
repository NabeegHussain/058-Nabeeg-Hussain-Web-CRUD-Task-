using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Crud_Task_058_Nabeeg.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

    }
}
