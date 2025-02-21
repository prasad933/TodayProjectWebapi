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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string ProfileImage { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }


        public ICollection<Course> Course { get; set; }
    }
}

