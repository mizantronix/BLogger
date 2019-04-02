using Blogger.Models;

namespace Blogger.Blogger
{
    public partial class Blogger
    {
        public void DefaultInitialize()
        {
            if (_logger == null)
            {
                _logger = new Blogger();
            }

            this._settings = new BloggerSettings();
        }

        public void Initialize(string logPath = null, bool enableDate = false, string logFileName = null)
        {
            this._settings = new BloggerSettings(logPath, enableDate, logFileName);
        }
    }
}
