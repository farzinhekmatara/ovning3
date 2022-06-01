
PersonHandler handler = new PersonHandler();
handler.CreatePerson(55, "Farzin", "Hekmatara", 167, 78);
handler.CreatePerson(45, "Kalle", "Andersson", 175, 79);
handler.CreatePerson(50, "Gustav", "Levin", 180, 88);
handler.CreatePerson(65, "Robert", "Gustavsson", 189, 86);


try
{
    handler.CreatePerson(30, "A", "Andersson", 100, 100);
}
catch (Exception e)
{

    Console.WriteLine(e.Message);
    //throw;
}

List<Person> personList = handler.GetPersonList();
foreach (Person personInfo in personList)
    Console.WriteLine($"Ålder: {personInfo.GetAge()}" +
        //$" Förnamn: { personInfo.GetfName()}"+
        $" Förnamn: { personInfo.FirstName}" +
        $" Efternamn: {personInfo.GetLname()}" +
        $" Längd: {personInfo.GetHeight()}" +
        $" Vikt: {personInfo.GetWeight()}");
Console.WriteLine("*******************");

handler.SetAge(personList[1], 80);

foreach (Person personInfo in personList)
    Console.WriteLine($"Ålder: {personInfo.GetAge()}" +
        $" Förnamn: { personInfo.FirstName}" +
        $" Efternamn: {personInfo.GetLname()}" +
        $" Längd: {personInfo.GetHeight()}" +
        $" Vikt: {personInfo.GetWeight()}");