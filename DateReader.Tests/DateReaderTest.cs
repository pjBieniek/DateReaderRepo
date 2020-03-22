using DateReader.Controller;
using DateReader.Viewer;

namespace DateReader.Tests
{
    class DateReaderTest
    {
        protected string[] args;
        protected View view;
        protected Engine engine;

        public DateReaderTest()
        {
            this.view = new View();
            this.engine = new Engine(view);
        }
    }
}
