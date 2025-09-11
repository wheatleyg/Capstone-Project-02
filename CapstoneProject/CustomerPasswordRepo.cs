using Dapper.Contrib.Extensions;
using MySqlConnector;



namespace CapstoneProject;

public class CustomerPasswordRepo
{
    //Jetbrains wants this to be private. I don't trust it.
    public static readonly string ConnectionString = 
        "Server=localhost;database=mysqldatabase;Uid=root;Password=PoofBall#1;Port=3306;";

    public CustomerPassword CreatePasswordEntry(CustomerPassword customerPassword)
    {
        //EVERYTHING IS PAIN
        using var connection = new MySqlConnection(ConnectionString);
        
        var customer_id = connection.Insert(customerPassword);
        return customerPassword;
    }


    public CustomerPassword UpdatePasswordEntry(CustomerPassword customerPassword)
    {
        using var connection = new MySqlConnection(ConnectionString);
        
        var success = connection.Update(customerPassword);
        if (success)
            return customerPassword;
        else
            throw new Exception("Error updating.");
    }

    public CustomerPassword GetPasswordByCustomerId(int customer_id)
    {
        using var connection = new MySqlConnection(ConnectionString);
        
        var customerPassword = connection.Get<CustomerPassword>(customer_id);
        
        return customerPassword;
    }

    public bool DeletePassword(int customerId)
    {

        using var connection = new MySqlConnection(ConnectionString);
        
        var success = connection.Delete(new CustomerPassword { customer_id = customerId });

        if (success)
            return true;
        else
        {
            throw new Exception("Error deleting.");
        }
    }






}