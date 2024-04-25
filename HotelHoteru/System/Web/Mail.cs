namespace System.Web
{
    internal class Mail
    {
        internal class MailMessage
        {
            public MailMessage()
            {
            }

            public object Fields { get; internal set; }
            public object From { get; internal set; }
        }
    }
}