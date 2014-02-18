﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiHaoOA.DataContract
{
    public struct OrderStatus
    {
        public const string Following = "正跟踪";
        public const string Submitted = "已提交";
        public const string Discard = "已放弃";
    }

    public struct InformationAssistantLevels
    {
        public const string Iron = "铁";
        public const string Copper = "铜";
        public const string Silver = "银";
        public const string Gold = "金";
    }

    public struct ManagerChildMenu
    {
        public const string UnSubordinateIA = "未隶属信息员";
        public const string UnSubordinateCustomer = "未隶属客户";
        public const string InformationAssistantAList = "信息员列表";
        public const string CustomerList = "客户列表";
        public const string DeleteIA = "被删除的信息员";
        public const string DeleteCustomer = "被删除的客户列表";
        public const string MarketReturnBackList = "市场打回列表";
        public const string MySubordinate = "我的下属";
    }

    public struct VisitType
    {
        public const string type_InformationAssistant = "InformationAssistant";
        public const string type_Customer = "Customer";
    }
}