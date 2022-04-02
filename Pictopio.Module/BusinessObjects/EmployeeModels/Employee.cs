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

namespace Pictopio.Module.BusinessObjects.EmployeeModels
{
    [DefaultClassOptions]

    [NavigationItem(ModuleName.Others)]
    public class Employee : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Employee(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(MiddleName))
                    return $"{LastName}, {FirstName}";
                return $"{LastName}, {FirstName} {MiddleName}";
            }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { SetPropertyValue<string>(nameof(LastName), ref _LastName, value); }
        }

        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set { SetPropertyValue<string>(nameof(FirstName), ref _FirstName, value); }
        }

        private string _MiddleName;
        public string MiddleName
        {
            get { return _MiddleName; }
            set { SetPropertyValue<string>(nameof(MiddleName), ref _MiddleName, value); }
        }


        private string _Suffix;
        public string Suffix
        {
            get { return _Suffix; }
            set { SetPropertyValue<string>(nameof(Suffix), ref _Suffix, value); }
        }


        private DateTime _Birthdate;
        public DateTime Birthdate
        {
            get { return _Birthdate; }
            set { SetPropertyValue<DateTime>(nameof(Birthdate), ref _Birthdate, value); }
        }

        private BirthPlace _BirthPlace;
        [Association]
        public BirthPlace BirthPlace
        {
            get { return _BirthPlace; }
            set { SetPropertyValue<BirthPlace>(nameof(BirthPlace), ref _BirthPlace, value); }
        }

        private EmployeeType _EmployeeType;
        [Association]
        public EmployeeType EmployeeType
        {
            get { return _EmployeeType; }
            set { SetPropertyValue<EmployeeType>(nameof(EmployeeType), ref _EmployeeType, value); }
        }

        private EmployeeStatus _EmployeeStatus;
        [Association]
        public EmployeeStatus EmployeeStatus
        {
            get { return _EmployeeStatus; }
            set { SetPropertyValue<EmployeeStatus>(nameof(EmployeeStatus), ref _EmployeeStatus, value); }
        }



        private string _Position;
        public string Position
        {
            get { return _Position; }
            set { SetPropertyValue<string>(nameof(Position), ref _Position, value); }
        }


        private string _ContactNo;
        public string ContactNo
        {
            get { return _ContactNo; }
            set { SetPropertyValue<string>(nameof(ContactNo), ref _ContactNo, value); }
        }



        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { SetPropertyValue<string>(nameof(Address), ref _Address, value); }
        }


        private string _SSS;
        [XafDisplayName("SSS")]
        public string SSS
        {
            get { return _SSS; }
            set { SetPropertyValue<string>(nameof(SSS), ref _SSS, value); }
        }

        private string _Pagibig;
        public string Pagibig
        {
            get { return _Pagibig; }
            set { SetPropertyValue<string>(nameof(Pagibig), ref _Pagibig, value); }
        }


        private string _Philhealth;
        public string Philhealth
        {
            get { return _Philhealth; }
            set { SetPropertyValue<string>(nameof(Philhealth), ref _Philhealth, value); }
        }


        private string _Tin;
        public string Tin
        {
            get { return _Tin; }
            set { SetPropertyValue<string>(nameof(Tin), ref _Tin, value); }
        }


        private DateTime _DateHired;
        public DateTime DateHired
        {
            get { return _DateHired; }
            set { SetPropertyValue<DateTime>(nameof(DateHired), ref _DateHired, value); }
        }


        private DateTime _DateDeparture;
        public DateTime DateDeparture
        {
            get { return _DateDeparture; }
            set { SetPropertyValue<DateTime>(nameof(DateDeparture), ref _DateDeparture, value); }
        }

        private decimal _HourlyRate;
        public decimal HourlyRate
        {
            get { return _HourlyRate; }
            set { SetPropertyValue<decimal>(nameof(HourlyRate), ref _HourlyRate, value); }
        }

        [Association]
        public XPCollection<ExpenseModels.Labor> Labors
        {
            get { return GetCollection<ExpenseModels.Labor>(nameof(Labors)); }
        }

        private string _IdNumber;
        public string IdNumber
        {
            get { return _IdNumber; }
            set { SetPropertyValue<string>(nameof(IdNumber), ref _IdNumber, value); }
        }





    }
}