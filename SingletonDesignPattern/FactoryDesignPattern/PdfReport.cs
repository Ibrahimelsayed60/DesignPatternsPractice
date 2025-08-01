using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.FactoryDesignPattern
{
    public class PdfReport : IReport
    {
        public void Generate()
        {
            Console.WriteLine("Generate Pdf Report");
        }
    }

    public class ExcelReport : IReport
    {
        public void Generate()
        {
            Console.WriteLine("Generate Excel Report");
        }
    }

    public class ReportFactory
    {
        public static IReport CreateReport(string type)
        {
            if (type == "pdf")
                return new PdfReport();
            else if (type == "excel")
                return new ExcelReport();
            else
                throw new ArgumentException("Invalid report type");
        }
    }

}
