using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MineServer
{
    public static class MyServer
    {
        
            static int count;
            static ReaderWriterLock readerLock = new ReaderWriterLock();
            public static int GetCount()
            {
                readerLock.AcquireReaderLock(Timeout.InfiniteTimeSpan);
            try
            {
                return count;
            }
            finally 
            { 
                readerLock.ReleaseReaderLock(); 
            }

            }
            public static void AddToCount(int value)
            {
                readerLock.AcquireWriterLock(Timeout.InfiniteTimeSpan);
                count += value;
                readerLock.ReleaseWriterLock();
            }

        
    }
}
