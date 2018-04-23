using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication25 {
    public class CustomBreadCrumbEditHandler : BreadCrumbEditHandler {
        public CustomBreadCrumbEditHandler(BreadCrumbEdit owner)
            : base(owner) {

        }
        protected override BreadCrumbSelectorDropDownController CreateDropDownController() {
            return new CustomBreadCrumbSelectorDropDownController(this);
        }
    }

}
