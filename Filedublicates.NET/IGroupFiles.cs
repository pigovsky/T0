using System;
namespace Filedublicates.NET
{
    interface IGroupFiles
    {
        void AddFile(System.IO.FileInfo file);
        TimeSpan elapsed { get; }
    }
}
