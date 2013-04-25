namespace NotificationApplication
{
    public class ServiceCommand<T> where T : DataTransferObject
    {
        private readonly T _data;

        protected T Data { get { return _data; } }

        protected Notification Notification { get { return _data.Notification; } }

        protected ServiceCommand(T data)
        {
            _data = data;
        }

        protected void FailIfNullOrBlank(string s, Notification.Error error)
        {
            Fail(IsNullOrBlank(s), error);
        }

        private bool IsNullOrBlank(string s)
        {
            return string.IsNullOrEmpty(s);
        }

        protected void Fail(bool condition, Notification.Error error)
        {
            if (condition)
            {
                Notification.AddError(error);
            }
        }
    }
}