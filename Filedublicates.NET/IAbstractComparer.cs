using System;
namespace Filedublicates.NET
{
    public abstract class IAbstractComparer
    {
        abstract public void detectDuplicates();

        public SearchingDuplicates searchingDuplicatesProgressDialog { get; set; }
    }
}
