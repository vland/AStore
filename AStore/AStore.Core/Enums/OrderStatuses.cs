namespace AStore.Core.Enums
{
    public enum OrderStatusesEnum
    {
        New = 1, 
        Processing = 2, 
        Paid = 3, 
        Delivery = 4,
        Completed = 5, 
        Rejected = 6
    }

    public static class OrderStatuses
    {
        public const int New = (int) OrderStatusesEnum.New;
        public const int Processing = (int) OrderStatusesEnum.Processing;
        public const int Paid = (int) OrderStatusesEnum.Paid;
        public const int Delivery = (int) OrderStatusesEnum.Delivery;
        public const int Completed = (int) OrderStatusesEnum.Completed;
        public const int Rejected = (int) OrderStatusesEnum.Rejected;
    }
}
