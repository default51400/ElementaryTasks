using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4FileParser;

namespace ElementaryTasks.tests.FileParser
{
    [TestClass]
    public class FileParserTests
    {
        [TestMethod]
        //[DataRow("text.txt", "ONENUMBER", 0)]
        public void GetCountEntries()
        {
            // Arrange
            string path = "text.txt";
            string find = "ONENUMBER";
            int count = 0;
            Parser parser = new Parser(path);


            // Act
            int real = parser.GetCountEntries(find);

            // Assert
            Assert.AreEqual(real, count);
        }
    }
}
