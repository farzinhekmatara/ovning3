using Polymorfism32;
List<UserError> myList= new List<UserError>();
myList.Add(new NumericInputError());
myList.Add(new TextInputError());
foreach(UserError error in myList)
     Console.WriteLine(error.UEMessage());
Console.ReadLine();