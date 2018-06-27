using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlatformLib.Vo
{
    /// <summary>
    /// 微信用户OpenID查询请求
    /// </summary>
    public class WXUserOpenIDReqVo:DeviceCommRequestBaseVo
    {
        /// <summary>
        /// 随机因子
        /// </summary>
        public string randomFact;
    }
}
