namespace Solid.ISP.Before
{
    public interface IDocumentProcessor
    {
        void ReadDocument(string path);

        void SaveDocument(string path);

        void PrintDocument();

        void EmailDocument(string toEmail);
    }

    public class DocumentProcessor : IDocumentProcessor
    {
        public void ReadDocument(string path)
        {
            Console.WriteLine($"Opening document {path}");
        }

        public void SaveDocument(string path)
        {
            Console.WriteLine($"Saving document {path}");
        }

        public void PrintDocument()
        {
            Console.WriteLine("Printing document");
        }

        public void EmailDocument(string toEmail)
        {
            Console.WriteLine($"Email-ing document to {toEmail}");
        }
    }

    // but what about if I need a document processing that only reads and saves?
}
