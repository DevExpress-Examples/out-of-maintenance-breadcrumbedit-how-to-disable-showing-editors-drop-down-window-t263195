using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace WindowsFormsApplication25 {
    [UserRepositoryItem("RegisterCustomBreadCrumbEdit")]
    public class RepositoryItemCustomBreadCrumbEdit : RepositoryItemBreadCrumbEdit {
        static RepositoryItemCustomBreadCrumbEdit() {
            RegisterCustomBreadCrumbEdit();
        }

        public const string CustomEditName = "CustomBreadCrumbEdit";

        public RepositoryItemCustomBreadCrumbEdit() {
        }

        public override string EditorTypeName {
            get {
                return CustomEditName;
            }
        }

        public static void RegisterCustomBreadCrumbEdit() {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(CustomBreadCrumbEdit), typeof(RepositoryItemCustomBreadCrumbEdit), typeof(CustomBreadCrumbEditViewInfo), new BreadCrumbEditPainter(), true, img));
        }
        private bool _allowDropDownButtonSelectedState;

        public bool AllowDropDownButtonSelectedState {
            get {
                return _allowDropDownButtonSelectedState;
            }
            set {
                if(_allowDropDownButtonSelectedState != value) {
                    _allowDropDownButtonSelectedState = value;
                    OnPropertiesChanged();
                }
            }
        }
        public override void Assign(RepositoryItem item) {
            BeginUpdate();
            try {
                base.Assign(item);
                RepositoryItemCustomBreadCrumbEdit source = item as RepositoryItemCustomBreadCrumbEdit;
                if(source == null)
                    return;
                _allowDropDownButtonSelectedState = source.AllowDropDownButtonSelectedState;
            } finally {
                EndUpdate();
            }
        }
    }

}
