namespace Documents;

class DocumentProgram
{
    public DocumentProgram() { }

    public void OpenDocument()
    {
        Console.WriteLine("Document Opened");
    }

    virtual public void EditDocument()
    {
        Console.WriteLine("Can Edit in Pro and Expert versions");
    }

    virtual public void SaveDocument()
    {
        Console.WriteLine("Can Save in Pro and Expert versions");
    }

}

class ProDocumentProgram : DocumentProgram
{
    public ProDocumentProgram() { }
    public override void EditDocument()
    {
        Console.WriteLine("Document edited");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
    }
}


class ExpertDocument : ProDocumentProgram
{
    public ExpertDocument() { }


    public override void SaveDocument()
    {
        Console.WriteLine("Document Saved in pdf format");
    }
}

class Program
{
    static void Main()
    {

        Console.WriteLine("Please enter keys: ");
        Console.WriteLine("(Keys):\nbasic\npro\nexpert");
        string key = Console.ReadLine();
        if (key == "basic")
        {
            DocumentProgram docProgram = new DocumentProgram();
            docProgram.OpenDocument();
            docProgram.EditDocument();
            docProgram.SaveDocument();
        }
        else if (key == "pro")
        {
            DocumentProgram docProgram = new ProDocumentProgram();
            docProgram.OpenDocument();
            docProgram.EditDocument();
            docProgram.SaveDocument();
        }
        else if (key == "expert")
        {
            DocumentProgram docProgram = new ExpertDocument();
            docProgram.OpenDocument();
            docProgram.EditDocument();
            docProgram.SaveDocument();
        }

    }
}