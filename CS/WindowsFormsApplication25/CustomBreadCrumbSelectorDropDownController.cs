using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsFormsApplication25 {
    public class CustomBreadCrumbSelectorDropDownController : BreadCrumbSelectorDropDownController {
        public CustomBreadCrumbSelectorDropDownController(BreadCrumbEditHandler handler)
            : base(handler) {

        }
        protected override void EnsureNodePopup(BreadCrumbEditHitInfo hotNode, Point pt, bool hidePopupIfOpen) {
            if(AllowDropDown) {
                base.EnsureNodePopup(hotNode, pt, hidePopupIfOpen);
            }
        }
        protected override bool AllowDropDown {
            get {
                return false;
            }
        }
    }

}
