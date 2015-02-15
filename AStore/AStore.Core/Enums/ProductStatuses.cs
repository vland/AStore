namespace AStore.Core.Enums
{
    public enum ProductStatusesEnum
    {
        Available = 1, 
        OutOfStock = 2, 
        WaitingForDelivery = 3
    }

    public static class ProductStatuses
    {
        public const int Available = (int) ProductStatusesEnum.Available;
        public const int OutOfStock = (int) ProductStatusesEnum.OutOfStock;
        public const int WaitingForDelivery = (int) ProductStatusesEnum.WaitingForDelivery;
    }
}
