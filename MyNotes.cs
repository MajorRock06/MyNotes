using System;
using System.Collections.Generic;
using System.IO;

public class MyNotes
{
    private static Dictionary<string, string> pageContents = new Dictionary<string, string>();

    static MyNotes()
    {
        // Sti til mappen med .txt-filer
        string folderPath = "Pages";

        // Liste over de ønskede sideindholdsnøgler (filnavne uden .txt-udvidelsen)
        string[] pageContentKeys = { "VariablesPage1", "DatatypesPage1" };

        foreach (string pageContentKey in pageContentKeys)
        {
            string filePath = Path.Combine(folderPath, $"{pageContentKey}.txt");

            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                pageContents[pageContentKey] = content;
            }
            else
            {
                pageContents[pageContentKey] = "Sideindhold ikke fundet.";
            }
        }
    }

    public static string GetPageContent(string pageContentKey)
    {
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