// Kapitler
string[] chapterTitles = { "Variables", "Datatypes", "Conditionals", "Arrays", "Loops", "Methods", "Classes", "Constructors", "Fields", "Syntax" };
int numPagesPerChapter = 1;

List<Chapter> chapters = new List<Chapter>();

for (int i = 0; i < chapterTitles.Length; i++)
{
    List<Page> chapterPages = new List<Page>();
    for (int j = 1; j <= numPagesPerChapter; j++)
    {
        Page page = new Page(GetPageContent(chapterTitles[i], j));
        chapterPages.Add(page);
    }
    Chapter chapter = new Chapter(chapterTitles[i], chapterPages);
    chapters.Add(chapter);
}

// Hjælpefunktion til at generere sideindhold baseret på kapitel og side-nummer
string GetPageContent(string chapterTitle, int pageNumber)
{
    string pageContentKey = $"{chapterTitle}Page{pageNumber}";
    // Implementer din egen logik til at hente sideindholdet baseret på nøglen (pageContentKey)
    return MyNotes.GetPageContent(pageContentKey);
}

// Bogen
Book bog = new Book("Noter", chapters);
bog.Start();

