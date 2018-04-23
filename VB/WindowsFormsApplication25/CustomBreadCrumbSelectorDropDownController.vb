Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsFormsApplication25
    Public Class CustomBreadCrumbSelectorDropDownController
        Inherits BreadCrumbSelectorDropDownController

        Public Sub New(ByVal handler As BreadCrumbEditHandler)
            MyBase.New(handler)

        End Sub
        Protected Overrides Sub EnsureNodePopup(ByVal hotNode As BreadCrumbEditHitInfo, ByVal pt As Point, ByVal hidePopupIfOpen As Boolean)
            If AllowDropDown Then
                MyBase.EnsureNodePopup(hotNode, pt, hidePopupIfOpen)
            End If
        End Sub
        Protected Overrides ReadOnly Property AllowDropDown() As Boolean
            Get
                Return False
            End Get
        End Property
    End Class

End Namespace
