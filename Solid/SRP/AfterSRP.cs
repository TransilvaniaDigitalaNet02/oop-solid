namespace Solid.SRP.After
{
    // Holds the report
    public class Report
    {
        public Report(string reportName) 
        {
            ReportName = reportName;
        }

        public string ReportName { get; }
    }

    public class ReportGenerator
    {
        // Responsible of generating a PDF file containing a financial report.
        public Report GenerateReport(string reportName)
        {
            Report report = new Report(reportName);
            Console.WriteLine($"Generating report {report.ReportName}");
            return report;
        }
    }

    public class EmailSender
    {
        // Responsible of sending the report via email
        public void EmailReport(string subject, string toEmail, Report report)
        {
            Console.WriteLine("Sending email");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"To: {toEmail}");
            Console.WriteLine($"Attaching file: {report.ReportName}");
        }
    }

    /*--------------------------------------------------------------------*/

    public class GeometryRectangle
    {
        private double area = 100;

        // Responsibility of a geometry application
        public double CalculateArea()
        {
            return area;
        }
    }

    public class GraphicalInterfaceRectangle : GeometryRectangle
    {
        // Responsibility of a GUI application
        public void Draw(/* System.Drawing.Graphics canvas */)
        {
            // now we have to import the Windows.Forms library which blocks us
            // on a particular OS / GUI technology
            /* canvas.DrawRectangle(100, 100, 300, 500); */
        }
    }
}
