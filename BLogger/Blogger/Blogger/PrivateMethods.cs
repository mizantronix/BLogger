namespace Blogger
{
    public partial class Blogger
    {
        private void NameChecker()
        {
            if (string.IsNullOrEmpty(this.LogFileName))
            {
                this.LogFileName = "Default_Name";
            }
        }
    }
}
