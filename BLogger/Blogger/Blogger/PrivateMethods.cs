namespace Blogger.Blogger
{
    public partial class Blogger
    {
        private void NameChecker()
        {
            if (!this._settings.ExistLogFileName)
            {
                this._settings.LogFileName = "Default_Name";
            }
        }
    }
}
