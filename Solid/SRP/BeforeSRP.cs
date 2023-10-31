namespace Solid.SRP.Before
{
    public class ReportGenerator
    {
        private string generatedReportName = string.Empty;

        // Responsible of generating a PDF file containing a financial report.
        public void GenerateReport(string reportName)
        {
            generatedReportName = reportName;
            Console.WriteLine($"Generating report {generatedReportName}");
        }

        // Responsible of sending the report via email
        public void EmailReport(string subject, string toEmail)
        {
            Console.WriteLine("Sending email");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"To: {toEmail}");
            Console.WriteLine($"Attaching file: {generatedReportName}");
        }
    }

    /*--------------------------------------------------------------------*/

    public class Rectangle
    {
        private double area = 100;

        // Responsibility of a geometry application
        public double CalculateArea()
        {
            return area;
        }

        // Responsibility of a GUI application
        public void Draw(/* System.Drawing.Graphics canvas */)
        {
            // now we have to import the Windows.Forms library which blocks us
            // on a particular OS / GUI technology
            /* canvas.DrawRectangle(100, 100, 300, 500); */
        }
    }
}
