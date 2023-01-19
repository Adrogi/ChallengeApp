var Adam = 0;
var Beata = 0;
var Cezary = 0;
var Daria = 0;
var Emil = 0;
var Franciszek = 0;

List<string> namesList = new List<string>();
namesList.Add("Adam");
namesList.Add("Beata");
namesList.Add("Cezary");
namesList.Add("Adam");
namesList.Add("Emil");
namesList.Add("Franciszek");
namesList.Add("Adam");
namesList.Add("Adam");
namesList.Add("Daria");
namesList.Add("Daria");
namesList.Add("Emil");
namesList.Add("Daria");
namesList.Add("Daria");
namesList.Add("Daria");
namesList.Add("Emil");
namesList.Add("Emil");
namesList.Add("Daria");
namesList.Add("Franciszek");
namesList.Add("Daria");
namesList.Add("Adam");



foreach ( var name in namesList)
{
    if (name == "Adam")
    {
        Adam++;
    }
    else if (name == "Beata")
    {
        Beata++;
    }
    else if (name == "Cezary")
    {
        Cezary++;
    }
    else if (name == "Daria")
    {
        Daria++;
    }
    else if (name == "Emil")
    {
        Emil++;
    }
    else
    {
        Franciszek++;
    }
}


Console.WriteLine("Adam:       " + Adam);
Console.WriteLine("Beata:      " + Beata);
Console.WriteLine("Cezary:     " + Cezary);
Console.WriteLine("Daria:      " + Daria);
Console.WriteLine("Emil:       " + Emil);
Console.WriteLine("Franciszek: " + Franciszek);

