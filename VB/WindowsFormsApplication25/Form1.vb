Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsFormsApplication25
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
            customBreadCrumbEdit1.Properties.AllowDropDownButtonSelectedState = checkEdit1.Checked
        End Sub
    End Class
End Namespace
