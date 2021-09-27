﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inv.DAL.Domain
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class InvEntities : DbContext
    {
        public InvEntities()
            : base("name=InvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGRES> CATEGRES { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEE { get; set; }
        public virtual DbSet<Enter_Money> Enter_Money { get; set; }
        public virtual DbSet<familly_Cat> familly_Cat { get; set; }
        public virtual DbSet<G_AlertControl> G_AlertControl { get; set; }
        public virtual DbSet<G_AlertLog> G_AlertLog { get; set; }
        public virtual DbSet<G_AlertType> G_AlertType { get; set; }
        public virtual DbSet<G_BRANCH> G_BRANCH { get; set; }
        public virtual DbSet<G_Codes> G_Codes { get; set; }
        public virtual DbSet<G_COMPANY> G_COMPANY { get; set; }
        public virtual DbSet<G_CONTROL> G_CONTROL { get; set; }
        public virtual DbSet<G_COST_CENTER> G_COST_CENTER { get; set; }
        public virtual DbSet<G_Currency> G_Currency { get; set; }
        public virtual DbSet<G_ModuleHelp> G_ModuleHelp { get; set; }
        public virtual DbSet<G_MODULES> G_MODULES { get; set; }
        public virtual DbSet<G_Nationality> G_Nationality { get; set; }
        public virtual DbSet<G_News> G_News { get; set; }
        public virtual DbSet<G_Noteifications> G_Noteifications { get; set; }
        public virtual DbSet<G_NotificationCompany> G_NotificationCompany { get; set; }
        public virtual DbSet<G_PaperSize> G_PaperSize { get; set; }
        public virtual DbSet<G_REGION> G_REGION { get; set; }
        public virtual DbSet<G_REGION_BRANCH> G_REGION_BRANCH { get; set; }
        public virtual DbSet<G_ReportWebSetting> G_ReportWebSetting { get; set; }
        public virtual DbSet<G_Role> G_Role { get; set; }
        public virtual DbSet<G_RoleModule> G_RoleModule { get; set; }
        public virtual DbSet<G_RoleUsers> G_RoleUsers { get; set; }
        public virtual DbSet<G_SearchForm> G_SearchForm { get; set; }
        public virtual DbSet<G_SearchFormModule> G_SearchFormModule { get; set; }
        public virtual DbSet<G_SearchFormSetting> G_SearchFormSetting { get; set; }
        public virtual DbSet<G_STORE> G_STORE { get; set; }
        public virtual DbSet<G_SUB_SYSTEMS> G_SUB_SYSTEMS { get; set; }
        public virtual DbSet<G_SYSTEM> G_SYSTEM { get; set; }
        public virtual DbSet<G_TransCounter> G_TransCounter { get; set; }
        public virtual DbSet<G_TransCounterSetting> G_TransCounterSetting { get; set; }
        public virtual DbSet<G_USER_BRANCH> G_USER_BRANCH { get; set; }
        public virtual DbSet<G_USER_COMPANY> G_USER_COMPANY { get; set; }
        public virtual DbSet<G_USER_LOG> G_USER_LOG { get; set; }
        public virtual DbSet<G_USERS> G_USERS { get; set; }
        public virtual DbSet<I_Control> I_Control { get; set; }
        public virtual DbSet<ORDER_DELIVERY> ORDER_DELIVERY { get; set; }
        public virtual DbSet<Outlet> Outlet { get; set; }
        public virtual DbSet<PRODUCT> PRODUCT { get; set; }
        public virtual DbSet<Purchases_Details> Purchases_Details { get; set; }
        public virtual DbSet<Purchases_Master> Purchases_Master { get; set; }
        public virtual DbSet<Report_Parameters> Report_Parameters { get; set; }
        public virtual DbSet<Settings_Report> Settings_Report { get; set; }
        public virtual DbSet<Stok_ORDER_DELIVERY> Stok_ORDER_DELIVERY { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<Table_two_days> Table_two_days { get; set; }
        public virtual DbSet<The_Gard> The_Gard { get; set; }
        public virtual DbSet<GQ_GetUserBarnchAccess> GQ_GetUserBarnchAccess { get; set; }
        public virtual DbSet<GQ_GetUserBranch> GQ_GetUserBranch { get; set; }
        public virtual DbSet<GQ_GetUserModule> GQ_GetUserModule { get; set; }
        public virtual DbSet<GQ_GetUserRole> GQ_GetUserRole { get; set; }
        public virtual DbSet<GQ_GetUsers> GQ_GetUsers { get; set; }
        public virtual DbSet<GQ_Notifications> GQ_Notifications { get; set; }
        public virtual DbSet<GQ_ReportWebSetting> GQ_ReportWebSetting { get; set; }
        public virtual DbSet<IQ_Outlet> IQ_Outlet { get; set; }
        public virtual DbSet<IQ_Purchases_Details> IQ_Purchases_Details { get; set; }
        public virtual DbSet<IQ_Purchases_Master> IQ_Purchases_Master { get; set; }
        public virtual DbSet<ReviewSalesMaster> ReviewSalesMaster { get; set; }
        public virtual DbSet<HIJRA_CONVERT> HIJRA_CONVERT { get; set; }
        public virtual DbSet<I_VW_GetCompStatus> I_VW_GetCompStatus { get; set; }
        public virtual DbSet<ReviewSalesItemInfo> ReviewSalesItemInfoes { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMER { get; set; }
    
        public virtual int G_NotificationUpdate(Nullable<int> comp, Nullable<int> bra, string sys)
        {
            var compParameter = comp.HasValue ?
                new ObjectParameter("Comp", comp) :
                new ObjectParameter("Comp", typeof(int));
    
            var braParameter = bra.HasValue ?
                new ObjectParameter("bra", bra) :
                new ObjectParameter("bra", typeof(int));
    
            var sysParameter = sys != null ?
                new ObjectParameter("sys", sys) :
                new ObjectParameter("sys", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("G_NotificationUpdate", compParameter, braParameter, sysParameter);
        }
    
        public virtual int G_ProcessTrans(Nullable<int> comp, Nullable<int> branch, string trType, string opMode, Nullable<int> trID, ObjectParameter trNo, ObjectParameter ok)
        {
            var compParameter = comp.HasValue ?
                new ObjectParameter("Comp", comp) :
                new ObjectParameter("Comp", typeof(int));
    
            var branchParameter = branch.HasValue ?
                new ObjectParameter("Branch", branch) :
                new ObjectParameter("Branch", typeof(int));
    
            var trTypeParameter = trType != null ?
                new ObjectParameter("TrType", trType) :
                new ObjectParameter("TrType", typeof(string));
    
            var opModeParameter = opMode != null ?
                new ObjectParameter("OpMode", opMode) :
                new ObjectParameter("OpMode", typeof(string));
    
            var trIDParameter = trID.HasValue ?
                new ObjectParameter("TrID", trID) :
                new ObjectParameter("TrID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("G_ProcessTrans", compParameter, branchParameter, trTypeParameter, opModeParameter, trIDParameter, trNo, ok);
        }
    
        [DbFunction("InvEntities", "GFun_Companies")]
        public virtual IQueryable<GFun_Companies_Result> GFun_Companies(string userCode)
        {
            var userCodeParameter = userCode != null ?
                new ObjectParameter("userCode", userCode) :
                new ObjectParameter("userCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GFun_Companies_Result>("[InvEntities].[GFun_Companies](@userCode)", userCodeParameter);
        }
    
        public virtual int New_Data_Bes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("New_Data_Bes");
        }
    
        public virtual int Notifications_successful(Nullable<int> iD_ORDER_Delivery)
        {
            var iD_ORDER_DeliveryParameter = iD_ORDER_Delivery.HasValue ?
                new ObjectParameter("ID_ORDER_Delivery", iD_ORDER_Delivery) :
                new ObjectParameter("ID_ORDER_Delivery", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Notifications_successful", iD_ORDER_DeliveryParameter);
        }
    
        public virtual ObjectResult<Original_Purchases_receipt_Result> Original_Purchases_receipt(Nullable<int> trNo)
        {
            var trNoParameter = trNo.HasValue ?
                new ObjectParameter("TrNo", trNo) :
                new ObjectParameter("TrNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Original_Purchases_receipt_Result>("Original_Purchases_receipt", trNoParameter);
        }
    
        public virtual ObjectResult<Original_sales_receipt_Result> Original_sales_receipt(Nullable<int> trNo)
        {
            var trNoParameter = trNo.HasValue ?
                new ObjectParameter("TrNo", trNo) :
                new ObjectParameter("TrNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Original_sales_receipt_Result>("Original_sales_receipt", trNoParameter);
        }
    
        public virtual int update_Purchases_Master(Nullable<int> trNo, string tr_Date, Nullable<int> iD_Supplier, Nullable<bool> type_Debit, Nullable<decimal> total_Amount, Nullable<decimal> paid_Up, Nullable<decimal> to_be_Paid, string rEMARKS)
        {
            var trNoParameter = trNo.HasValue ?
                new ObjectParameter("TrNo", trNo) :
                new ObjectParameter("TrNo", typeof(int));
    
            var tr_DateParameter = tr_Date != null ?
                new ObjectParameter("Tr_Date", tr_Date) :
                new ObjectParameter("Tr_Date", typeof(string));
    
            var iD_SupplierParameter = iD_Supplier.HasValue ?
                new ObjectParameter("ID_Supplier", iD_Supplier) :
                new ObjectParameter("ID_Supplier", typeof(int));
    
            var type_DebitParameter = type_Debit.HasValue ?
                new ObjectParameter("Type_Debit", type_Debit) :
                new ObjectParameter("Type_Debit", typeof(bool));
    
            var total_AmountParameter = total_Amount.HasValue ?
                new ObjectParameter("Total_Amount", total_Amount) :
                new ObjectParameter("Total_Amount", typeof(decimal));
    
            var paid_UpParameter = paid_Up.HasValue ?
                new ObjectParameter("Paid_Up", paid_Up) :
                new ObjectParameter("Paid_Up", typeof(decimal));
    
            var to_be_PaidParameter = to_be_Paid.HasValue ?
                new ObjectParameter("To_be_Paid", to_be_Paid) :
                new ObjectParameter("To_be_Paid", typeof(decimal));
    
            var rEMARKSParameter = rEMARKS != null ?
                new ObjectParameter("REMARKS", rEMARKS) :
                new ObjectParameter("REMARKS", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_Purchases_Master", trNoParameter, tr_DateParameter, iD_SupplierParameter, type_DebitParameter, total_AmountParameter, paid_UpParameter, to_be_PaidParameter, rEMARKSParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> update_Sales_Master(Nullable<decimal> total_All, string userName, Nullable<int> iD_ORDER)
        {
            var total_AllParameter = total_All.HasValue ?
                new ObjectParameter("Total_All", total_All) :
                new ObjectParameter("Total_All", typeof(decimal));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var iD_ORDERParameter = iD_ORDER.HasValue ?
                new ObjectParameter("ID_ORDER", iD_ORDER) :
                new ObjectParameter("ID_ORDER", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("update_Sales_Master", total_AllParameter, userNameParameter, iD_ORDERParameter);
        }
    
        public virtual int update_SalesReturn(Nullable<int> pRODUCT_ID, Nullable<int> quantity_sell, Nullable<decimal> total_Price_One_Part, Nullable<int> iD_ORDER, string statusFlag)
        {
            var pRODUCT_IDParameter = pRODUCT_ID.HasValue ?
                new ObjectParameter("PRODUCT_ID", pRODUCT_ID) :
                new ObjectParameter("PRODUCT_ID", typeof(int));
    
            var quantity_sellParameter = quantity_sell.HasValue ?
                new ObjectParameter("Quantity_sell", quantity_sell) :
                new ObjectParameter("Quantity_sell", typeof(int));
    
            var total_Price_One_PartParameter = total_Price_One_Part.HasValue ?
                new ObjectParameter("Total_Price_One_Part", total_Price_One_Part) :
                new ObjectParameter("Total_Price_One_Part", typeof(decimal));
    
            var iD_ORDERParameter = iD_ORDER.HasValue ?
                new ObjectParameter("ID_ORDER", iD_ORDER) :
                new ObjectParameter("ID_ORDER", typeof(int));
    
            var statusFlagParameter = statusFlag != null ?
                new ObjectParameter("StatusFlag", statusFlag) :
                new ObjectParameter("StatusFlag", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_SalesReturn", pRODUCT_IDParameter, quantity_sellParameter, total_Price_One_PartParameter, iD_ORDERParameter, statusFlagParameter);
        }
    
        public virtual ObjectResult<Notifications_confirmation_Result> Notifications_confirmation()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Notifications_confirmation_Result>("Notifications_confirmation");
        }
    
        public virtual int Notifications_insert_Name_Pilot(Nullable<int> iD_ORDER_Delivery, string name_Pilot)
        {
            var iD_ORDER_DeliveryParameter = iD_ORDER_Delivery.HasValue ?
                new ObjectParameter("ID_ORDER_Delivery", iD_ORDER_Delivery) :
                new ObjectParameter("ID_ORDER_Delivery", typeof(int));
    
            var name_PilotParameter = name_Pilot != null ?
                new ObjectParameter("Name_Pilot", name_Pilot) :
                new ObjectParameter("Name_Pilot", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Notifications_insert_Name_Pilot", iD_ORDER_DeliveryParameter, name_PilotParameter);
        }
    
        public virtual ObjectResult<Get_Settings_Report_Result> Get_Settings_Report(string iD_Button_Print)
        {
            var iD_Button_PrintParameter = iD_Button_Print != null ?
                new ObjectParameter("ID_Button_Print", iD_Button_Print) :
                new ObjectParameter("ID_Button_Print", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Settings_Report_Result>("Get_Settings_Report", iD_Button_PrintParameter);
        }
    
        public virtual ObjectResult<Get_Settings_Report_and_Parameter_Result> Get_Settings_Report_and_Parameter(string iD_Button_Print)
        {
            var iD_Button_PrintParameter = iD_Button_Print != null ?
                new ObjectParameter("ID_Button_Print", iD_Button_Print) :
                new ObjectParameter("ID_Button_Print", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Settings_Report_and_Parameter_Result>("Get_Settings_Report_and_Parameter", iD_Button_PrintParameter);
        }
    }
}