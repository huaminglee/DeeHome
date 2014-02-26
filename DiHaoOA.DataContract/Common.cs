using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiHaoOA.DataContract
{
    public struct OrderStatus
    {
        public const string Following = "正跟踪";
        public const string Submitted = "已提交";
        public const string Rejected = "被打回";
        public const string Discard = "已放弃";
        public const string ContinueFollowing = "继续跟踪";
        public const string SubmittedToDesigner = "提交单子";
        public const string OnChatting = "在谈";
        public const string SubmittedNotAllowed = "提交不准";
        public const string SubmittedNotSigned = "提交未签";
        public const string Signed = "已签";
        public const string NotSigned = "未签";
        public const string Denied = "不准";
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
        public const string Approval = "审批栏";
    }

    public struct VisitType
    {
        public const string type_InformationAssistant = "InformationAssistant";
        public const string type_Customer = "Customer";
    }

    public struct Approvaler
    {
        public const string DesignerManager = "DesignerManager";
        public const string MarketingManager = "MarketingManager";
    }
}   
