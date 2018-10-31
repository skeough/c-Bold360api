using System;

namespace csharp_b360_api {
    class Hashing {
        public static string SHA512 (string aid, string sid, string key) {

            var time = DateTimeOffset.Now.ToUnixTimeMilliseconds ().ToString ();

            var bytes = System.Text.Encoding.UTF8.GetBytes (aid + ":" + sid + ":" + time + key);

            using (var hash = System.Security.Cryptography.SHA512.Create ()) {
                var hashedBytes = hash.ComputeHash (bytes);

                var hashedStringBuilder = new System.Text.StringBuilder (128);
                foreach (var b in hashedBytes) hashedStringBuilder.Append (b.ToString ("X2"));
                var hashstring = aid + ":" + sid + ":" + time + ":" + hashedStringBuilder;

                return hashstring.ToString ();
            }
        }
    }
}