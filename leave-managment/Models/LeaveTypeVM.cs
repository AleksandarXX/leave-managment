using System.ComponentModel.DataAnnotations;
using System;

namespace leave_managment.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name ="Date Created")]
        public DateTime? DateCreated { get; set; }
    }
}
