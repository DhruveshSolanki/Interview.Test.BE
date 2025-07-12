using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker.Models
{
    /// <summary>
    /// Represents a student with an ID, enrolled courses, and academic standing.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Gets or sets the unique identifier for the student.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the array of courses the student is enrolled in.
        /// </summary>
        public Course[] Courses { get; set; }

        /// <summary>
        /// Gets or sets the academic standing of the student.
        /// </summary>
        public STANDING Standing { get; set; } = STANDING.None;
    }
}
