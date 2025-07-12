using System.Collections.Generic;
using GraduationTracker.Models;

namespace GraduationTracker.Repository
{
    /// <summary>
    /// Defines methods for accessing student, diploma, and requirement data.
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Retrieves a student by their unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the student.</param>
        /// <returns>The <see cref="Student"/> object corresponding to the specified id.</returns>
        Student GetStudent(int id);

        /// <summary>
        /// Retrieves all students.
        /// </summary>
        /// <returns>A list of all <see cref="Student"/> objects.</returns>
        List<Student> GetAllStudents();

        /// <summary>
        /// Retrieves a diploma by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the diploma.</param>
        /// <returns>The <see cref="Diploma"/> object corresponding to the specified id.</returns>
        Diploma GetDiploma(int id);

        /// <summary>
        /// Retrieves a requirement by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the requirement.</param>
        /// <returns>The <see cref="Requirement"/> object corresponding to the specified id.</returns>
        Requirement GetRequirement(int id);
    }
}