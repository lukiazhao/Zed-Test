using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zeddotnet.Services;

namespace Zed_test
{
    [TestClass]
    public class FileLoaderTests
    {
        [TestMethod]
        public void LoadStudies_ReturnsStudyDictionaryFromFiles()
        {
            // Arrange
            var filesRoot = "../../../FilesTest";
            FileLoader fileLoader = new FileLoader();

            // Act
            var result = fileLoader.LoadStudies(filesRoot);

            // Assert
            Assert.AreEqual(1, result.Count());
        }

        [TestMethod]
        [ExpectedException(typeof(System.IO.DirectoryNotFoundException))]
        public void LoadStudies_DirectoryNotFoundException()
        {
            // Arrange
            var filesRoot = "../../../wrongFolder";
            FileLoader fileLoader = new FileLoader();

            // Act
            var result = fileLoader.LoadStudies(filesRoot);
        }
    }
}
