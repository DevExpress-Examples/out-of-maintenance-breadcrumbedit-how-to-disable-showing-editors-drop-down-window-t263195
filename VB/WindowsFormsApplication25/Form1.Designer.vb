Namespace WindowsFormsApplication25
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim breadCrumbNode1 As New DevExpress.XtraEditors.BreadCrumbNode()
            Dim breadCrumbNode2 As New DevExpress.XtraEditors.BreadCrumbNode()
            Dim breadCrumbNode3 As New DevExpress.XtraEditors.BreadCrumbNode()
            Dim breadCrumbNode4 As New DevExpress.XtraEditors.BreadCrumbNode()
            Dim breadCrumbNode5 As New DevExpress.XtraEditors.BreadCrumbNode()
            Dim breadCrumbNode6 As New DevExpress.XtraEditors.BreadCrumbNode()
            Dim breadCrumbNode7 As New DevExpress.XtraEditors.BreadCrumbNode()
            Dim breadCrumbNode8 As New DevExpress.XtraEditors.BreadCrumbNode()
            Dim breadCrumbNode9 As New DevExpress.XtraEditors.BreadCrumbNode()
            Dim breadCrumbNode10 As New DevExpress.XtraEditors.BreadCrumbNode()
            Dim breadCrumbNode11 As New DevExpress.XtraEditors.BreadCrumbNode()
            Dim breadCrumbNode12 As New DevExpress.XtraEditors.BreadCrumbNode()
            Dim breadCrumbNode13 As New DevExpress.XtraEditors.BreadCrumbNode()
            Dim breadCrumbNode14 As New DevExpress.XtraEditors.BreadCrumbNode()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.customBreadCrumbEdit1 = New WindowsFormsApplication25.CustomBreadCrumbEdit()
            DirectCast(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.customBreadCrumbEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.EditValue = True
            Me.checkEdit1.Location = New System.Drawing.Point(39, 46)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "AllowSelectedState"
            Me.checkEdit1.Size = New System.Drawing.Size(184, 19)
            Me.checkEdit1.TabIndex = 1
            ' 
            ' customBreadCrumbEdit1
            ' 
            Me.customBreadCrumbEdit1.Location = New System.Drawing.Point(39, 95)
            Me.customBreadCrumbEdit1.Name = "customBreadCrumbEdit1"
            Me.customBreadCrumbEdit1.Properties.AllowDropDownButtonSelectedState = False
            Me.customBreadCrumbEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            breadCrumbNode1.Caption = "Root"
            breadCrumbNode2.Caption = "BreadCrumbNode1"
            breadCrumbNode3.Caption = "BreadCrumbNode11"
            breadCrumbNode3.Value = "BreadCrumbNode11"
            breadCrumbNode4.Caption = "BreadCrumbNode12"
            breadCrumbNode4.Value = "BreadCrumbNode12"
            breadCrumbNode5.Caption = "BreadCrumbNode13"
            breadCrumbNode5.Value = "BreadCrumbNode13"
            breadCrumbNode2.ChildNodes.AddRange(New DevExpress.XtraEditors.BreadCrumbNode() { breadCrumbNode3, breadCrumbNode4, breadCrumbNode5})
            breadCrumbNode2.Value = "BreadCrumbNode1"
            breadCrumbNode6.Caption = "BreadCrumbNode2"
            breadCrumbNode6.Value = "BreadCrumbNode2"
            breadCrumbNode7.Caption = "BreadCrumbNode3"
            breadCrumbNode7.Value = "BreadCrumbNode3"
            breadCrumbNode1.ChildNodes.AddRange(New DevExpress.XtraEditors.BreadCrumbNode() { breadCrumbNode2, breadCrumbNode6, breadCrumbNode7})
            breadCrumbNode1.Value = "Root"
            breadCrumbNode8.Caption = "BreadCrumbNode4"
            breadCrumbNode9.Caption = "BreadCrumbNode9"
            breadCrumbNode9.Value = "BreadCrumbNode9"
            breadCrumbNode10.Caption = "BreadCrumbNode10"
            breadCrumbNode10.Value = "BreadCrumbNode10"
            breadCrumbNode8.ChildNodes.AddRange(New DevExpress.XtraEditors.BreadCrumbNode() { breadCrumbNode9, breadCrumbNode10})
            breadCrumbNode8.Value = "BreadCrumbNode4"
            breadCrumbNode11.Caption = "BreadCrumbNode5"
            breadCrumbNode12.Caption = "BreadCrumbNode6"
            breadCrumbNode12.Value = "BreadCrumbNode6"
            breadCrumbNode13.Caption = "BreadCrumbNode7"
            breadCrumbNode13.Value = "BreadCrumbNode7"
            breadCrumbNode14.Caption = "BreadCrumbNode8"
            breadCrumbNode14.Value = "BreadCrumbNode8"
            breadCrumbNode11.ChildNodes.AddRange(New DevExpress.XtraEditors.BreadCrumbNode() { breadCrumbNode12, breadCrumbNode13, breadCrumbNode14})
            breadCrumbNode11.Value = "BreadCrumbNode5"
            Me.customBreadCrumbEdit1.Properties.Nodes.AddRange(New DevExpress.XtraEditors.BreadCrumbNode() { breadCrumbNode1, breadCrumbNode8, breadCrumbNode11})
            Me.customBreadCrumbEdit1.Properties.SelectedNode = breadCrumbNode5
            Me.customBreadCrumbEdit1.Size = New System.Drawing.Size(384, 22)
            Me.customBreadCrumbEdit1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(524, 186)
            Me.Controls.Add(Me.checkEdit1)
            Me.Controls.Add(Me.customBreadCrumbEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.customBreadCrumbEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private customBreadCrumbEdit1 As CustomBreadCrumbEdit
        Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
    End Class
End Namespace

