using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public class Lab
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано название")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не указан адрес")]
        public string Address { get; set; }
    }
}
