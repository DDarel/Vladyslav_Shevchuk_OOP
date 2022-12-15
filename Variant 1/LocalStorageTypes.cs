
namespace Variant_1
{
    class HDD : LocalStorage
    {
        private bool isLoud { get; set; }
        public HDD(int capacity, string owner, int writeSpeed, int readSpeed, string connectionType, int identifier, bool isLoud) : base(capacity, owner, writeSpeed, readSpeed, connectionType, identifier)
        {
            this.isLoud = isLoud;
        }
        public override void WriteInfo(int info)
        {
            base.WriteInfo(info);
        }
        public override void DeleteInfo(int info)
        {
            base.DeleteInfo(info);
        }
        override public void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Loud: " + isLoud);
        }
    }

    class SDD : LocalStorage
    {
        private string format { get; }
        public SDD(int capacity, string owner, int writeSpeed, int readSpeed, string connectionType, int identifier, string format) : base(capacity, owner, writeSpeed, readSpeed, connectionType, identifier)
        {
            this.format = format;
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
        override public void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Format: " + format);
        }
    }
}
