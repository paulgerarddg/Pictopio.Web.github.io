using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Pictopio.Module.BusinessObjects.ProjectModels
{
    [DefaultClassOptions]

    [NavigationItem(ModuleName.Project)]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Project : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Project(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _ProjectId;
        public string ProjectId
        {
            get { return _ProjectId; }
            set { SetPropertyValue<string>(nameof(ProjectId), ref _ProjectId, value); }
        }

        public decimal RunningSummary
        {
            get { return ProjectCost - TotalApprovedPurchaseOrder - TotalLabor - TotalPettyCashReleased; }
        }


        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetPropertyValue<string>(nameof(Name), ref _Name, value); }
        }

        private decimal _ProjectCost;
        public decimal ProjectCost
        {
            get { return _ProjectCost; }
            set { SetPropertyValue<decimal>(nameof(ProjectCost), ref _ProjectCost, value); }
        }

        private decimal _LotArea;
        public decimal LotArea
        {
            get { return _LotArea; }
            set { SetPropertyValue<decimal>(nameof(LotArea), ref _LotArea, value); }
        }


        private decimal _FloorArea;
        public decimal FloorArea
        {
            get { return _FloorArea; }
            set { SetPropertyValue<decimal>(nameof(FloorArea), ref _FloorArea, value); }
        }


        private string _Owner;
        public string Owner
        {
            get { return _Owner; }
            set { SetPropertyValue<string>(nameof(Owner), ref _Owner, value); }
        }




        private bool _Vat;
        public bool Vat
        {
            get { return _Vat; }
            set { SetPropertyValue<bool>(nameof(Vat), ref _Vat, value); }
        }



        private DateTime _StartDate;
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { SetPropertyValue<DateTime>(nameof(StartDate), ref _StartDate, value); }
        }


        private DateTime _ProjectDeadline;
        public DateTime ProjectDeadline
        {
            get { return _ProjectDeadline; }
            set { SetPropertyValue<DateTime>(nameof(ProjectDeadline), ref _ProjectDeadline, value); }
        }

        private Company _Company;
        [Association]
        public Company Company
        {
            get { return _Company; }
            set { SetPropertyValue<Company>(nameof(Company), ref _Company, value); }
        }



        private string _Location;
        
        public string Location
        {
            get { return _Location; }
            set { SetPropertyValue<string>(nameof(Location), ref _Location, value); }
        }

        [Association]
        public XPCollection<ProjectMaterial> ProjectMaterials
        {
            get { return GetCollection<ProjectMaterial>(nameof(ProjectMaterials)); }
        }

        [Association]
        public XPCollection<PurchaseOrderModels.PurchaseOrder> PurchaseOrders
        {
            get { return GetCollection<PurchaseOrderModels.PurchaseOrder>(nameof(PurchaseOrders)); }
        }

        [Association]
        public XPCollection<ProjectBilling> ProjectBillings
        {
            get { return GetCollection<ProjectBilling>(nameof(ProjectBillings)); }
        }

        public decimal TotalBillingPaid
        {
            get { return ProjectBillings.Where(s => s.BillingStatus == BillingStatusEnum.Paid).Sum(s => s.TotalAmount); }
        }
        public decimal TotalBillingApproved
        {
            get { return ProjectBillings.Where(s => s.BillingStatus == BillingStatusEnum.Approved).Sum(s => s.TotalAmount); }
        }
        [XafDisplayName("Total OR Released")]
        public decimal TotalPettyCashReleased
        {
            get { return PettyCashes.Sum(s => s.Amount); }
        }


        [Association]
        [XafDisplayName("OR Released")]
        public XPCollection<PettyCashModels.PettyCash> PettyCashes  
        {
            get { return GetCollection<PettyCashModels.PettyCash>(nameof(PettyCashes)); }
        }

        [Association]
        public XPCollection<ExpenseModels.Labor> Labors
        {
            get { return GetCollection<ExpenseModels.Labor>(nameof(Labors)); }
        }
        public decimal TotalLabor
        {
            get { return Labors.Sum(s => s.Amount); }
        }

        public decimal TotalApprovedPurchaseOrder
        {
            get { return PurchaseOrders.Where(s => s.PurchaseOrderStatus == PurchaseOrderModels.PurchaseOrderStatus.Approved).Sum(s => s.TotalAmount); }
        }

    }
}