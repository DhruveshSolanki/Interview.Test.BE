using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker.Models
{
    /// <summary>
    /// Represents a diploma program offered by the institution.
    /// Contains the diploma's unique identifier, the total credits required,
    /// and the list of requirement IDs that must be fulfilled to graduate.
    /// </summary>
    public class Diploma
    {
        /// <summary>
        /// The unique identifier for the diploma.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The total number of credits required to obtain the diploma.
        /// </summary>
        public int Credits { get; set; }

        /// <summary>
        /// The array of requirement IDs associated with the diploma.
        /// Each requirement must be fulfilled for graduation.
        /// </summary>
        public int[] Requirements { get; set; }
    }
}