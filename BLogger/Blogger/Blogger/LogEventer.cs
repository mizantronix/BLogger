namespace Blogger
{
    using System;
    using System.IO;

    public partial class Blogger
    {
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
    }
}
