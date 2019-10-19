using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class ToDoItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual DateTimeOffset? CreationDate { get; set; }
        public bool IsComplete { get; set; }
    }
    
}