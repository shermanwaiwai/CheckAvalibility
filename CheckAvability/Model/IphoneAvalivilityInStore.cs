using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckAvability.Common;
namespace CheckAvability.Model
{
    public class IphoneAvalibilityInStore
    {
        public string storeName { get; set; } //
        public string 大細機 { get; set; }
        public string 一二八亮黑 { get; set; } // MN8Q2ZP
        public string 二五六亮黑 { get; set; } //MN8W2ZP
        public string 三十二金 { get; set; } //MN8J2ZP
        public string 一二八金 { get; set; } //MN8N2ZP
        public string 二五六金 { get; set; } //MN8U2ZP
        public string 三十二玫金 { get; set; } //MN8K2ZP
        public string 一二八玫金 { get; set; } //MN8P2ZP
        public string 二五六玫金 { get; set; } //MN8V2ZP
        public string 三十二黑 { get; set; } //MN8G2ZP
        public string 一二八黑 { get; set; } //MN8L2ZP
        public string 二五六黑 { get; set; } //MN8R2ZP
        public string 三十二銀 { get; set; } //MN8H2ZP
        public string 一二八銀 { get; set; } //MN8M2ZP
        public string 二五六銀 { get; set; } //MN8T2ZP

        public IphoneAvalibilityInStore(string _storename)
        {
            this.storeName = Shop.GetShopName(_storename);
        }
        
    }
}
