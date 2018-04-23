using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Popup;
using DevExpress.Utils.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication25 {
    [ToolboxItem(true)]
    public class CustomBreadCrumbEdit : BreadCrumbEdit {
        static CustomBreadCrumbEdit() {
            RepositoryItemCustomBreadCrumbEdit.RegisterCustomBreadCrumbEdit();
        }

        public CustomBreadCrumbEdit() {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomBreadCrumbEdit Properties {
            get {
                return base.Properties as RepositoryItemCustomBreadCrumbEdit;
            }
        }

        public override string EditorTypeName {
            get {
                return RepositoryItemCustomBreadCrumbEdit.CustomEditName;
            }
        }
        protected override BreadCrumbEditHandler CreateHandler() {
            return new CustomBreadCrumbEditHandler(this);
        }
    }
}
