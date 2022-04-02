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

namespace Pictopio.Module.BusinessObjects.ExpenseModels
{
    [DefaultClassOptions]

    [NavigationItem(ModuleName.Expense)]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Labor : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Labor(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        [ReadOnly(true)]
        public string Name
        {
            get { return $"{Employee?.FullName} - {DateLabor.ToShortDateString()}"; }
        }


        private decimal _HourlyRate;
        public decimal HourlyRate
        {
            get { return _HourlyRate; }
            set { SetPropertyValue<decimal>(nameof(HourlyRate), ref _HourlyRate, value); }
        }

        private bool _IsManualRate;
        public bool IsManualRate
        {
            get { return _IsManualRate; }
            set { SetPropertyValue<bool>(nameof(IsManualRate), ref _IsManualRate, value); }
        }

        private int _Hours;
        public int Hours
        {
            get { return _Hours; }
            set { SetPropertyValue<int>(nameof(Hours), ref _Hours, value); }
        }

        private int _Minutes;
        public int Minutes
        {
            get { return _Minutes; }
            set { SetPropertyValue<int>(nameof(Minutes), ref _Minutes, value); }
        }

        private ProjectModels.Project _Project;
        [Association]
        public ProjectModels.Project Project
        {
            get { return _Project; }
            set { SetPropertyValue<ProjectModels.Project>(nameof(Project), ref _Project, value); }
        }

        private EmployeeModels.Employee _Employee;
        [Association]
        public EmployeeModels.Employee Employee
        {
            get { return _Employee; }
            set
            {
                SetPropertyValue<EmployeeModels.Employee>(nameof(Employee), ref _Employee, value);
            }
        }

        private DateTime _DateLabor;
        public DateTime DateLabor
        {
            get { return _DateLabor; }
            set
            {

                SetPropertyValue<DateTime>(nameof(DateLabor), ref _DateLabor, value);

            }
        }

        private bool _IsApproved;
        public bool IsApproved
        {
            get { return _IsApproved; }
            set { SetPropertyValue<bool>(nameof(IsApproved), ref _IsApproved, value); }
        }

        private bool _IsReleased;
        public bool IsReleased
        {
            get { return _IsReleased; }
            set { SetPropertyValue<bool>(nameof(IsReleased), ref _IsReleased, value); }
        }

        public decimal Amount
        {
            get
            {
                if (Employee != null && !IsManualRate)
                {
                    HourlyRate = Employee.HourlyRate;
                    SetPropertyValue<decimal>(nameof(HourlyRate), ref _HourlyRate, HourlyRate);
                }

                return (Hours * HourlyRate) + (Minutes * (HourlyRate / 60));
            }
        }
    }
}