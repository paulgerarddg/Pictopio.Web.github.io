using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using Pictopio.Module.BusinessObjects.ProjectModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Pictopio.Module.BusinessObjects.EmployeeModels
{
    [DefaultClassOptions]
    [NavigationItem(ModuleName.Expense)]
    public class Material : XPObject

    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Material(Session session)
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

        private decimal _SuggestedAmount;
        public decimal SuggestedAmount
        {
            get { return _SuggestedAmount; }
            set { SetPropertyValue<decimal>(nameof(SuggestedAmount), ref _SuggestedAmount, value); }
        }


        [Association]
        public XPCollection<ProjectMaterial> ProjectMaterials
        {
            get { return GetCollection<ProjectMaterial>(nameof(ProjectMaterials)); }
        }

    }
}