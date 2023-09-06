//kapitel 1
Page page1 = new Page(MyNotes.VariablesPageOne);

List<Page> C1pages = new List<Page>();
C1pages.Add(page1);


//kapitel 2
List<Page> C2pages = new List<Page>();




//kapitler
Chapter chapterOne = new Chapter ("variables", C1pages);
Chapter chapterTwo = new Chapter ("datatypes", C2pages);


List<Chapter> chapters = new List<Chapter>();
chapters.Add(chapterOne);




//bogen
Book bog = new Book("Noter", chapters);

bog.Start();