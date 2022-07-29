using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int NewsId { get; set; }
        [ForeignKey("NewsId")]
        [ValidateNever]
        public News News { get; set; }

    }
}
