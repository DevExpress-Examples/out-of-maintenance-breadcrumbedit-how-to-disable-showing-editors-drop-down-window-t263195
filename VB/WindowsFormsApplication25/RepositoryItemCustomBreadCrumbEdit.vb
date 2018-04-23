Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository

Namespace WindowsFormsApplication25
    <UserRepositoryItem("RegisterCustomBreadCrumbEdit")> _
    Public Class RepositoryItemCustomBreadCrumbEdit
        Inherits RepositoryItemBreadCrumbEdit

        Shared Sub New()
            RegisterCustomBreadCrumbEdit()
        End Sub

        Public Const CustomEditName As String = "CustomBreadCrumbEdit"

        Public Sub New()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return CustomEditName
            End Get
        End Property

        Public Shared Sub RegisterCustomBreadCrumbEdit()
            Dim img As Image = Nothing
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CustomBreadCrumbEdit), GetType(RepositoryItemCustomBreadCrumbEdit), GetType(CustomBreadCrumbEditViewInfo), New BreadCrumbEditPainter(), True, img))
        End Sub
        Private _allowDropDownButtonSelectedState As Boolean

        Public Property AllowDropDownButtonSelectedState() As Boolean
            Get
                Return _allowDropDownButtonSelectedState
            End Get
            Set(ByVal value As Boolean)
                If _allowDropDownButtonSelectedState <> value Then
                    _allowDropDownButtonSelectedState = value
                    OnPropertiesChanged()
                End If
            End Set
        End Property
        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            BeginUpdate()
            Try
                MyBase.Assign(item)
                Dim source As RepositoryItemCustomBreadCrumbEdit = TryCast(item, RepositoryItemCustomBreadCrumbEdit)
                If source Is Nothing Then
                    Return
                End If
                _allowDropDownButtonSelectedState = source.AllowDropDownButtonSelectedState
            Finally
                EndUpdate()
            End Try
        End Sub
    End Class

End Namespace
