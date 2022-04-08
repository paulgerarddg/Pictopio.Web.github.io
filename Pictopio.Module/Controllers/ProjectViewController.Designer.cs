
using Pictopio.Module.BusinessObjects;

namespace Pictopio.Module.Controllers
{
    partial class ProjectViewController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.printOr = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);

            this.printOr.Caption = "Print BIR Report";
            this.printOr.Category = "Edit";
            this.printOr.ConfirmationMessage = null;
            this.printOr.Id = "660fd53b-c287-4671-97ca-bf3f637e7abf";
            this.printOr.ImageName = "Action_CreateDashboard";
            this.printOr.TargetObjectType = typeof(Company);
            this.printOr.ToolTip = null;
            this.printOr.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.printOr_CustomizePopupWindowParams);

            this.printOr.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.printOr_Execute);

            this.Actions.Add(this.printOr);
        }

        #endregion
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction printOr;
    }
}
