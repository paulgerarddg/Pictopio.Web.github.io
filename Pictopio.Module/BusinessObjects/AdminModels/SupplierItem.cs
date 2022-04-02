using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using Pictopio.Module.BusinessObjects.EmployeeModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Pictopio.Module.BusinessObjects.AdminModels
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class SupplierItem : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public SupplierItem(Session session)
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


        private decimal _SuggestedPrice;
        public decimal SuggestedPrice
        {
            get { return _SuggestedPrice; }
            set { SetPropertyValue<decimal>(nameof(SuggestedPrice), ref _SuggestedPrice, value); }
        }

        private Supplier _Supplier;
        [Association]
        public Supplier Supplier
        {
            get { return _Supplier; }
            set { SetPropertyValue<Supplier>(nameof(Supplier), ref _Supplier, value); }
        }


        private Material _Material;
        public Material Material
        {
            get { return _Material; }
            set { SetPropertyValue<Material>(nameof(Material), ref _Material, value); }
        }

    }
}