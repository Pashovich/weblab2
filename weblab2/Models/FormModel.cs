using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace weblab2.Models
{
    public class FormModel
    {
        public FormModel(int first_ , int second_, string operation_)
        {
            this.first = first_;
            this.second = second_;
            this.operation = operation_;
        }
        public FormModel() {}
        [Required]
        public int first { get; set; }
        [Required]
        public int second { get; set; }
        [Required]
        public string operation { get; set; }
        public int calculationResult { get; set; }
    }
}
