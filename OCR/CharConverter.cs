using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    class CharConverter
    {
        /// <summary>
        /// Convert binary array to hex code array.
        /// </summary>
        /// <param name="binAry"></param>
        /// <returns></returns>
        private static string[] Encode(string[] binAry)
        {
            string[] hexCode = new string[binAry.Length];
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < binAry.Length; i++)
            {
                for (int j = binAry[i].Length - 1; j >= 0; j--)
                {
                    if (counter == 4)
                    {
                        hexCode[i] = sum.ToString("X") + hexCode[i];
                        // Reset
                        counter = 0;
                        sum = 0;
                    }
                    if (binAry[i][j] == 1)
                    {
                        sum += (int)Math.Pow(2, counter);
                    }
                    counter++;
                }
            }
            return hexCode;
        }
    }
}
