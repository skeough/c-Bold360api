using System;
using System.Net;

namespace csharp_b360_api
{
    public class DataCall
    {
        public static string CallResponse(string method, string parameters){
            var client = new WebClient();
            string url = "https://"+Account.us_end+"/aid/"+Account.aid+"/data/rest/json/v2/";
            var hash = Hashing.SHA512(Account.aid,Account.sid,Account.key);
            Console.WriteLine(hash);
            url = url+method+"?auth="+hash;
            if (parameters.Length>0){
                url += "&"+parameters;
            }
            var response = client.DownloadString(url);
            return response;
        }
    }
}