
using System.Text;

namespace TestProjekt
{
  public class Party
  {
    public IsValidResult IsValid(Dictionary<string, object?> inputDictionary)
    {
      bool isValid = true;
      StringBuilder errorMessages = new StringBuilder();

      // Prüfe Zahlenliste hat nur ungerade
      if (inputDictionary["zahlen"] is List<int> zahlen)
      {
        if (zahlen.Any(z => z % 2 == 0))
        {
          isValid = false;
          errorMessages.Append("Gerade Zahlen sind nicht erlaubt!");
          errorMessages.AppendLine();
        }
      }

      // Prüfe ob privat
      if(inputDictionary["privat"] is bool istPrivat)
      {
        if (istPrivat)
        {
          isValid = false;
          errorMessages.Append("Es muss öffentlich sein!");
          errorMessages.AppendLine();
        }
      }

      //Prüfe Getränk
      if (inputDictionary["getränk"] is string getränk)
      {
        if (!getränk.Equals("Apfelsaft"))
        {
          isValid = false;
          errorMessages.Append("Wir haben nur Apfelsaft!");
          errorMessages.AppendLine();
        }
      }

      return new IsValidResult(){IsValid = isValid, ErrorMessage = errorMessages.ToString()};
    }
  }
}
