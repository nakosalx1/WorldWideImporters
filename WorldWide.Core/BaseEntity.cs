using System;

namespace WorldWide.Core
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
