using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckAvability.Model;
using CheckAvability.Entities;
using CheckAvability.Model;
namespace CheckAvability.Common
{
    public class IphonePlusMapper
    {
        public static IEnumerable<IphonePlus> IphonePlusMapToDbEntities(List<IphonePlusAvalibilityInStore> inputs)
        {
            List<IphonePlus> outout = new List<IphonePlus>();
            foreach(var input in inputs)
            {
                if (input.一二八亮黑 != "NONE")
                {
                    outout.Add(new IphonePlus
                    {
                        StoreName = input.StoreName,
                        Model = input.一二八亮黑,
                        createTime = DateTime.Now
                    });
                }
                if (input.二五六亮黑 != "NONE")
                {
                    outout.Add(new IphonePlus
                    {
                        StoreName = input.StoreName,
                        Model = input.二五六亮黑,
                        createTime = DateTime.Now
                    });
                }

                if (input.三十二金 != "NONE")
                {
                    outout.Add(new IphonePlus
                    {
                        StoreName = input.StoreName,
                        Model = input.三十二金,
                        createTime = DateTime.Now
                    });
                }
                if (input.三十二銀 != "NONE")
                {
                    outout.Add(new IphonePlus
                    {
                        StoreName = input.StoreName,
                        Model = input.三十二銀,
                        createTime = DateTime.Now
                    });
                }
                if (input.三十二黑 != "NONE")
                {
                    outout.Add(new IphonePlus
                    {
                        StoreName = input.StoreName,
                        Model = input.三十二黑,
                        createTime = DateTime.Now
                    });
                }
                if (input.三十二玫金 != "NONE")
                {
                    outout.Add(new IphonePlus
                    {
                        StoreName = input.StoreName,
                        Model = input.三十二玫金,
                        createTime = DateTime.Now
                    });
                }


                if (input.一二八金 != "NONE")
                {
                    outout.Add(new IphonePlus
                    {
                        StoreName = input.StoreName,
                        Model = input.三十二金,
                        createTime = DateTime.Now
                    });
                }
                if (input.一二八銀 != "NONE")
                {
                    outout.Add(new IphonePlus
                    {
                        StoreName = input.StoreName,
                        Model = input.三十二銀,
                        createTime = DateTime.Now
                    });
                }
                if (input.一二八黑 != "NONE")
                {
                    outout.Add(new IphonePlus
                    {
                        StoreName = input.StoreName,
                        Model = input.三十二黑,
                        createTime = DateTime.Now
                    });
                }
                if (input.一二八玫金 != "NONE")
                {
                    outout.Add(new IphonePlus
                    {
                        StoreName = input.StoreName,
                        Model = input.三十二玫金,
                        createTime = DateTime.Now
                    });
                }

                if (input.二五六金 != "NONE")
                {
                    outout.Add(new IphonePlus
                    {
                        StoreName = input.StoreName,
                        Model = input.三十二金,
                        createTime = DateTime.Now
                    });
                }
                if (input.二五六銀 != "NONE")
                {
                    outout.Add(new IphonePlus
                    {
                        StoreName = input.StoreName,
                        Model = input.三十二銀,
                        createTime = DateTime.Now
                    });
                }

                if (input.二五六黑 != "NONE")
                {
                    outout.Add(new IphonePlus
                    {
                        StoreName = input.StoreName,
                        Model = input.三十二黑,
                        createTime = DateTime.Now
                    });
                }
                if (input.二五六玫金 != "NONE")
                {
                    outout.Add(new IphonePlus
                    {
                        StoreName = input.StoreName,
                        Model = input.三十二玫金,
                        createTime = DateTime.Now
                    });
                }
            }
            return outout;
        }
    }
}
