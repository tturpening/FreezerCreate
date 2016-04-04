using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreezerCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            // FV3 A1-13   EA4 A1-13
            // FV3 B1-13   EA4 B1-13
            // V3	D1-7  EA4	D1-7
            //  FV4 J1  EA4 A14

            int cnt = 0;
            string[][] freezer = new string[4][];
            freezer[cnt++] = new string[] { "FV3", "A1-13", "EA4", "A1-13" };
            freezer[cnt++] = new string[] { "FV3", "B1-13", "EA4", "B1-13" };
            freezer[cnt++] = new string[] { "V3", "D1", "EA4", "D1" };
            freezer[cnt++] = new string[] { "FV4", "J1", "EA4", "A14" };

            string parm1, parm2, parm3, parm4;

            System.Diagnostics.Debug.WriteLine("Start time: " + DateTime.Now.ToString());

            foreach (var _frz in freezer.Select((x, i) => new { Value = x, Index = i }))
            {
                cnt = 0;
                parm1 = freezer[_frz.Index][cnt++];
                parm2 = createBoxes(freezer[_frz.Index][cnt].Substring(0, 1), freezer[_frz.Index][cnt].Substring(1));
                cnt++;
                parm3 = freezer[_frz.Index][cnt++];
                parm4 = createBoxes(freezer[_frz.Index][cnt].Substring(0, 1), freezer[_frz.Index][cnt].Substring(1));

                System.Diagnostics.Debug.Write(parm1 + "; " + parm2 + "; " + parm3 + "; " + parm4);
                System.Diagnostics.Debug.WriteLine("");
            }
        }

        static public string createBoxes(string boxName, string boxCnt)
        {
            var separator = new[] { '-' };
            StringBuilder sb = new StringBuilder();
            string[] boxCntArr = boxCnt.Split(separator);

            if (boxCntArr.Length == 1)
                sb.Append(boxName + boxCntArr[0]);
            else
            {
                for (int i = Convert.ToInt32(boxCntArr[0]); i <= Convert.ToInt32(boxCntArr[1]); i++)
                {
                    sb.Append(boxName + i.ToString() + ",");
                }
            }
            return sb.ToString();
        }
    }
}