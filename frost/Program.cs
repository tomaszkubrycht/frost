using CoreFtp;
using System;
using System.IO;
using System.Threading.Tasks;
using CsvHelper;

namespace frost
{
    class Program
    {

        public Int64 parameter;
        public class dane {
             record Record = new record();
            public async void FtpString()
            {
                using (var ftpClient = new FtpClient(new FtpClientConfiguration
                {
                    Host = "ftp.kubrycht.com.pl",
                    Username = "frost1",
                    Password = "Frost1"
                }))
                {
                    
                    var tempFile = new FileInfo("ERICSUNIT073430.csv");
                    await ftpClient.LoginAsync();
                    using (var ftpReadStream = await ftpClient.OpenFileReadStreamAsync("ERICSUNIT073430.csv"))
                    {
                        
                        using (var fileWriteStream = tempFile.OpenWrite())
                        {
                            await ftpReadStream.CopyToAsync(fileWriteStream);
                            var parser =new  CsvParser(tempFile)
                            
                            // Console.Write(ft);
                        
                        
                        }
                    }
                }
                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            dane data = new dane();
            data.FtpString();
            Console.ReadKey();
        }

        public Int64 rect()
        {
            parameter = 1;
            return parameter;
        }
        dynamic ReadCSV(string test)
        {
            return test;
        }
    }
}/