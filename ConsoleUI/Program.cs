


using ConsoleUI;

PersonModel person = new PersonModel("Corey");

person.FirstName = "Tim";
//person.LastName = "Corey";
person.Age = 40;
person.SSN = "123-45-6789";

Console.WriteLine(person.FullName);

Console.WriteLine(person.SSN);

Console.ReadLine();