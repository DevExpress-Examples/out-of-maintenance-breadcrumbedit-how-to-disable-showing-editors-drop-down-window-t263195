using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsFormsApplication25 {
    public class CustomBreadCrumbEditViewInfo : BreadCrumbEditViewInfo {
        public CustomBreadCrumbEditViewInfo(RepositoryItem item)
            : base(item) {
        }
        protected override void UpdateNodeState(BreadCrumbNodeInfo nodeInfo) {
            if(!OwnerControl.Enabled) {
                nodeInfo.State = ObjectState.Disabled;
                return;
            }
            if(OwnerControl.IsDesignMode)
                return;
            if(ExpandedNode.NodeInfo != null && ExpandedNode.NodeInfo.IsMatch(nodeInfo)) {
                nodeInfo.State = ObjectState.Hot | ObjectState.Pressed;
                return;
            }
            if(HotNode.NodeInfo != null && HotNode.NodeInfo.IsMatch(nodeInfo)) {
                nodeInfo.State = ObjectState.Hot;
                //--- Comment this code to disable pressed state
                if((OwnerEdit.Properties as RepositoryItemCustomBreadCrumbEdit).AllowDropDownButtonSelectedState) {
                    if((Control.MouseButtons & MouseButtons.Left) != 0) {
                        nodeInfo.State |= ObjectState.Pressed;
                    }
                }
                //---
            } else {
                nodeInfo.State &= ~ObjectState.Hot;
            }
        }
    }
}
