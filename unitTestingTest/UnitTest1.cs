using Microsoft.VisualStudio.TestTools.UnitTesting;
using unitTesting;

namespace unitTestingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FileNameExists()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fromCall;

            //Act
            fromCall = fp.FileExists(@"C:\Users\Anders\Desktop\Nyt Tekstdokument.txt");

            //Assert
            Assert.IsTrue(fromCall);

        }

        [TestMethod]
        public void FileNameDoesNotExist()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fromCall;

            //Act
            fromCall = fp.FileExists(@"C:\Users\Anders\Desktop\bing bong.txt");

            //Assert
            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        public void FileNameNullOrEmptyThrowsArgumentNullException()
        {
            //Arrange
            FileProcess fp = new FileProcess();


            //Act
            try
            {
                fp.FileExists("fil.txt"); //Testing if-statement
            }
            catch (System.ArgumentNullException)
            {
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void FileNameNullOrEmpty_UsingAttribute()
        {
            //Arrange
            FileProcess fp = new FileProcess();

            //Act
            fp.FileExists("");

            //Assert
            
        }
    }
}
