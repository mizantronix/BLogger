namespace Blogger.Blogger
{
    public partial class Blogger
    {
        private Blogger()
        {
        }

        public Blogger Logger()
        {
            if (_logger == null)
            {
                _logger = new Blogger();
                this.DefaultInitialize();
            }

            return _logger;
        }
    }
}
