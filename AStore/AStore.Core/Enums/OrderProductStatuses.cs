namespace AStore.Core.Enums
{
    public enum OrderProductStatusesEnum
    {
        Ok = 1, 
        Canceled = 2
    }

    public static class OrderProductStatuses
    {
        public const int Ok = (int) OrderProductStatusesEnum.Ok;
        public const int Canceled = (int) OrderProductStatusesEnum.Canceled;
    }
}
