/*
public static class MyNotes
{
//kapitel 1
public static string VariablesPageOne =
@"";

public static string VariablesPageTwo =
@"";

//Kapitel 2
public static string DatatypesPageOne =
@"";


public static string DatatypesPageTwo =
@"";

//Kapitel 3
public static string ConditionelsPageOne =
@"";

public static string ConditionelsPageTwo =
@"";

//Kapitel 4
public static string ArraysPageOne =
@"";

public static string ArraysPageTwo =
@"";

//Kapitel 5
public static string LoopsPageOne =
@"";

public static string LoopsPageTwo =
@"";

//Kapitel 6
public static string MethodsPageOne =
@"";

public static string MethodsPageTwo =
@"";

//Kapitel 7
public static string ClassesPageOne =
@"";

public static string ClassesPageTwo =
@"";

//Kapitel 8
public static string ConstructorsPageOne =
@"";

public static string ConstructorsPageTwo =
@"";

//Kapitel 9
public static string FieldsPageOne =
@"";

public static string FieldsPageTwo =
@"";

//kapitel 10
public static string SyntaxPageOne =
@"";

public static string SyntaxPageTwo =
@"";
}
*/
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





