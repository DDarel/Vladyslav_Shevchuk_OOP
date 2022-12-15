
namespace Variant_1
{
    abstract class Storage
    {
        protected int actCapacity { get; set; } = 0;
        public string owner { get; set; }
        protected int capacity { get; }
        public Storage(int capacity, string owner)
        {
            this.capacity = capacity;
            this.owner = owner;
        }
        abstract public void PrintInfo();
    }
}
