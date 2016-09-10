using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckAvability.Common;
namespace CheckAvability.Model
{
    public class IphonePlusAvalibilityInStore
    {
        public string StoreName { get; set; }
        public string 大細機 { get; set; }
        public string 一二八亮黑 { get; set; } // MN4D2ZP
        public string 二五六亮黑 { get; set; } //MN4L2ZP
        public string 三十二金 { get; set; } //MNQK2ZP
        public string 一二八金 { get; set; } //MN4A2ZP
        public string 二五六金 { get; set; } //MN4J2ZP
        public string 三十二玫金 { get; set; } //MNQL2ZP
        public string 一二八玫金 { get; set; } //MN4C2ZP
        public string 二五六玫金 { get; set; } //MN4K2ZP
        public string 三十二黑 { get; set; } //MNQH2ZP
        public string 一二八黑 { get; set; } //MN482ZP
        public string 二五六黑 { get; set; } //MN4E2ZP
        public string 三十二銀 { get; set; } //MNQJ2ZP
        public string 一二八銀 { get; set; } //MN492ZP
        public string 二五六銀 { get; set; } //MN4F2ZP

        public IphonePlusAvalibilityInStore(string _storeName)
        {
            this.StoreName = Shop.GetShopName(_storeName);
        }
    }
}
