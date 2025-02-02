
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace Tinthanh.App.General
{

    public static class Dungchung
    {
        public static string un;
        public static string Version = "";
        public static string Sinhmadoituong(string loaidt, int Dodai)
        {
            var result= SQLHelper.ExecQuerySacalar("select dbo.fn_Sinhmadoituong(@loaidt,@dodai)", new { loaidt, Dodai }).ToString();
             return result?.ToString() ?? string.Empty;
        }

        public static string Getversion()
        {
            var result = SQLHelper.ExecQuerySacalar(@"Select top 1 Version from Hethong");
            return result?.ToString() ?? string.Empty;
        }
        public static string GetConnectionString()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                           .SetBasePath(Directory.GetCurrentDirectory())
                           .AddJsonFile("appsettings.json")
                           .Build();
            var result= configuration.GetConnectionString("TinthanhDb");
            return result?.ToString() ?? string.Empty;
        }


        public static string GenerateMD5(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        public static DateTime Ngaydauthang(int thang, int Nam)
        {
            DateTime dtResult = new DateTime(Nam, thang, 1);
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }

        public static DateTime Ngaycuoithang(int thang, int Nam)
        {
            DateTime dtResult = new DateTime(Nam, thang, 1);
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }

        public static DateTime Ngaydaunam(int Nam)
        {
            return new DateTime(Nam, 1, 1);

        }

        public static DateTime Ngaycuoinam(int Nam)
        {
            return new DateTime(Nam, 12, 31);
        }

        public static DateTime Ngaydauquy(int quy, int Nam)
        {

            return new DateTime(Nam, (quy - 1) * 3 + 1, 1);

        }

        public static DateTime Ngaycuoiquy(int quy, int Nam)
        {

            var firstDayOfQuarter = new DateTime(Nam, (quy - 1) * 3 + 1, 1);

            return firstDayOfQuarter.AddMonths(3).AddDays(-1);


        }

        public static int GetQuater(DateTime Ngay)
        {
            int t = Ngay.Month;
            int q;
            if (t >= 1 && t <= 3) q = 1;
            else if (t >= 4 && t <= 6) q = 2;
            else if (t >= 7 && t <= 9) q = 3;
            else q = 4;

            return q;



        }
    }
}
