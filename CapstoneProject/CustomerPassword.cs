//using System.ComponentModel.DataAnnotations.Schema;


using System.ComponentModel.DataAnnotations.Schema;
using Dapper.Contrib.Extensions;

namespace CapstoneProject;


[Dapper.Contrib.Extensions.Table("customer_password")]
public class CustomerPassword
{
 [Key]
 public int customer_id { get; set; }
 public string password_hash { get; set; }
 public DateTime password_reset_date { get; set; }
 [Column("2fa_status")]
 public string two_fa_status_raw { get; set; }

 [Computed] public bool two_fa_status => two_fa_status_raw == "true"; //when i made the db, i was a FOOL and for whatever reason 3 hour sleep me had, made the values enum, not bool


}




//namespace CapstoneProject;

/*


[Dapper.Contrib.Extensions.Table("skibidi_customers_info")]
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

    public enum membership_status
    {
        active, inactive, pending //not sure if this works, but i dont feel like finding out.
    }

}
*/