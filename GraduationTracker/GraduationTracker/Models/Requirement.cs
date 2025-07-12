namespace GraduationTracker.Models
{
    /// <summary>
    /// Represents a graduation requirement, including its identifier, name, minimum mark, credits, and associated courses.
    /// </summary>
    public class Requirement
    {
        /// <summary>
        /// Gets or sets the unique identifier for the requirement.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the requirement.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the minimum mark required to fulfill the requirement.
        /// </summary>
        public int MinimumMark { get; set; }

        /// <summary>
        /// Gets or sets the number of credits awarded for completing the requirement.
        /// </summary>
        public int Credits { get; set; }

        /// <summary>
        /// Gets or sets the array of course identifiers associated with the requirement.
        /// </summary>
        public int[] Courses { get; set; }
    }
}
