// See https://aka.ms/new-console-template for more information

using TestProjekt;

// Input Werte
List<int> zahlenListe  = new List<int>{1, 3, 5, 7, 8};  //nur ungerade zahlen okay
bool istPrivat = true; //nur false ist okay
string getränk = "Cola";  //nur Apfelsaft ist okay

// Dictionary
Dictionary<string, object?> inputDictionary = new Dictionary<string, object?>();
inputDictionary.Add("zahlen", zahlenListe);
inputDictionary.Add("privat", istPrivat);
inputDictionary.Add("getränk", getränk);

// Validierung
Party party = new Party();
IsValidResult result = party.IsValid(inputDictionary);

//Ausgabe Ergebnisse
Console.WriteLine("Is Valid: " + result.IsValid + Environment.NewLine);
Console.WriteLine(result.ErrorMessage);