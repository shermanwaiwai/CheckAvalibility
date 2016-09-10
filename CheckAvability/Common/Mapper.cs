using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckAvability.Model;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
namespace CheckAvability.Common
{
    public class Mapper
    {
        public static IphoneAvalibilityInStore IphoneMapping(string storename, string input )
        {
            var jobject = JObject.Parse(input);
            IphoneAvalibilityInStore temp = new IphoneAvalibilityInStore(storename);
            temp.大細機 = "細機";
            temp.一二八亮黑 = jobject["MN8Q2ZP/A"].ToString();
            temp.二五六亮黑 = jobject["MN8W2ZP/A"].ToString();
            temp.三十二金 = jobject["MN8J2ZP/A"].ToString();
            temp.一二八金 = jobject["MN8N2ZP/A"].ToString();
            temp.二五六金 = jobject["MN8U2ZP/A"].ToString();
            temp.三十二玫金 = jobject["MN8K2ZP/A"].ToString();
            temp.一二八玫金 = jobject["MN8P2ZP/A"].ToString();
            temp.二五六玫金 = jobject["MN8V2ZP/A"].ToString();
            temp.三十二黑 = jobject["MN8G2ZP/A"].ToString();
            temp.一二八黑 = jobject["MN8L2ZP/A"].ToString();
            temp.二五六黑 = jobject["MN8R2ZP/A"].ToString();
            temp.三十二銀 = jobject["MN8H2ZP/A"].ToString();
            temp.一二八銀 = jobject["MN8M2ZP/A"].ToString();
            temp.二五六銀 = jobject["MN8T2ZP/A"].ToString();
            return temp;
        }
        
        public static IphonePlusAvalibilityInStore IphonePlusMapping(string storename, string input)
        {
            var jobject = JObject.Parse(input);
            IphonePlusAvalibilityInStore temp = new IphonePlusAvalibilityInStore(storename);
            temp.大細機 = "大機";
            temp.一二八亮黑 = jobject["MN4D2ZP/A"].ToString();
            temp.二五六亮黑 = jobject["MN4L2ZP/A"].ToString();
            temp.三十二金 = jobject["MNQK2ZP/A"].ToString();
            temp.一二八金 = jobject["MN4A2ZP/A"].ToString();
            temp.二五六金 = jobject["MN4J2ZP/A"].ToString();
            temp.三十二玫金 = jobject["MNQL2ZP/A"].ToString();
            temp.一二八玫金 = jobject["MN4C2ZP/A"].ToString();
            temp.二五六玫金 = jobject["MN4K2ZP/A"].ToString();
            temp.三十二黑 = jobject["MNQH2ZP/A"].ToString();
            temp.一二八黑 = jobject["MN482ZP/A"].ToString();
            temp.二五六黑 = jobject["MN4E2ZP/A"].ToString();
            temp.三十二銀 = jobject["MNQJ2ZP/A"].ToString();
            temp.一二八銀 = jobject["MN492ZP/A"].ToString();
            temp.二五六銀 = jobject["MN4F2ZP/A"].ToString();
            return temp;
        }


        //temp.MN8V2ZP = jobject["MN8M2ZP/A"].ToString();
        //temp.MN8G2ZP = jobject["MN8G2ZP/A"].ToString();
        //temp.MN492ZP = jobject["MN492ZP/A"].ToString();
        //temp.MNQK2ZP = jobject["MNQK2ZP/A"].ToString();
        //temp.MN8N2ZP = jobject["MN8N2ZP/A"].ToString();
        //temp.MN8Q2ZP = jobject["MN8Q2ZP/A"].ToString();
        //temp.MN4L2ZP = jobject["MN4L2ZP/A"].ToString();
        //temp.MN8K2ZP = jobject["MN8K2ZP/A"].ToString();
        //temp.MN4F2ZP = jobject["MN4F2ZP/A"].ToString();
        //temp.MN8U2ZP = jobject["MN8U2ZP/A"].ToString();
        //temp.MN8R2ZP = jobject["MN8R2ZP/A"].ToString();
        //temp.MNQJ2ZP = jobject["MNQJ2ZP/A"].ToString();
        //temp.MN8H2ZP = jobject["MN8H2ZP/A"].ToString();
        //temp.MN4C2ZP = jobject["MN4C2ZP/A"].ToString();
        //temp.MN4D2ZP = jobject["MN4D2ZP/A"].ToString();
        //temp.MN4J2ZP = jobject["MN4J2ZP/A"].ToString();
        //temp.MN4A2ZP = jobject["MN4A2ZP/A"].ToString();
        //temp.MN8L2ZP = jobject["MN8L2ZP/A"].ToString();
        //temp.MN8T2ZP = jobject["MN8T2ZP/A"].ToString();
        //temp.MNQH2ZP = jobject["MNQH2ZP/A"].ToString();
        //temp.MN8W2ZP = jobject["MN8W2ZP/A"].ToString();
        //temp.MN4E2ZP = jobject["MN4E2ZP/A"].ToString();
        //temp.MN8J2ZP = jobject["MN8J2ZP/A"].ToString();
        //temp.MN8M2ZP = jobject["MN8M2ZP/A"].ToString();
        //temp.MN4K2ZP = jobject["MN4K2ZP/A"].ToString();
        //temp.MN482ZP = jobject["MN482ZP/A"].ToString();
        //temp.MNQL2ZP = jobject["MNQL2ZP/A"].ToString();
        //temp.MN8P2ZP = jobject["MN8P2ZP/A"].ToString();
    }
}
