using System;
using CustomList.Core.Models; 
using CustomList.Data;


CustomList<Person> customList = new CustomList<Person>();
customList.Add(new Person { Name = "Izzat", Surname = "Abdullayev", Age = 22, Position = "Senior" });
customList.Add(new Person { Name = "Ahmed", Surname = "Mehdi", Age = 23, Position = "Senior" });
customList.Add(new Person { Name = "Murad", Surname = "Safarli", Age = 26, Position = "Senior" });
customList.Add(new Person { Name = "Anar", Surname = "Gurbanli", Age = 23, Position = "Senior" });
customList.Add(new Person { Name = "Lala", Surname = "Firudinli", Age = 23, Position = "Senior" });

Person person = customList.Find(person => person.Age == 25);
if(person != null)
{
    Console.WriteLine($"{person.Name} {person.Surname}{person.Age}{person.Position}");
}
else
{
    Console.WriteLine("There is no such person");
}