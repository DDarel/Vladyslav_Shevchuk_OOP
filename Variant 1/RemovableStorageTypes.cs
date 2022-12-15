
namespace Variant_1
{
    class CDDisk : RemovableStorage
    {
        public bool isReusable { get; set; }
        public CDDisk(int capacity, string owner, int writeSpeed, int readSpeed, string connectionType, int identifier, int size, bool isReusable) : base(capacity, owner, writeSpeed, readSpeed, connectionType, identifier, size)
        {
            this.isReusable = isReusable;
        }
        public override void WriteInfo(int info)
        {
            Console.WriteLine("---Overrided---");
            base.WriteInfo(info);
        }
        public override void DeleteInfo(int info)
        {
            Console.WriteLine("---Overrided---");
            base.DeleteInfo(info);
        }
        public override void InsertDrive()
        {
            Console.WriteLine("---Overrided---");
            base.InsertDrive();
        }
        public override void RemoveDrive()
        {
            Console.WriteLine("---Overrided---");
            base.RemoveDrive();
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("CDRW: " + isReusable);
        }
    }

    class FlashDrive : RemovableStorage
    {
        public bool isPrivate { get; set; }
        public FlashDrive(int capacity, string owner, int writeSpeed, int readSpeed, string connectionType, int identifier, int size, bool isPrivate) : base(capacity, owner, writeSpeed, readSpeed, connectionType, identifier, size)
        {
            this.isPrivate = isPrivate;
        }
        public override void WriteInfo(int info)
        {
            Console.WriteLine("---Overrided---");
            base.WriteInfo(info);
        }
        public override void DeleteInfo(int info)
        {
            Console.WriteLine("---Overrided---");
            base.DeleteInfo(info);
        }
        public override void InsertDrive()
        {
            Console.WriteLine("---Overrided---");
            base.InsertDrive();
        }
        public override void RemoveDrive()
        {
            Console.WriteLine("---Overrided---");
            base.RemoveDrive();
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Private: " + isPrivate);
        }
    }

    class EHD : RemovableStorage
    {
        public bool isWired { get; }
        public EHD(int capacity, string owner, int writeSpeed, int readSpeed, string connectionType, int identifier, int size, bool isWired) : base(capacity, owner, writeSpeed, readSpeed, connectionType, identifier, size)
        {
            this.isWired = isWired;
        }
        public override void WriteInfo(int info)
        {
            Console.WriteLine("---Overrided---");
            base.WriteInfo(info);
        }
        public override void DeleteInfo(int info)
        {
            Console.WriteLine("---Overrided---");
            base.DeleteInfo(info);
        }
        public override void InsertDrive()
        {
            Console.WriteLine("---Overrided---");
            base.InsertDrive();
        }
        public override void RemoveDrive()
        {
            Console.WriteLine("---Overrided---");
            base.RemoveDrive();
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Wired: " + isWired);
        }
    }
}
