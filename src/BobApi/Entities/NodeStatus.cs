using System.Collections.Generic;

namespace BobApi.Entities
{
    public struct Node
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<VDisk> VDisks { get; set; }
    }
}
