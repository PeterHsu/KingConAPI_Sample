using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KingConAPIClient2
{
    internal static class KingConAPI
    {
        [DllImport("kingcon_api.dll")]
        private static extern void send_cache_order(byte[] msg);

        public static void SendCacheOrder(string xml)
        {
            Task.Run(() => {
                byte[] xmlUtf8 = Encoding.UTF8.GetBytes(xml);
                send_cache_order(xmlUtf8);
            });
        }
    }
}
