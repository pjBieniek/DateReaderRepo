using NUnit.Framework;

namespace DateReader.Tests.Viewer
{
    class ViewTests : DateReaderTest
    {
        [Test]
        public void UssageMessageIsCorrect()
        {
            string correctMessage = "Usage:  \nDateReader.exe [input date1] [input date2]\n" +
                "date format: dd.mm.yyyy";

            string viewerMessage = view.UsageMessage();

            Assert.AreEqual(correctMessage, viewerMessage);
        }

        [Test]
        public void ErrorMessageIsCorrect()
        {
            string correctMessage = "Wrong date format!\n" +
                "Please type in the following sheme:\n" +
                "date format: dd.mm.yyyy";

            string viewerMessage = view.FormatErrorMessage();

            Assert.AreEqual(correctMessage, viewerMessage);
        }
    }
}
