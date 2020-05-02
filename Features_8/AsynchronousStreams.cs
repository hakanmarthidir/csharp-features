using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Features_8
{

    //IAsyncDisposable and AsyncStreams

    class PageContent : IAsyncDisposable, IDisposable
    {
        private bool disposed = false;        

        public int PageNumber { get; set; }
        public string Content { get; set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //there is no other objects to dispose
                }

                disposed = true;
            }                    

        }

        public virtual ValueTask DisposeAsync()
        {
            try
            {
                Dispose();
                return default;
            }
            catch (Exception exception)
            {
                return new ValueTask(Task.FromException(exception));
            }
        }

        ~PageContent()
        {
            Dispose(false);
        }
    }


    //Asynchronous Streams 
    // 1. async method 
    // 2. return value has to be System.Collections.Generic.IAsyncEnumerable<T>
    // 3. yield return for sequental values
    // 4. await keyword before every enumerable element
    public class AsynchronousStreams
    {
        List<PageContent> pageList = new List<PageContent>();

        public AsynchronousStreams()
        {
            pageList.Add(new PageContent() { PageNumber = 1, Content = "sdkfsd aaaaaaaa s sldkfjsd fslkdjf" });
            pageList.Add(new PageContent() { PageNumber = 2, Content = "sdkfsd bbbbbbbb s sldkfjsd fslkdjf" });
            pageList.Add(new PageContent() { PageNumber = 3, Content = "sdkfsd cccccccc s sldkfjsd fslkdjf" });
            pageList.Add(new PageContent() { PageNumber = 4, Content = "sdkfsd dddddddd s sldkfjsd fslkdjf" });
            pageList.Add(new PageContent() { PageNumber = 5, Content = "sdkfsd eeeeeeee s sldkfjsd fslkdjf" });
        }

        //also you can implement
        //ConfigureAwait
        //CancelationToken
        public async System.Collections.Generic.IAsyncEnumerable<string> GetFirstThreeContentsAsStream()
        {

            foreach (var item in this.pageList)
            {
                if (item.PageNumber <= 3)
                {
                    await Task.Delay(100);
                    yield return item.Content;
                }
            }
        }
    }
}