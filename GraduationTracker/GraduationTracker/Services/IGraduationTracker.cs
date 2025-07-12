using System;
using GraduationTracker.Models;

namespace GraduationTracker.Services
{
    /// <summary>
    /// Provides graduation tracking services for students.
    /// </summary>
    public interface IGraduationTracker
    {
        /// <summary>
        /// Determines whether a student has graduated based on the provided diploma requirements.
        /// </summary>
        /// <param name="diploma">The diploma requirements.</param>
        /// <param name="student">The student to evaluate.</param>
        /// <returns>
        /// A tuple containing a boolean indicating graduation status and the student's standing.
        /// </returns>
        Tuple<bool, STANDING> HasGraduated(Diploma diploma, Student student);
    }
}