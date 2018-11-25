namespace BLogger
{
    using System.Configuration;

    public class Blogger
    {
        private static Blogger _instanse;

        public static BloggerSettings BloggerSettings { get; private set; }

        private Blogger() { }

        public static Blogger GetBlogger()
        {
            if (_instanse == null && CanBeInitialized())
            {
                return new Blogger();
            }

            return _instanse;
        }

        private static bool CanBeInitialized()
        {
            try
            {
                var config = (BloggerSection) ConfigurationManager.GetSection("BloggerConfiguration");
                BloggerSettings = config.CreateBloggerFromConfig();
                return true;
            }
            catch (BloggerException)
            {
                return false;
            }
        }

        public void Log(EventType eventType, string header, string message)
        {
            throw new System.NotImplementedException();
        }

        public void Log(EventType eventType, string message)
        {
            this.Log(eventType, string.Empty, message);
        }
    }
}
