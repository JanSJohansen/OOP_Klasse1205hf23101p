using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalsysConverter
{
    internal class TalsysConv
    {
        public static String IntToDec(int tal)
        {
            String decStr = "";

            int temp = tal;

            while(temp > 0)
            {
                int cif = temp % 10;
                char cifChar = (char)(cif + 0x30);
                decStr = cifChar + decStr;
                temp = temp / 10;
            }
            return decStr;
        }

        internal static string IntToBin(int tal)
        {
            String binStr = "";

            int temp = tal;

            while (temp > 0)
            {
                int cif = temp % 2;
                char cifChar = (char)(cif + 0x30);
                binStr = cifChar + binStr;
                temp = temp / 2;
            }
            return binStr;
        }

        internal static string IntToHex(int tal)
        {
            String hexStr = "";

            int temp = tal;

            char cifChar = (char)0;

            while (temp > 0)
            {
                int cif = temp % 16;
                if(cif < 10)
                {
                    cifChar = (char)(cif + 0x30);
                }
                if (cif >= 10)
                {
                    cifChar = (char)(cif + 0x31);
                }
                
                hexStr = cifChar + hexStr;
                temp = temp / 16;
            }
            return hexStr;

        }
    }


}
