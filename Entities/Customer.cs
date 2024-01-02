namespace implicit_explicit_operators.Entities;

public class Customer(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;

    public static explicit operator User(Customer customer) => new(customer.Name, customer.Age, "Nenhum e-mail fornecido!");
}