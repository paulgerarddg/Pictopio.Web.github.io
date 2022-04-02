using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using Pictopio.Module.BusinessObjects.EmployeeModels;
using Pictopio.Module.BusinessObjects.ProjectModels;
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
    public class PurchaseOrderItem : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public PurchaseOrderItem(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        protected override void OnSaving()
        {
            base.OnSaving();
            Name = $"{Material?.Name} - {Amount}";
        }

        private string _Name;

        [VisibleInDetailView(false), VisibleInListView(false)]
        public string Name
        {
            get { return _Name; }
            set { SetPropertyValue<string>(nameof(Name), ref _Name, value); }
        }

        private PurchaseOrder _PurchaseOrder;
        [Association]
        public PurchaseOrder PurchaseOrder
        {
            get { return _PurchaseOrder; }
            set { SetPropertyValue<PurchaseOrder>(nameof(PurchaseOrder), ref _PurchaseOrder, value); }
        }

        private int _Quantity;
        public int Quantity
        {
            get { return _Quantity; }
            set { SetPropertyValue<int>(nameof(Quantity), ref _Quantity, value); }
        }

        private decimal _UnitValue;
        public decimal UnitValue
        {
            get { return _UnitValue; }
            set { SetPropertyValue<decimal>(nameof(UnitValue), ref _UnitValue, value); }
        }

        private bool _ManualUnitValue;
        public bool ManualUnitValue
        {
            get { return _ManualUnitValue; }
            set { SetPropertyValue<bool>(nameof(ManualUnitValue), ref _ManualUnitValue, value); }
        }


        public decimal Amount
        {
            get
            {
                if (Material != null)
                {
                    if (!ManualUnitValue)
                    {
                        if (Material.SuggestedAmount > 0)
                            UnitValue = Material.SuggestedAmount;
                    }
                }
                return UnitValue * Quantity;
            }
        }

        public decimal? EstimatedAmount
        {
            get { return Material?.SuggestedAmount * Quantity; }
        }
        private AdminModels.Supplier _Supplier;
        [Association]
        public AdminModels.Supplier Supplier
        {
            get { return _Supplier; }
            set { SetPropertyValue<AdminModels.Supplier>(nameof(Supplier), ref _Supplier, value); }
        }
        private Material _Material;
        [DataSourceCriteria("Supplier = '@This.Supplier'")]
        public Material Material
        {
            get { return _Material; }
            set
            {
                SetPropertyValue<Material>(nameof(Material), ref _Material, value);
            }
        }
    }
}