//kapitel 1
Page C1page1 = new Page(MyNotes.VariablesPageOne);
Page C1page2 = new Page(MyNotes.VariablesPageTwo);

List<Page> C1pages = new List<Page>();
C1pages.Add(C1page1);
C1pages.Add(C1page2);


//kapitel 2
Page C2page1 = new Page(MyNotes.DatatypesPageOne);
Page C2page2 = new Page(MyNotes.DatatypesPageTwo);

List<Page> C2pages = new List<Page>(); 
C2pages.Add(C2page1);
C2pages.Add(C2page2); 


//kapitel 3
Page C3page1 = new Page(MyNotes.ConditionelsPageOne);
Page C3page2 = new Page(MyNotes.ConditionelsPageTwo);

List<Page> C3pages = new List<Page>(); 
C3pages.Add(C3page1);
C3pages.Add(C3page2); 


//kapitel 4
Page C4page1 = new Page(MyNotes.ArraysPageOne);
Page C4page2 = new Page(MyNotes.ArraysPageTwo);

List<Page> C4pages = new List<Page>(); 
C4pages.Add(C4page1);
C4pages.Add(C4page2); 


//kapitel 5
Page C5page1 = new Page(MyNotes.LoopsPageOne);
Page C5page2 = new Page(MyNotes.LoopsPageTwo);

List<Page> C5pages = new List<Page>(); 
C5pages.Add(C5page1);
C5pages.Add(C5page2); 


//kapitel 6
Page C6page1 = new Page(MyNotes.MethodsPageOne);
Page C6page2 = new Page(MyNotes.MethodsPageTwo);

List<Page> C6pages = new List<Page>(); 
C6pages.Add(C6page1);
C6pages.Add(C6page2); 


//kapitel 7
Page C7page1 = new Page(MyNotes.ClassesPageOne);
Page C7page2 = new Page(MyNotes.ClassesPageTwo);

List<Page> C7pages = new List<Page>(); 
C7pages.Add(C7page1);
C7pages.Add(C7page2); 


//kapitel 8
Page C8page1 = new Page(MyNotes.ConstructorsPageOne);
Page C8page2 = new Page(MyNotes.ConstructorsPageTwo);

List<Page> C8pages = new List<Page>(); 
C8pages.Add(C8page1);
C8pages.Add(C8page2); 


//kapitel 9
Page C9page1 = new Page(MyNotes.FieldsPageOne);
Page C9page2 = new Page(MyNotes.FieldsPageTwo);

List<Page> C9pages = new List<Page>(); 
C9pages.Add(C9page1);
C9pages.Add(C9page2); 


//kapitel 10
Page C10page1 = new Page(MyNotes.SyntaxPageOne);
Page C10page2 = new Page(MyNotes.SyntaxPageTwo);

List<Page> C10pages = new List<Page>(); 
C10pages.Add(C10page1);
C10pages.Add(C10page2); 



//kapitler
Chapter chapterOne = new Chapter ("Variables", C1pages);
Chapter chapterTwo = new Chapter ("Datatypes", C2pages);
Chapter chapterThree = new Chapter ("Conditionels", C3pages);
Chapter chapterFour = new Chapter ("Arrays", C4pages);
Chapter chapterFive = new Chapter ("Loops", C5pages);
Chapter chapterSix = new Chapter ("Methods", C6pages);
Chapter chapterSeven = new Chapter ("Classes", C7pages);
Chapter chapterEight = new Chapter ("Constructors", C8pages);
Chapter chapterNine = new Chapter ("Fields", C9pages);
Chapter chapterTen = new Chapter ("Syntax", C10pages);

List<Chapter> chapters = new List<Chapter>();
chapters.Add(chapterOne);
chapters.Add(chapterTwo);
chapters.Add(chapterThree);
chapters.Add(chapterFour);
chapters.Add(chapterFive);
chapters.Add(chapterSix);
chapters.Add(chapterSeven);
chapters.Add(chapterEight);
chapters.Add(chapterNine);
chapters.Add(chapterTen);




//bogen
Book bog = new Book("Noter", chapters);

bog.Start();