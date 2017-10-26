using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Features_5
{
    public class AsynchronousMethods
    {
        async Task<int> AccessTheWebAsync()
        {

            HttpClient client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync("http://www.nba.com");
            //DoSomething(); Farklı methodları vs cagirabilirsiniz. 
            string urlContents = await getStringTask;
            return urlContents.Length;
        }        

        async void WorkTasks()
        {
            int contentLength = await AccessTheWebAsync();
            var text = String.Format("\r\nLength of the downloaded string: {0}.\r\n", contentLength);
        }

        public AsynchronousMethods()
        {
            WorkTasks();
        }

    }





}
