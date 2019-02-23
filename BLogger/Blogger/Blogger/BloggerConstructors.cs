namespace Blogger
{
    public partial class Blogger
    {
        private Blogger()
        {
        }

        public Blogger Logger()
        {
            if (this._logger == null)
            {
                this._logger = new Blogger();
                this.DefaultInitialize();
            }

            return this._logger;
        }
    }
}
