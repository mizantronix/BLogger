namespace Blogger.Models
{
    using System.IO;

    public class BloggerSettings
    {
        public string LogPath { get; set; }

        public bool EnableDate { get; set; }

        public string LogFileName { get; set; }

        public bool ExistLogFileName { get; set; }

        public BloggerSettings(string logPath = null, bool enableDate = false, string logFileName = null)
        {
            this.LogPath = string.IsNullOrEmpty(logPath)
                ? Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()))
                : logPath;

            this.EnableDate = enableDate;

            if (string.IsNullOrEmpty(logFileName))
            {
                this.ExistLogFileName = false;
            }
            else
            {
                this.ExistLogFileName = true;
                this.LogFileName = logFileName;
            }
        }
    }
}
