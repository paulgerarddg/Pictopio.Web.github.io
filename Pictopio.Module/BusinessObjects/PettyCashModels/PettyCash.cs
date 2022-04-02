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

namespace Pictopio.Module.BusinessObjects.PettyCashModels
{
    [DefaultClassOptions]
    [XafDisplayName("OR")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class PettyCash : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public PettyCash(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _Name;
        [XafDisplayName("Description")]
        public string Name
        {
            get { return _Name; }
            set { SetPropertyValue<string>(nameof(Name), ref _Name, value); }
        }
        private DateTime _DateReleased;
        public DateTime DateReleased
        {
            get { return _DateReleased; }
            set { SetPropertyValue<DateTime>(nameof(DateReleased), ref _DateReleased, value); }
        }


        private ProjectModels.Project _Project;
        [Association]
        public ProjectModels.Project Project
        {
            get { return _Project; }
            set { SetPropertyValue<ProjectModels.Project>(nameof(Project), ref _Project, value); }
        }

       
        private Store _Store;
        [Association]
        [XafDisplayName("Supplier")]
        public Store Store
        {
            get { return _Store; }
            set { SetPropertyValue<Store>(nameof(Store), ref _Store, value); }
        }

        private decimal _Amount;
        public decimal Amount
        {
            get { return _Amount; }
            set { SetPropertyValue<decimal>(nameof(Amount), ref _Amount, value); }
        }

    }
}