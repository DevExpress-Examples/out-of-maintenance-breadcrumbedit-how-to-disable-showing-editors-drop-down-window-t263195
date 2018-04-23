Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.Utils.Drawing
Imports System.Windows.Forms

Namespace WindowsFormsApplication25
    <ToolboxItem(True)> _
    Public Class CustomBreadCrumbEdit
        Inherits BreadCrumbEdit

        Shared Sub New()
            RepositoryItemCustomBreadCrumbEdit.RegisterCustomBreadCrumbEdit()
        End Sub

        Public Sub New()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Shadows ReadOnly Property Properties() As RepositoryItemCustomBreadCrumbEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemCustomBreadCrumbEdit)
            End Get
        End Property

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return RepositoryItemCustomBreadCrumbEdit.CustomEditName
            End Get
        End Property
        Protected Overrides Function CreateHandler() As BreadCrumbEditHandler
            Return New CustomBreadCrumbEditHandler(Me)
        End Function
    End Class
End Namespace
