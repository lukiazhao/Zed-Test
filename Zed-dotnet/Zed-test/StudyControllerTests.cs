using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zeddotnet.Services;
using Moq;
using Zeddotnet.Interfaces;
using Zeddotnet.Models;
using Zeddotnet.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace Zed_test
{
    [TestClass]
    public class StudyControllerTests
    {
        static Dictionary<string, Study> studiesTest;
        static Study study1;

        [ClassInitialize]
        public static void TestFixtureSetup(TestContext context)
        {
            study1 = new Study
            {
                GUID = "study_guid_1",
                StudyId = "study1",

            };
            Study study2 = new Study
            {
                GUID = "study_guid_2",
                StudyId = "study2",
            };

            studiesTest = new Dictionary<string, Study>
            {
                { study1.GUID, study1 },
                { study2.GUID, study2 }
            };

        }

        [TestMethod]
        public void Get_ReturnsStudyByID()
        {
            // Arrange
            var mock = new Mock<IStudyManager>();
            mock.Setup(p => p.GetStudyByGUID("abc")).Returns(study1);
            StudyController studyController = new StudyController(mock.Object);

            // Act
            var result = studyController.Get("abc");

            // Assert
            Assert.AreEqual("study1", result.Value.StudyId);
        }

        [TestMethod]
        public void Get_ReturnsAllStudies()
        {
            // Arrange
            var mock = new Mock<IStudyManager>();
            mock.Setup(p => p.GetAll()).Returns(studiesTest);
            StudyController studyController = new StudyController(mock.Object);

            // Act
            var result = studyController.Get();

            // Assert
            Assert.AreEqual(2, result.Value.Count());
        }
    }
}
