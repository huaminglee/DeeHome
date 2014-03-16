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
        public const string SubmittedNotAllowedForMarketing = "市场部经理审批提交不准";
        public const string SubmittedNotAllowedForDesign = "设计部经理审批提交不准";
        public const string SubmittedNotSigned = "提交未签";
        public const string SubmittedNotSignedForMarketing = "市场部经理审批提交未签";
        public const string SubmittedNotSignedForDesign = "设计部经理审批提交未签";
        public const string SubmittedSigned = "提交已签";
        public const string SubmittedSignedForMarketing = "市场部经理审批提交已签";
        public const string SubmittedSignedForDesign = "设计部经理审批提交已签";
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
        public const string type_Desinger = "Designer";
    }

    public struct Roles
    {
        public const string InformationAssistant = "InformationAssistant";
        public const string DesignerLeader = "DesignerLeader";
        public const string Designer = "Designer";
    }

    public struct Approvaler
    {
        public const string DesignerManager = "DesignerManager";
        public const string MarketingManager = "MarketingManager";
        public const string SalesMan = "SalesMan";
    }

    public struct SubmittedBy
    {
        public const string DesignerManager = "DesignerManager";
        public const string MarketingManager = "MarketingManager";
        public const string SalesMan = "SalesMan";
        public const string Designer = "Designer";
    }
}   
