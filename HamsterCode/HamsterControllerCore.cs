using System;
using System.Collections.Generic;
using System.Text;

namespace HamsterCode
{
    public delegate string HamsterCoreDelegate(string logistics_interface);
    public class HamsterCore
    {
        public List<HamsterCoreDelegate> lst_myDelegate { set; get; }

        public HamsterCore()
        {
            lst_myDelegate = new List<HamsterCoreDelegate>();
            lst_myDelegate.Add(HelloWordCore.Instance.HelloWordVoid);
            //新逻辑审核
            //lst_myDelegate.Add(WmsReleaseCore.Instance.ReleaseOrderNo_New);
            ////新逻辑合并
            //lst_myDelegate.Add(new MergoOrderCore().MergoPicking);
            ////新逻辑取消合并
            //lst_myDelegate.Add(new MergoOrderCore().CannelOrderMerge);
            ////查询订单信息
            //lst_myDelegate.Add(new OutStockOrderCore().FindOrderModelList);
            //原有逻辑审核
            //lst_myDelegate.Add(WmsReleaseCore.Instance.ReleaseOrder);
        }
    }
}
