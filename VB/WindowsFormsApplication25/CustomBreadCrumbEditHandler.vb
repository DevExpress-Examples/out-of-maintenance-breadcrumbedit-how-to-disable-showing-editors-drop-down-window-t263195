Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication25
    Public Class CustomBreadCrumbEditHandler
        Inherits BreadCrumbEditHandler

        Public Sub New(ByVal owner As BreadCrumbEdit)
            MyBase.New(owner)

        End Sub
        Protected Overrides Function CreateDropDownController() As BreadCrumbSelectorDropDownController
            Return New CustomBreadCrumbSelectorDropDownController(Me)
        End Function
    End Class

End Namespace
