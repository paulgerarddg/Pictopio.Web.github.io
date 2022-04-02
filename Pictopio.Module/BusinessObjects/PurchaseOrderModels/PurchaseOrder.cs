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

namespace Pictopio.Module.BusinessObjects.PurchaseOrderModels
{
    [DefaultClassOptions]

    [NavigationItem(ModuleName.PurchaseOrder)]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class PurchaseOrder : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public PurchaseOrder(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _Name;

        [VisibleInDetailView(false), VisibleInListView(false)]
        public string Name
        {
            get { return _Name; }
            set { SetPropertyValue<string>(nameof(Name), ref _Name, value); }
        }

        private ProjectModels.Project _Project;
        [Association]
        public ProjectModels.Project Project
        {
            get { return _Project; }
            set { SetPropertyValue<ProjectModels.Project>(nameof(Project), ref _Project, value); }
        }






        [Association]
        public XPCollection<PurchaseOrderItem> PurchaseOrderItems
        {
            get { return GetCollection<PurchaseOrderItem>(nameof(PurchaseOrderItems)); }
        }

        public decimal TotalAmount
        {
            get { return PurchaseOrderItems.Sum(s => s.Amount); }
        }


        private PurchaseOrderStatus _PurchaseOrderStatus;
        public PurchaseOrderStatus PurchaseOrderStatus
        {
            get { return _PurchaseOrderStatus; }
            set { SetPropertyValue<PurchaseOrderStatus>(nameof(PurchaseOrderStatus), ref _PurchaseOrderStatus, value); }
        }


    }
    public enum PurchaseOrderStatus
    {
        Pending, Approved, Denied
    }
}