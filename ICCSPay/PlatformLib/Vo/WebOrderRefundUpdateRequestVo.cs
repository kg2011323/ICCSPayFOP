﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlatformLib.Vo
{
    /// <summary>
    /// 网络订单退款记录更行请求
    /// </summary>
    public class WebOrderRefundUpdateRequestVo
    {
        /// <summary>
        /// 后台订单号（商户订单号）
        /// </summary>
        public string TradeNo;
        /// <summary>
        /// 外部订单号
        /// </summary>
        public string ExternalTradeNo;
        /// <summary>
        /// 退款订单号
        /// </summary>
        public string RefundTradeNo;
        ///// <summary>
        ///// 退款原因，单位为分
        ///// </summary>
        //public string RefundReason;
        ///// <summary>
        ///// 订单总金额，单位为分
        ///// </summary>
        //public int RefundFee;
        ///// <summary>
        ///// 退款请求时间
        ///// </summary>
        //public DateTime RequestTime;
        ///// <summary>
        ///// 退款请求成功标识
        ///// </summary>
        //public bool IsRequestSuccess;
        ///// <summary>
        ///// 退款请求异常描述
        ///// </summary>
        //public string RequestErrCodeDes;
        /// <summary>
        /// 退款成功标识
        /// </summary>
        public bool IsRespondSuccess;
        /// <summary>
        /// 退款请求响应时间
        /// </summary>
        public DateTime? RespondTime;
        /// <summary>
        /// 退款响应异常描述
        /// </summary>
        public string RespondErrCodeDes;
        /// <summary>
        /// 订单状态
        /// </summary>
        public OrderStatusType OrderStatus;
    }
}
