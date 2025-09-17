// See https://aka.ms/new-console-template for more information
using CapstoneProject;


internal static class Program
{
    public static void Main(string[] args)
    {
        var repo = new CustomerPasswordRepo();

        var test = new CustomerPassword()
        {
            customer_id = 67,
        };

        test = repo.GetPasswordByCustomerId(test.customer_id);
        
        Console.WriteLine(test.password_hash );
    }
}