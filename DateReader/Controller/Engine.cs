using System;

using DateReader.Viewer;

namespace DateReader.Controller
{
    public class Engine
    {
        private View view;
        public string result;

        public Engine(View view)
        {
            this.view = view;
        }

        public void Run(string[] args) {
            if (args.Length == 2)
            {
                try
                {
                    DateTime first = ReadDateInput(args[0]);
                    DateTime second = ReadDateInput(args[1]);
                    CompareDates(first, second);
                }
                catch (FormatException)
                {
                    result = view.FormatErrorMessage();
                    view.PrintLn(result);
                    return;
                }
            }
            else
            {
                result = view.UsageMessage();
                view.PrintLn(result);
            }
        }

        private void CompareDates(DateTime first, DateTime second)
        {
            int daysRange = (first.Date - second.Date).Days;

            if(daysRange < 0)
            {
                result = FormatOutputForDates(first, second, daysRange);
            }
            else
            {
                result = FormatOutputForDates(second, first, daysRange);
            }

            view.PrintLn(result);
        }

        private string FormatOutputForDates(DateTime minor, DateTime greater, int days) {
            string outPut;
            if (IsYearTheSame(minor, greater) && IsMonthTheSame(minor, greater))
            {
                outPut = $"{minor.Day.ToString().PadLeft(2, '0')} - {greater.Day.ToString().PadLeft(2, '0')}.{greater.Month.ToString().PadLeft(2, '0')}.{greater.Year} ({Math.Abs(days)} days)";
                return outPut;
            }
            else if (IsYearTheSame(minor, greater))
            {
                outPut = $"{minor.Day.ToString().PadLeft(2, '0')}.{minor.Month.ToString().PadLeft(2, '0')} - {greater.Day.ToString().PadLeft(2, '0')}.{greater.Month.ToString().PadLeft(2, '0')}.{greater.Year} ({Math.Abs(days)} days)";
                return outPut;
            } else
            {
                outPut = $"{minor.Day.ToString().PadLeft(2, '0')}.{minor.Month.ToString().PadLeft(2, '0')}.{minor.Year} - {greater.Day.ToString().PadLeft(2, '0')}.{greater.Month.ToString().PadLeft(2, '0')}.{greater.Year} ({Math.Abs(days)} days)";
                return outPut;
            }
        }

        private bool IsYearTheSame(DateTime first, DateTime second) {
            return (first.Year == second.Year);
        }

        private bool IsMonthTheSame(DateTime first, DateTime second) {
            return (first.Month == second.Month);
        }

        private DateTime ReadDateInput(string dateInput) {
            DateTime outPutDate = Convert.ToDateTime(dateInput);
            return outPutDate;
        }
    }
}
