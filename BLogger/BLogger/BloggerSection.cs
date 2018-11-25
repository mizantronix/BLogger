using System;

namespace BLogger
{
    using System.Configuration;

    public class BloggerSection : ConfigurationSection
    {
        [ConfigurationProperty("LogPath")]
        public BloggerElement LogPath
        {
            get => this["LogPath"] as BloggerElement;
            set => this["LogPath"] = value;
        }

        public BloggerSettings CreateBloggerFromConfig()
        {
            var bloggerSettings = new BloggerSettings();
            try
            {
                bloggerSettings.Path = this.LogPath.Value;
            }
            catch (Exception e)
            {
                throw new BloggerException(e.Message);
            }

            return new BloggerSettings { Path = this.LogPath.Value };
        }
    }
}
