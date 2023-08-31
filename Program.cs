Book BookOfNotes = new Book();


List<Page> C1pages = new List<Page>();

Page C1page01 = new Page(MyNotes.VariablesPageOne);
Page C1page02 = new Page(MyNotes.VariablesPageTwo);

C1pages.Add(C1page01);
C1pages.Add(C1page02);

List<Page> C2pages = new List<Page>();

Page C2page01 = new Page(MyNotes.DatatypesPageOne);
Page C2page02 = new Page(MyNotes.VariablesPageTwo);

C2pages.Add(C2page01);
C2pages.Add(C2page02)

//kapitel

Chapter Chapter1 = new Chapter("kapitel 1: Variables", C1pages);

Chapter chapter2 = new Chapter("kapitel 2: Datatypes", C2pages);

chapter2.Read();



//pause
Console.ReadLine();
