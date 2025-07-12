using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker.Models
{
    /// <summary>
    /// Represents a course with an identifier, name, mark, and credits.
    /// </summary>
    public class Course
    {
        /// <summary>
        /// Gets or sets the unique identifier for the course.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the course.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the mark achieved in the course.
        /// </summary>
        public int Mark { get; set; }

        /// <summary>
        /// Gets the number of credits awarded for the course.
        /// </summary>
        public int Credits { get; }
    }
}
