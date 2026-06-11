namespace Projek_Final_sem2.Examples.OOPExample.Payments
{
    //Polymorphism.
    public class CashPayment : IPayment
    {
        public bool Pay(decimal amount)
        {
            // simple mock implementation
            return amount >= 0;
        }
    }
}
