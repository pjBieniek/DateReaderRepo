using System;

namespace DateReader.Viewer
{
    public class View
    {
        public string FormatErrorMessage()
        {
            return ("Wrong date format!\n" +
                "Please type in the following sheme:\n" +
                "date format: dd.mm.yyyy"
                );
        }

        public string UsageMessage()
        {
            return ("Usage:  \nDateReader.exe [input date1] [input date2]\n" +
                "date format: dd.mm.yyyy");
        }

        public void PrintLn(string content)
        {
            Console.WriteLine(content);
        }
    }
}
