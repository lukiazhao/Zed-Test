using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zeddotnet.Services;
using Moq;
using Zeddotnet.Interfaces;
using Zeddotnet.Models;
using System.Collections.Generic;
using System.Linq;

namespace Zed_test
{
    [TestClass]
    public class StudyManagerTests
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
        public void GetAll_ReturnsAllStudies()
        {
            // Arrange
            var mock = new Mock<IFileLoader>();
            mock.Setup(p => p.LoadStudies("./Files")).Returns(studiesTest);
            StudyManager studyManager = new StudyManager(mock.Object);

            // Act
            var result = studyManager.GetAll();

            // Assert
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void GetStudyByGUID_ReturnsStudy()
        {
            // Arrange
            var mock = new Mock<IFileLoader>();
            mock.Setup(p => p.LoadStudies("./Files")).Returns(studiesTest);
            StudyManager studyManager = new StudyManager(mock.Object);

            // Act
            var result = studyManager.GetStudyByGUID("study_guid_1");

            // Assert
            Assert.AreEqual(study1, result);
        }
    }
}
