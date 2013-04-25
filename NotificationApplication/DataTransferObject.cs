namespace NotificationApplication
{
    public class DataTransferObject
    {
        public Notification Notification { get; set; }

        public DataTransferObject()
        {
            Notification = new Notification();
        }
    }
}