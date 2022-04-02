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

namespace Pictopio.Module.BusinessObjects.ProjectModels
{
    [DefaultClassOptions]

    [NavigationItem(ModuleName.Project)]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class ProjectMaterial : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public ProjectMaterial(Session session)
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

        private Material _Material;
        [Association]
        public Material Material
        {
            get { return _Material; }
            set
            {
                SetPropertyValue<Material>(nameof(Material), ref _Material, value);
            }
        }

        private decimal _EstimatedAmount;
        public decimal EstimatedAmount
        {
            get { return _EstimatedAmount; }
            set { SetPropertyValue<decimal>(nameof(EstimatedAmount), ref _EstimatedAmount, value); }
        }

        private int _Quantity;
        public int Quantity
        {
            get { return _Quantity; }
            set { SetPropertyValue<int>(nameof(Quantity), ref _Quantity, value); }
        }


        private bool _ManualAmount;
        public bool ManualAmount
        {
            get { return _ManualAmount; }
            set
            {
                SetPropertyValue<bool>(nameof(ManualAmount), ref _ManualAmount, value);
            }
        }

        private decimal _UnitValue;
        public decimal UnitValue
        {
            get { return _UnitValue; }
            set { SetPropertyValue<decimal>(nameof(UnitValue), ref _UnitValue, value); }
        }

        public decimal Amount
        {
            get
            {
                if (!ManualAmount)
                {
                    EstimatedAmount = Material.SuggestedAmount;
                    UnitValue = EstimatedAmount;
                }
                return UnitValue * Quantity;
            }
        }

        private Project _Project;
        [Association]
        public Project Project
        {
            get { return _Project; }
            set { SetPropertyValue<Project>(nameof(Project), ref _Project, value); }
        }
    }
}