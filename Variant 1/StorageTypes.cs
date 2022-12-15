
namespace Variant_1
{
    class LocalStorage : Storage
    {
        protected int identifier { get; }
        public int writeSpeed { get; }
        public int readSpeed { get; }
        public string connectionType { get; }
        public LocalStorage(int capacity, string owner, int writeSpeed, int readSpeed, string connectionType, int identifier) : base(capacity, owner)
        {
            this.readSpeed = readSpeed;
            this.writeSpeed = writeSpeed;
            this.connectionType = connectionType;
            this.identifier = identifier;
        }
        override public void PrintInfo()
        {
            Console.WriteLine("Type: " + GetType().Name);
            Console.WriteLine("Spaced: " + actCapacity + "/" + capacity);
            Console.WriteLine("Speed: write-" + writeSpeed + " read-" + readSpeed);
            Console.WriteLine("Identifier: " + identifier);
        }
        virtual public void WriteInfo(int info)
        {
            actCapacity += info;
            Console.WriteLine("To " + GetType().Name + " added " + info + " bytes");
        }
        virtual public void DeleteInfo(int info)
        {
            actCapacity -= info;
            Console.WriteLine("From " + GetType().Name + " deleted " + info + " bytes");
        }
    }
    class RemovableStorage : Storage
    {
        protected int identifier { get; }
        public int writeSpeed { get; }
        public int readSpeed { get; }
        public string connectionType { get; }
        public int size { get; }
        public RemovableStorage(int capacity, string owner, int writeSpeed, int readSpeed, string connectionType, int identifier, int size) : base(capacity, owner)
        {
            this.readSpeed = readSpeed;
            this.writeSpeed = writeSpeed;
            this.connectionType = connectionType;
            this.identifier = identifier;
            this.size = size;
        }
        override public void PrintInfo()
        {
            Console.WriteLine("Type: " + GetType().Name);
            Console.WriteLine("Spaced: " + actCapacity + "/" + capacity);
            Console.WriteLine("Speed: write-" + writeSpeed + " read-" + readSpeed);
            Console.WriteLine("Identifier: " + identifier);
            Console.WriteLine("Size of drive: " + size);
        }
        virtual public void WriteInfo(int info)
        {
            actCapacity += info;
            Console.WriteLine("To " + GetType().Name + " added " + info + " bytes");
        }
        virtual public void DeleteInfo(int info)
        {
            actCapacity -= info;
            Console.WriteLine("From " + GetType().Name + " deleted " + info + " bytes");
        }
        virtual public void InsertDrive()
        {
            Console.WriteLine("Drive " + GetType().Name + " was inserted");
        }
        virtual public void RemoveDrive()
        {
            Console.WriteLine("Drive " + GetType().Name + " was removed");
        }
    }
    class WebStorage : Storage
    {
        protected int identifier { get; }
        public int downloadSpeed { get; }
        public int loadSpeed { get; }
        public string connectionType { get; }
        protected string servername { get; set; }
        public WebStorage(int capacity, string owner, int downloadSpeed, int loadSpeed, string connectionType, int identifier, string servername) : base(capacity, owner)
        {
            this.loadSpeed = loadSpeed;
            this.downloadSpeed = downloadSpeed;
            this.connectionType = connectionType;
            this.identifier = identifier;
            this.servername = servername;
        }
        override public void PrintInfo()
        {
            Console.WriteLine("Type: " + GetType().Name);
            Console.WriteLine("Spaced: " + actCapacity + "/" + capacity);
            Console.WriteLine("Speed: download-" + downloadSpeed + " load-" + loadSpeed);
            Console.WriteLine("Identifier: " + identifier);
            Console.WriteLine("Servername: " + servername);
        }
        virtual public void WriteInfo(int info)
        {
            actCapacity += info;
            Console.WriteLine("To " + GetType().Name + " added " + info + " bytes");
        }
        virtual public void DeleteInfo(int info)
        {
            actCapacity -= info;
            Console.WriteLine("From " + GetType().Name + " deleted " + info + " bytes");
        }
        virtual public void DownloadInfo()
        {
            Console.WriteLine("From " + GetType().Name + " was downloaded info");
        }
        virtual public void LoadInfo()
        {
            Console.WriteLine("To " + GetType().Name + " was loaded info");
        }
    }

}
