using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodayProjectWebapi.MODELS
{
    [Table("Learner")]
    public class Learner
    {
        [Key]
        public int LearnerId { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Enter lessthan 50 char")]
        public string FirstName { get; set; }

       
        [Required]
        [StringLength(15, ErrorMessage = "Enter lessthan 50 char")]
        public string LastName { get; set; }

        
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Enter a valid 10-digit mobile number")]
        public string Mobile { get; set; }


        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Enter a valid email format")]
        public string Email { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        [RegularExpression(@"^(Male|Female|Other)$", ErrorMessage = "Gender must be Male, Female, or Other")]
        public string Gender { get; set; }
        
        [Required]
        public string ProfileImage { get; set; }


        [Required]
        [ForeignKey("Course")]
        public int CourseId { get; set; }


        public ICollection<Course> Course { get; set; }
    }
}

