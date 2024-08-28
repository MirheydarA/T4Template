namespace Models
{
    public class Order Details
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public object UnitPrice { get; set; }
        public short Quantity { get; set; }
        public object Discount { get; set; }
    }
}
