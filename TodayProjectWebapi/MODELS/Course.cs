using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodayProjectWebapi.MODELS
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public ICollection<Learner> Learners { get; set; }
    }
}
