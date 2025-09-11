using Dapper.Contrib.Extensions;

namespace CapstoneProject;
[Table("customer_purchaes")]
public class CustomerPurchases
{
    [Key]
    public int order_id { get; set; }
    public string product_name { get; set; }
    public string product_category { get; set; }
    public decimal product_price { get; set; }
    public DateTime purchase_date { get; set; }
    public int quantity { get; set; }
    public int customer_id { get; set; }



    //too complicated for me to turn the enums human readable, ohwell
    public string payment_method { get; set; }
    public DateTime delivery_date { get; set; }
    public string order_status { get; set; }
    
    
    
}