using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string remoteAddressForTheFile = "http://www.aop.bg/fckedit2/user/File/bg/obraztzi/PFE_20161108_DOT_NET.zip";
        string filename = "filename.zip";
        WebClient myWebClient = new WebClient();
        myWebClient.DownloadFile(remoteAddressForTheFile, filename);
    }
}
