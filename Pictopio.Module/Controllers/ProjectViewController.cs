using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using Pictopio.Module.BusinessObjects;
using Pictopio.Module.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;

namespace Pictopio.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class ProjectViewController : ViewController
    {
        public ProjectViewController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void printOr_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            var current = View.CurrentObject as Company;
            var objectSpace = Application.CreateObjectSpace();
            var mdl = new ORReportModel(objectSpace);
            var dv = Application.CreateDetailView(objectSpace, mdl);
            dv.ViewEditMode = ViewEditMode.Edit;
            e.View = dv;
        }
        private void printOr_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {

            var mdl = e.PopupWindowViewCurrentObject as ORReportModel;
            if (mdl == null) return;
            var _objectSpace = mdl._objectSpace;
            IReportDataV2 reportData =
                   _objectSpace.FindObject<ReportDataV2>(new BinaryOperator("DisplayName", "BIR Report"));

            if (reportData == null)
            {
                throw new UserFriendlyException("Cannot find the 'BIR' report.");
            }
            XtraReport report = ReportDataProvider.ReportsStorage.LoadReport(reportData);
            ReportsModuleV2 reportsModule = ReportsModuleV2.FindReportsModule(Application.Modules);
            if (reportsModule?.ReportsDataSourceHelper != null)
            {
                reportsModule.ReportsDataSourceHelper.SetupBeforePrint(report);
            }
            try
            {
                report.DataSource = mdl;
                var printTool = new ReportPrintTool(report);
                printTool.ShowRibbonPreview();
             
            }
            catch (Exception ex)
            {
                try
                {
                    reportsModule.ReportsDataSourceHelper.SetupBeforePrint(report);
                    report.CreateDocument();
                    PrintToolBase tool = new PrintToolBase(report.PrintingSystem);
                    tool.Print();
                }
                catch (Exception)
                {

                }
            }
        }
    }
}