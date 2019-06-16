namespace CRUD
{
    public class EmptyDiscount : Discount
    {
        public override double ReturnPrice(object items, object items2, object items3)
        {
            return 0;
        }
    }
}