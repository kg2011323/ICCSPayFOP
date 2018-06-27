using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlatformLib.Vo
{
    /// <summary>
    /// 微信用户OpenID查询响应
    /// </summary>
    public class WXUserOpenIDRespVo : DeviceCommRespondBaseVo
    {
        /// <summary>
        /// 用户OpenID
        /// </summary>
        public string userAccount;
    }
}
