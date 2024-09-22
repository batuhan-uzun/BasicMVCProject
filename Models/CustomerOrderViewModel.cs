namespace BasicMVCProject.Models
{
    public class CustomerOrderViewModel
    {
        public Customer customer { get; set; }
        public List<Orders> orders { get; set; }
    }
}
