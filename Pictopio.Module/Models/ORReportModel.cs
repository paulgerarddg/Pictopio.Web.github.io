using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using Pictopio.Module.BusinessObjects;
using Pictopio.Module.BusinessObjects.PettyCashModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictopio.Module.Models
{
    [DomainComponent]
    [VisibleInReports]
    public class ORReportModel : INotifyPropertyChanged
    {
        [VisibleInDetailView(false), VisibleInListView(false)]
        public IObjectSpace _objectSpace { get; set; }

        protected void RaisePropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ORReportModel(IObjectSpace objectSpace)
        {
            _objectSpace = objectSpace;
            Year = DateTime.Now.Year;
        }

        private MonthEnum _Month;
        public MonthEnum Month
        {
            get 
            {
                return _Month; 
            }
            set 
            {
                _Month = value;

                GenerateItems();
            }
        }

        private int _Year;
        public int Year
        {
            get
            {
                return _Year;
            }
            set
            {
                _Year = value;

                GenerateItems();
            }
        }



        private Company _Company;
        public Company Company
        {
            get
            {
                return _Company;
            }
            set
            {
                _Company = value;

                GenerateItems();
            }
        }

        public List<OrItemModel> Items { get; set; }


        private void GenerateItems()
        {
            if (Year < 1900) return;
            if (Company == null) return;
            var dt = new DateTime(Year, (int)(Month + 1), 1);
            var op = GroupOperator.Combine(GroupOperatorType.And,
                    new BinaryOperator("Project.Company.Oid", Company.Oid),
                    CriteriaOperator.Parse("DateReleased>=? and DateReleased<=?", dt.Date, dt.Date.AddMonths(1).AddSeconds(-1)));

            var PettyCashs = _objectSpace.GetObjects<PettyCash>(op);
            Items = new List<OrItemModel>();
            foreach (var item in PettyCashs)
            {
                var nItem = new OrItemModel
                {
                    Date = item.DateReleased, 
                    Supplier = item.Store?.Name,
                    SupplierTin = item.Store?.TinNumber,
                    SupplierAddress = item.Store?.Address, 
                    Amount = item.Amount

                };
                Items.Add(nItem);
            }
            RaisePropertyChanged("Items");
        }
    }


    [DomainComponent]
    [VisibleInReports]
    public class OrItemModel
    {
        public DateTime Date { get; set; }
        public string Supplier { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierTin { get; set; }
        public decimal Amount { get; set; }
        public decimal Amount2 { get; set; }
    }
    public enum MonthEnum
    {
        January, February, March, April, May, June, July, August, September, October, November, December
    }
}