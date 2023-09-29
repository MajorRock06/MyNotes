public class MyNotes
{
    // En simpel datastruktur til at opbevare sideindhold baseret på nøgler
    private static Dictionary<string, string> pageContents = new Dictionary<string, string>();

    static MyNotes()
    {
        // Tilføj sideindhold til dictionary baseret på nøgler
        pageContents["VariablesPage1"] = "Dette er side 1 af kapitel om variabler.";
        pageContents["VariablesPage2"] = "Dette er side 2 af kapitel om variabler.";
        // Tilføj sideindhold for de andre nøgler...
    }

    public static void Main()
    {
        // Test af GetPageContent
        string content = GetPageContent("VariablesPage1");
        Console.WriteLine(content);
    }

    public static string GetPageContent(string pageContentKey)
    {
        // Simpel implementering: Hent sideindhold fra dictionary
        if (pageContents.ContainsKey(pageContentKey))
        {
            return pageContents[pageContentKey];
        }
        else
        {
            return "Sideindhold ikke fundet.";
        }
    }
}





