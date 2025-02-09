using FluentFTP;
using System;


namespace Tinthanh.App.General
{
   public  class FTP:IDisposable      
    {
        
       
        private string Host = "192.168.1.8";
        private string UserName = "ftp01";
        private string Pass = "ftp01@";
        private int Port = 21;


        FtpClient client;
        public FTP(string Thumuc)
        {
            client = new FtpClient(Host,UserName,Pass,Port);
            client.Connect();
            client.SetWorkingDirectory(Thumuc);


        }

        public void  UploadFile(string Filename,string RemoteFile)
        {
            client.UploadFile(Filename, RemoteFile,FtpRemoteExists.Overwrite,false,FtpVerify.None);
            
        }


        public void DownLoad(string FileName, string RemoteFile)
        {
            
            client.DownloadFile(FileName, RemoteFile,FtpLocalExists.Overwrite,FtpVerify.None);
        }
        public void Delete(string RemoteFile)
        {
            if (client.FileExists(RemoteFile))  
            client.DeleteFile(RemoteFile);
        }
        public void Dispose()
        {
            client.Disconnect();
            client.Dispose();
        }


    }
}
