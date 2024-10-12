public class PaymentNotification
{
    public int PaymentId { get; set; }
    public int StudentId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentReference { get; set; }
}
