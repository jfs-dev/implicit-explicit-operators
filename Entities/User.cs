namespace implicit_explicit_operators.Entities;

public class User(string name, int age, string email)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public string Email { get; set; } = email;

    public static implicit operator Customer(User user) => new(user.Name, user.Age);
}