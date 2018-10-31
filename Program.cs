using System;
using System.Net;

namespace csharp_b360_api
{
    class Program {
        static void Main(string[] args) {
            
            var response = DataCall.CallResponse("getEmailThreads","FolderID=4112967444619974235");
            
            Console.WriteLine(response);    
        }
    }
}
