using ChallengeApp;

Employee employee1 = new Employee("Jan", "Kowalski", "55");
Employee employee2 = new Employee("Maciej", "Nowak", "23");
Employee employee3 = new Employee("Marcin", "Maj", "17");

employee1.AddScore(3);
employee1.AddScore(2);
employee1.AddScore(6);
employee1.AddScore(1);
employee1.AddScore(4);

employee2.AddScore(5);
employee2.AddScore(6);
employee2.AddScore(1);
employee2.AddScore(7);
employee2.AddScore(2);

employee3.AddScore(1);
employee3.AddScore(9);
employee3.AddScore(8);
employee3.AddScore(4);
employee3.AddScore(7);


if (employee1.Result >= employee2.Result && employee1.Result >= employee3.Result)
{
    Console.WriteLine($"Najwyższy wynik osiągnął:\n {employee1.Name} \n {employee1.Surname} \n Wiek: {employee1.Age}\n zdobywając {employee1.Result} punktów");
}
else if (employee2.Result >= employee1.Result && employee2.Result >= employee3.Result)
{
    Console.WriteLine($"Najwyższy wynik osiągnął:\n {employee2.Name} \n {employee2.Surname} \n Wiek: {employee2.Age}\n zdobywając {employee2.Result} punktów\"");
}
else if (employee3.Result >= employee1.Result && employee3.Result >= employee2.Result)
{
    Console.WriteLine($"Najwyższy wynik osiągnął:\n {employee3.Name} \n {employee3.Surname} \n Wiek: {employee3.Age}\n zdobywając {employee3.Result} punktów\"");
}




