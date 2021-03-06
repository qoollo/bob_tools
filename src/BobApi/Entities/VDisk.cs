using System.Collections.Generic;

namespace BobApi.Entities
{
    public struct VDisk
    {
        public int Id { get; set; }
        public List<Replica> Replicas { get; set; }

        public override string ToString()
        {
            return $"VDisk {Id}";
        }
    }
}
