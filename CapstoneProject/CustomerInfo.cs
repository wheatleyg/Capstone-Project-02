//using Dapper.Contrib.Extensions;

//using System.ComponentModel.DataAnnotations.Schema;
using Dapper.Contrib.Extensions;

namespace CapstoneProject;




[Table("skibidi_customers_info")]
public class Customer
{
    [Key] 
    public int customer_id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string email { get; set; }
    public string phone_number { get; set; }
    public string address { get; set; }
    public string city { get; set; }
    public string country { get; set; }
    public string postal_code { get; set; }
    public MembershipStatusMethodThing membership_status { get; set; }

    public enum MembershipStatusMethodThing
    {
        active, inactive, pending //not sure if this works, but i dont feel like finding out.
    }

}