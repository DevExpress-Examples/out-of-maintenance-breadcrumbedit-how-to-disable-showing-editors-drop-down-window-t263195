namespace WindowsFormsApplication25 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode1 = new DevExpress.XtraEditors.BreadCrumbNode();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode2 = new DevExpress.XtraEditors.BreadCrumbNode();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode3 = new DevExpress.XtraEditors.BreadCrumbNode();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode4 = new DevExpress.XtraEditors.BreadCrumbNode();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode5 = new DevExpress.XtraEditors.BreadCrumbNode();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode6 = new DevExpress.XtraEditors.BreadCrumbNode();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode7 = new DevExpress.XtraEditors.BreadCrumbNode();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode8 = new DevExpress.XtraEditors.BreadCrumbNode();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode9 = new DevExpress.XtraEditors.BreadCrumbNode();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode10 = new DevExpress.XtraEditors.BreadCrumbNode();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode11 = new DevExpress.XtraEditors.BreadCrumbNode();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode12 = new DevExpress.XtraEditors.BreadCrumbNode();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode13 = new DevExpress.XtraEditors.BreadCrumbNode();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode14 = new DevExpress.XtraEditors.BreadCrumbNode();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.customBreadCrumbEdit1 = new WindowsFormsApplication25.CustomBreadCrumbEdit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customBreadCrumbEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(39, 46);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "AllowSelectedState";
            this.checkEdit1.Size = new System.Drawing.Size(184, 19);
            this.checkEdit1.TabIndex = 1;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // customBreadCrumbEdit1
            // 
            this.customBreadCrumbEdit1.Location = new System.Drawing.Point(39, 95);
            this.customBreadCrumbEdit1.Name = "customBreadCrumbEdit1";
            this.customBreadCrumbEdit1.Properties.AllowDropDownButtonSelectedState = false;
            this.customBreadCrumbEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            breadCrumbNode1.Caption = "Root";
            breadCrumbNode2.Caption = "BreadCrumbNode1";
            breadCrumbNode3.Caption = "BreadCrumbNode11";
            breadCrumbNode3.Value = "BreadCrumbNode11";
            breadCrumbNode4.Caption = "BreadCrumbNode12";
            breadCrumbNode4.Value = "BreadCrumbNode12";
            breadCrumbNode5.Caption = "BreadCrumbNode13";
            breadCrumbNode5.Value = "BreadCrumbNode13";
            breadCrumbNode2.ChildNodes.AddRange(new DevExpress.XtraEditors.BreadCrumbNode[] {
            breadCrumbNode3,
            breadCrumbNode4,
            breadCrumbNode5});
            breadCrumbNode2.Value = "BreadCrumbNode1";
            breadCrumbNode6.Caption = "BreadCrumbNode2";
            breadCrumbNode6.Value = "BreadCrumbNode2";
            breadCrumbNode7.Caption = "BreadCrumbNode3";
            breadCrumbNode7.Value = "BreadCrumbNode3";
            breadCrumbNode1.ChildNodes.AddRange(new DevExpress.XtraEditors.BreadCrumbNode[] {
            breadCrumbNode2,
            breadCrumbNode6,
            breadCrumbNode7});
            breadCrumbNode1.Value = "Root";
            breadCrumbNode8.Caption = "BreadCrumbNode4";
            breadCrumbNode9.Caption = "BreadCrumbNode9";
            breadCrumbNode9.Value = "BreadCrumbNode9";
            breadCrumbNode10.Caption = "BreadCrumbNode10";
            breadCrumbNode10.Value = "BreadCrumbNode10";
            breadCrumbNode8.ChildNodes.AddRange(new DevExpress.XtraEditors.BreadCrumbNode[] {
            breadCrumbNode9,
            breadCrumbNode10});
            breadCrumbNode8.Value = "BreadCrumbNode4";
            breadCrumbNode11.Caption = "BreadCrumbNode5";
            breadCrumbNode12.Caption = "BreadCrumbNode6";
            breadCrumbNode12.Value = "BreadCrumbNode6";
            breadCrumbNode13.Caption = "BreadCrumbNode7";
            breadCrumbNode13.Value = "BreadCrumbNode7";
            breadCrumbNode14.Caption = "BreadCrumbNode8";
            breadCrumbNode14.Value = "BreadCrumbNode8";
            breadCrumbNode11.ChildNodes.AddRange(new DevExpress.XtraEditors.BreadCrumbNode[] {
            breadCrumbNode12,
            breadCrumbNode13,
            breadCrumbNode14});
            breadCrumbNode11.Value = "BreadCrumbNode5";
            this.customBreadCrumbEdit1.Properties.Nodes.AddRange(new DevExpress.XtraEditors.BreadCrumbNode[] {
            breadCrumbNode1,
            breadCrumbNode8,
            breadCrumbNode11});
            this.customBreadCrumbEdit1.Properties.SelectedNode = breadCrumbNode5;
            this.customBreadCrumbEdit1.Size = new System.Drawing.Size(384, 22);
            this.customBreadCrumbEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 186);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.customBreadCrumbEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customBreadCrumbEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomBreadCrumbEdit customBreadCrumbEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}

