
namespace Variant_1
{
    class LocalWeb : WebStorage
    {

        private int savedInfo { set; get; } = 0;
        public LocalWeb(int capacity, string owner, int downloadSpeed, int loadSpeed, string connectionType, int identifier, string servername) : base(capacity, owner, downloadSpeed, loadSpeed, connectionType, identifier, servername)
        {
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Stored info: " + savedInfo);
        }
        public override void DownloadInfo()
        {
            Console.WriteLine("---Overrided---");
            base.DownloadInfo();
        }
    }

    class SessionWeb : WebStorage
    {
        private int startSessionTime { set; get; } = 0;
        private int endSessionTime { set; get; } = 100;
        public SessionWeb(int capacity, string owner, int downloadSpeed, int loadSpeed, string connectionType, int identifier, string servername) : base(capacity, owner, downloadSpeed, loadSpeed, connectionType, identifier, servername)
        {
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Session time: " + (endSessionTime - startSessionTime));
        }
        public override void LoadInfo()
        {
            Console.WriteLine("---Overrided---");
            base.LoadInfo();
        }
    }
}
