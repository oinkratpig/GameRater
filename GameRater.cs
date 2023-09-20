using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRater
{
    public static class GameRater
    {
        public static readonly string? PATH_RELATIVE = Path.GetDirectoryName(Application.ExecutablePath) + @"\";
        public static readonly string PATH_EXPORT = PATH_RELATIVE + "export.txt";
        public static readonly string PATH_GAMES = PATH_RELATIVE + "games.json";

        /*
        /// <summary>
        /// Encode a string as Base64.
        /// </summary>
        public static string Base64Encode(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(bytes);

        } // end Base64Encode

        /// <summary>
        /// Decode Base64 as a string.
        /// </summary>
        public static string Base64Decode(string encodedString)
        {
            byte[] bytes = Convert.FromBase64String(encodedString);
            return Encoding.UTF8.GetString(bytes);

        } // end Base64Decode
        */

    } // end class GameRater

} // end namespace