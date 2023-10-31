namespace Solid.ISP.After
{
    public interface IDocumentReader
    {
        void ReadDocument(string path);
    }

    public interface IDocumentSaver
    {
        void SaveDocument(string path);
    }

    public interface IDocumentPrinter
    {
        void PrintDocument();
    }

    public interface IDocumentEmailer
    {
        void EmailDocument(string toEmail);
    }

    public interface IFullDocumentProcessor : IDocumentReader,
                                              IDocumentSaver,
                                              IDocumentPrinter,
                                              IDocumentEmailer
    {
        // now all these abstractions can be used toghether in a single
        // "big" abstraction
    }

    public interface ISimpleDocumentProcessor: IDocumentReader,
                                               IDocumentSaver
    {
        // or we can re-arrange them in other abstractions
    }

    public class FullDocumentProcessor : IFullDocumentProcessor
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

    public class SimpleDocumentProcessor : ISimpleDocumentProcessor
    {
        public void ReadDocument(string path)
        {
            Console.WriteLine($"Opening document {path}");
        }

        public void SaveDocument(string path)
        {
            Console.WriteLine($"Saving document {path}");
        }
    }
}
