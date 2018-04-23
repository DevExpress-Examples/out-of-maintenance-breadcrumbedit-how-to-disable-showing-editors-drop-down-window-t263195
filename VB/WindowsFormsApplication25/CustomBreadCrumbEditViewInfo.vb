Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsFormsApplication25
    Public Class CustomBreadCrumbEditViewInfo
        Inherits BreadCrumbEditViewInfo

        Public Sub New(ByVal item As RepositoryItem)
            MyBase.New(item)
        End Sub
        Protected Overrides Sub UpdateNodeState(ByVal nodeInfo As BreadCrumbNodeInfo)
            If Not OwnerControl.Enabled Then
                nodeInfo.State = ObjectState.Disabled
                Return
            End If
            If OwnerControl.IsDesignMode Then
                Return
            End If
            If ExpandedNode.NodeInfo IsNot Nothing AndAlso ExpandedNode.NodeInfo.IsMatch(nodeInfo) Then
                nodeInfo.State = ObjectState.Hot Or ObjectState.Pressed
                Return
            End If
            If HotNode.NodeInfo IsNot Nothing AndAlso HotNode.NodeInfo.IsMatch(nodeInfo) Then
                nodeInfo.State = ObjectState.Hot
                '--- Comment this code to disable pressed state
                If (TryCast(OwnerEdit.Properties, RepositoryItemCustomBreadCrumbEdit)).AllowDropDownButtonSelectedState Then
                    If (Control.MouseButtons And MouseButtons.Left) <> 0 Then
                        nodeInfo.State = nodeInfo.State Or ObjectState.Pressed
                    End If
                End If
                '---
            Else
                nodeInfo.State = nodeInfo.State And Not ObjectState.Hot
            End If
        End Sub
    End Class
End Namespace
