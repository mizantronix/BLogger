namespace Blogger
{
    using System;
    using System.IO;

    public class Blogger
    {
        private string LogPath { get; }

        private bool EnableDate { get; }

        private string LogFileName { get; set; }

        private Blogger()
        {
        }

        public Blogger(string logPath, string logFileName = "", bool enambleDate = false)
        {
            this.LogPath = logPath;
            this.LogFileName = logFileName;
            this.EnableDate = enambleDate;
        }

        public void LogEvent(string type, string message)
        {
            this.LogEvent(type, string.Empty, message);
        }

        public void LogEvent(string type, string header, string message)
        {
            this.NameChecker();
            if (!string.IsNullOrEmpty(this.LogPath))
            {
                using (var file = new StreamWriter($"{this.LogPath}\\{type}_{this.LogFileName}.log", true))
                {
                    file.WriteLine("=========================");
                    if (EnableDate)
                    {
                        file.WriteLine($"{DateTime.Now}");
                        file.WriteLine("-------------------------");
                    }

                    if (!string.IsNullOrEmpty(header))
                    {
                        file.WriteLine($"{header}");
                        file.WriteLine("-------------------------");
                    }

                    file.WriteLine(message);
                    file.WriteLine("=========================");
                    file.WriteLine('\n');
                }
            }
        }

        private void NameChecker()
        {
            if (string.IsNullOrEmpty(this.LogFileName))
            {
                this.LogFileName = "Default_Name";
            }
        }
    }
}
