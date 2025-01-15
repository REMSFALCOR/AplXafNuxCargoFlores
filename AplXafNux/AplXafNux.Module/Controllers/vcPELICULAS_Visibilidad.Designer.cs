
namespace AplXafNux.Module.Controllers
{
    partial class vcPELICULAS_Visibilidad
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
            this.popopupPELICULAS_VisibleInvisible = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // popopupPELICULAS_VisibleInvisible
            // 
            this.popopupPELICULAS_VisibleInvisible.Caption = "Visible/Invisible";
            this.popopupPELICULAS_VisibleInvisible.ConfirmationMessage = null;
            this.popopupPELICULAS_VisibleInvisible.Id = "popopupPELICULAS_VisibleInvisible";
            this.popopupPELICULAS_VisibleInvisible.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireMultipleObjects;
            this.popopupPELICULAS_VisibleInvisible.TargetObjectType = typeof(AplXafNux.Module.BusinessObjects.Pruebas.Peliculas);
            this.popopupPELICULAS_VisibleInvisible.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.popopupPELICULAS_VisibleInvisible.ToolTip = null;
            this.popopupPELICULAS_VisibleInvisible.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.popopupPELICULAS_VisibleInvisible.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.popopupPELICULAS_VisibleInvisible_Execute);
            // 
            // vcPELICULAS_Visibilidad
            // 
            this.Actions.Add(this.popopupPELICULAS_VisibleInvisible);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction popopupPELICULAS_VisibleInvisible;
    }
}
