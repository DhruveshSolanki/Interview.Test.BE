using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using GraduationTracker.Services;
using GraduationTracker.Repository;
using GraduationTracker.Models;

/// <summary>
/// Unit tests for GraduationTracker functionality.
/// </summary>
namespace GraduationTracker.Tests.Unit
{
    [TestClass]
    public class GraduationTrackerTests
    {
        private IGraduationTracker _service;
        private IRepository _repository;

        /// <summary>
        /// Initializes repository and service before each test.
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            _repository = new StudentRepository();
            _service = new GraduationTracker(_repository);
        }

        /// <summary>
        /// Tests HasGraduated method for different students and validates their graduation status and standing.
        /// </summary>
        [TestMethod]
        public void TestHasCredits()
        {
            var diploma = _repository.GetDiploma(1);

            var students = _repository.GetAllStudents();

            foreach (var student in students)
            {
                var (graduated, standing) = _service.HasGraduated(diploma, student);
                switch (student.Id)
                {
                    case 1:
                        Assert.IsTrue(graduated);
                        Assert.AreEqual(STANDING.SumaCumLaude, standing);
                        break;
                    case 2:
                        Assert.IsTrue(graduated);
                        Assert.AreEqual(STANDING.MagnaCumLaude, standing);
                        break;
                    case 3:
                        Assert.IsTrue(graduated);
                        Assert.AreEqual(STANDING.Average, standing);
                        break;
                    case 4:
                        Assert.IsFalse(graduated);
                        Assert.AreEqual(STANDING.Remedial, standing);
                        break;
                }
            }

        }
    }
}
