using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationTracker.Models;
using GraduationTracker.Repository;
using GraduationTracker.Services;

namespace GraduationTracker
{
    /// <summary>
    /// Provides functionality to determine if a student has graduated based on diploma requirements and course marks.
    /// </summary>
    public partial class GraduationTracker(IRepository repository) : IGraduationTracker
    {
        private readonly IRepository _repository = repository;

        /// <summary>
        /// Determines if the specified student has graduated according to the given diploma requirements.
        /// </summary>
        /// <param name="diploma">The diploma containing graduation requirements.</param>
        /// <param name="student">The student whose graduation status is to be checked.</param>
        /// <returns>
        /// A tuple containing a boolean indicating graduation status and the student's academic standing.
        /// </returns>
        public Tuple<bool, STANDING> HasGraduated(Diploma diploma, Student student)
        {
            var requirements = diploma.Requirements.Select(_repository.GetRequirement).ToList();
            var credits = 0;
            var average = 0;

            foreach (Requirement requirement in requirements)
            {
                var course = student.Courses.FirstOrDefault(c => requirement.Courses.Contains(c.Id));
                average += course.Mark;
                if (course != null && course.Mark > requirement.MinimumMark)
                {
                    credits += requirement.Credits;
                }
            }

            average /= student.Courses.Length;

            var standing = GetStanding(average);

            return standing switch
            {
                STANDING.Remedial => new Tuple<bool, STANDING>(false, standing),
                STANDING.Average => new Tuple<bool, STANDING>(true, standing),
                STANDING.SumaCumLaude => new Tuple<bool, STANDING>(true, standing),
                STANDING.MagnaCumLaude => new Tuple<bool, STANDING>(true, standing),
                _ => new Tuple<bool, STANDING>(false, standing),
            };
        }

        /// <summary>
        /// Determines the academic standing based on the average mark.
        /// </summary>
        /// <param name="average">The average mark of the student.</param>
        /// <returns>The academic standing.</returns>
        private static STANDING GetStanding(int average)
        {
            return average switch
            {
                < 50 => STANDING.Remedial,
                < 80 => STANDING.Average,
                < 95 => STANDING.MagnaCumLaude,
                _ => STANDING.SumaCumLaude,
            };
        }
    }
}
