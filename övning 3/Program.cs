﻿
PersonHandler handler= new PersonHandler();
handler.CreatePerson(55, "Farzin", "Hekmatara", 167 , 78);
handler.CreatePerson(45, "Kalle", "Andersson", 175, 79);
handler.CreatePerson(50, "Gustav", "Levin", 180, 88);
handler.CreatePerson(65, "Robert", "Gustavsson", 189, 86);

List<Person> personList=handler.GetPersonList();
foreach (Person personInfo in personList)
   Console.WriteLine ($"Ålder: {personInfo.GetAge()}"+
       $" Förnamn: { personInfo.GetfName()}"+
       $" Efternamn: {personInfo.GetLname()}" +
       $" Längd: {personInfo.GetHeight()}"+
       $" Vikt: {personInfo.GetWeight()}");
Console.WriteLine("*******************");

handler.SetAge(personList[1], 80);

foreach (Person personInfo in personList)
    Console.WriteLine($"Ålder: {personInfo.GetAge()}" +
        $" Förnamn: { personInfo.GetfName()}" +
        $" Efternamn: {personInfo.GetLname()}" +
        $" Längd: {personInfo.GetHeight()}" +
        $" Vikt: {personInfo.GetWeight()}");