// See https://aka.ms/new-console-template for more information

using Friendface;

var App = new App();

initPersons();


Text("Friendface!");
Text("******************");

App.Run();

Text("Takk for idag, nerd!");




void initPersons()
{
    var Jarl = new Person("Jarl", "Semigammel");
    var Miguel = new Person("Miguel", "Rundt tredve");
    var Therese = new Person("Therese", "Rundt tredve");
    var Lisbeth = new Person("Lisbeth", "22ellerno");
}

void Text(string text)
{
    Console.WriteLine(text);
}

 
