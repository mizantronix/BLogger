namespace Blogger
{
    using System.IO;

    public partial class Blogger
    {
        public void DefaultInitialize()
        {
            this.LogPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            this.EnableDate = false;
        }

        public void Initialize(string logPath = null, bool enableDate = false)
        {
            this.LogPath = string.IsNullOrEmpty(logPath) ? Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) : logPath;

            this.EnableDate = enableDate;
        }

        public Blogger(string logPath, string logFileName = "", bool enambleDate = false)
        {
            this.LogPath = logPath;
            this.LogFileName = logFileName;
            this.EnableDate = enambleDate;
        }
    }
}
