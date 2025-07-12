namespace GraduationTracker.Models
{
    /// <summary>
    /// Represents the academic standing of a student upon graduation.
    /// </summary>
    public enum STANDING
    {
        /// <summary>
        /// No standing assigned.
        /// </summary>
        None,
        /// <summary>
        /// Highest honors.
        /// </summary>
        SumaCumLaude,
        /// <summary>
        /// High honors.
        /// </summary>
        MagnaCumLaude,
        /// <summary>
        /// Average standing.
        /// </summary>
        Average,
        /// <summary>
        /// Requires remedial action.
        /// </summary>
        Remedial
    }

}
