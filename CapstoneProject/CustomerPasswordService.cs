namespace CapstoneProject;

public class CustomerPasswordService
{
    private readonly CustomerPasswordRepo _customerPasswordRepo;

    public CustomerPasswordService(CustomerPasswordRepo customerPasswordRepo)
    {
        _customerPasswordRepo = customerPasswordRepo;
    }



    public CustomerPassword CreatePasswordEntry(CustomerPassword customerPassword)
    {
        return _customerPasswordRepo.CreatePasswordEntry(customerPassword);
    }
    
    













}