using NUnit.Framework;

namespace DateReader.Tests.Controller
{
    class EngineTests : DateReaderTest
    {
        [Test]
        public void RunWithDifferentYearAndMonthArgsTest()
        {
            args = new string[2];
            args[0] = "01.01.2017";
            args[1] = "05.02.2018";
            string expectedResult = "01.01.2017 - 05.02.2018 (400 days)";

            engine.Run(args);

            Assert.AreEqual(expectedResult, engine.result);
        }

        [Test]
        public void RunWithSameYearAndMonthArgsTest()
        {
            args = new string[2];
            args[0] = "01.01.2017";
            args[1] = "05.01.2017";
            string expectedResult = "01 - 05.01.2017 (4 days)";

            engine.Run(args);

            Assert.AreEqual(expectedResult, engine.result);
        }

        [Test]
        public void RunWithSameYearArgsTest()
        {
            args = new string[2];
            args[0] = "01.01.2017";
            args[1] = "05.02.2017";
            string expectedResult = "01.01 - 05.02.2017 (35 days)";

            engine.Run(args);

            Assert.AreEqual(expectedResult, engine.result);
        }

        [Test]
        public void RunWithoutArgsReturnsUsageMessage()
        {
            args = new string[0];
            string expectedResult = ("Usage:  \nDateReader.exe [input date1] [input date2]\n" +
                "date format: dd.mm.yyyy");

            engine.Run(args);

            Assert.AreEqual(expectedResult, engine.result);
        }

        [Test]
        public void RunWitBadArgsReturnsFormatErrorMessage()
        {
            args = new string[2];
            args[0] = "01.00.2017";
            args[1] = "05.02.2017";
            string expectedResult = ("Wrong date format!\n" +
                "Please type in the following sheme:\n" +
                "date format: dd.mm.yyyy");

            engine.Run(args);

            Assert.AreEqual(expectedResult, engine.result);
        }
    }
}
