using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationTracker.Models;
using GraduationTracker.Repository;

namespace GraduationTracker.Repository
{
    /// <summary>
    /// Repository for managing students, diplomas, and requirements.
    /// </summary>
    public class StudentRepository : IRepository
    {
        private readonly List<Student> _students;
        private readonly List<Diploma> _diplomas;
        private readonly List<Requirement> _requirements;

        /// <summary>
        /// Initializes the repository with sample data for students, diplomas, and requirements.
        /// </summary>
        public StudentRepository()
        {
            _students = [
               new() {
                   Id = 1,
                   Courses =
                   [
                        new() {Id = 1, Name = "Math", Mark=95 },
                        new() {Id = 2, Name = "Science", Mark=95 },
                        new() {Id = 3, Name = "Literature", Mark=95 },
                        new() {Id = 4, Name = "Physichal Education", Mark=95 }
                   ]
               },
               new() {
                   Id = 2,
                   Courses =
                   [
                        new() {Id = 1, Name = "Math", Mark=80 },
                        new() {Id = 2, Name = "Science", Mark=80 },
                        new() {Id = 3, Name = "Literature", Mark=80 },
                        new() {Id = 4, Name = "Physichal Education", Mark=80 }
                   ]
               },
            new() {
                Id = 3,
                Courses =
                [
                    new() {Id = 1, Name = "Math", Mark=50 },
                    new() {Id = 2, Name = "Science", Mark=50 },
                    new() {Id = 3, Name = "Literature", Mark=50 },
                    new() {Id = 4, Name = "Physichal Education", Mark=50 }
                ]
            },
            new() {
                Id = 4,
                Courses =
                [
                    new() {Id = 1, Name = "Math", Mark=40 },
                    new() {Id = 2, Name = "Science", Mark=40 },
                    new() {Id = 3, Name = "Literature", Mark=40 },
                    new() {Id = 4, Name = "Physichal Education", Mark=40 }
                ]
            }

            ];

            _diplomas = [
                new()
                {
                    Id = 1,
                    Credits = 4,
                    Requirements = [100,102,103,104]
                }
            ];

            _requirements = [
                new(){Id = 100, Name = "Math", MinimumMark=50, Courses = [1], Credits=1},
                new Requirement{Id = 102, Name = "Science", MinimumMark=50, Courses = [2], Credits=1 },
                new Requirement{Id = 103, Name = "Literature", MinimumMark=50, Courses = [3], Credits=1},
                new Requirement{Id = 104, Name = "Physichal Education", MinimumMark=50, Courses = [4], Credits=1 }
            ];
        }

        /// <summary>
        /// Gets a student by their ID.
        /// </summary>
        /// <param name="id">Student ID.</param>
        /// <returns>The student with the specified ID, or null if not found.</returns>
        public Student GetStudent(int id) => _students.FirstOrDefault(s => s.Id == id);

        /// <summary>
        /// Gets all students.
        /// </summary>
        /// <returns>List of all students.</returns>
        public List<Student> GetAllStudents() => _students;

        /// <summary>
        /// Gets a diploma by its ID.
        /// </summary>
        /// <param name="id">Diploma ID.</param>
        /// <returns>The diploma with the specified ID, or null if not found.</returns>
        public Diploma GetDiploma(int id) => _diplomas.FirstOrDefault(d => d.Id == id);

        /// <summary>
        /// Gets a requirement by its ID.
        /// </summary>
        /// <param name="id">Requirement ID.</param>
        /// <returns>The requirement with the specified ID, or null if not found.</returns>
        public Requirement GetRequirement(int id) => _requirements.FirstOrDefault(r => r.Id == id);
    }
}
