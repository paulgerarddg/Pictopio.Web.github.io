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
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class ProjectBilling : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public ProjectBilling(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetPropertyValue<string>(nameof(Name), ref _Name, value); }
        }


        private decimal _TotalAmount;
        public decimal TotalAmount
        {
            get { return ProjectBillingItems.Sum(s => s.Amount); }
        }

        private Project _Project;
        [Association]
        public Project Project
        {
            get { return _Project; }
            set { SetPropertyValue<Project>(nameof(Project), ref _Project, value); }
        }

        private BillingStatusEnum _BillingStatus;
        public BillingStatusEnum BillingStatus
        {
            get { return _BillingStatus; }
            set { SetPropertyValue<BillingStatusEnum>(nameof(BillingStatus), ref _BillingStatus, value); }
        }

        [Association]
        public XPCollection<ProjectBillingItem> ProjectBillingItems
        {
            get { return GetCollection<ProjectBillingItem>(nameof(ProjectBillingItems)); }
        }




    }
    public enum BillingStatusEnum
    {
        Initiated, Approved, Paid
    }
}