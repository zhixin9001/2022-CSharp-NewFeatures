using System;

public class _1_record
{
  public static void Entry()
  {
    var phoneNumbers = new string[2];
    Person person1 = new("Nancy", "Davolio", phoneNumbers);
    Person person2 = new("Nancy", "Davolio", phoneNumbers);
    Console.WriteLine(person1); // output: True

    person1 = person1 with { FirstName = "" };
    Console.WriteLine(person1); // output: True
    person1.phones[0] = "555-1234";
    Console.WriteLine(person1 == person2); // output: True
    Console.WriteLine(ReferenceEquals(person1, person2)); // output: False
    // output: Person { FirstName = Nancy, LastName = Davolio }
  }

  public record Person(string FirstName, string LastName, string[] phones);

  public record Person1
  {
    public string FirstName { get; init; } = "123";
    public string LastName { get; init; } = default!;
  };

  public record Person2 : Person1
  {
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
  };
}