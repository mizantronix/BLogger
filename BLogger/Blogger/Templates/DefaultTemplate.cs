using System;
using System.IO;

namespace Blogger.Templates
{
    public class DefaultTemplate : ITemplate
    {
        public string Name { get; private set; }

        public DefaultTemplate()
        {
            this.Name = "default";
        }

        public void LogEvent(string type, string message)
        {
            this.LogEvent(type, string.Empty, message);
        }

        public void LogEvent(string type, string header, string message)
        {
            this.NameChecker();
            using (var file = new StreamWriter($"{this._settings.LogPath}\\{type}_{this._settings.LogFileName}.log", true))
            {
                file.WriteLine("=========================");
                if (this._settings.EnableDate)
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
