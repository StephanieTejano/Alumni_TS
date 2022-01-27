Partial Public Class Form1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.AcadYear = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Blank1 = New Alumni_TS.blank()
        Me.ControlGuardian1 = New Alumni_TS.ControlGuardian()
        Me.ControlMembership1 = New Alumni_TS.ControlMembership()
        Me.ControlProfessors1 = New Alumni_TS.ControlProfessors()
        Me.ControlAlumni1 = New Alumni_TS.ControlAlumni()
        Me.ControlStudent1 = New Alumni_TS.ControlStudent()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.AcadYear, Me.BarButtonItem6, Me.BarButtonItem7})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ribbonControl1.MaxItemId = 16
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.Size = New System.Drawing.Size(907, 179)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Server Settings"
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Student"
        Me.BarButtonItem2.Id = 4
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Alumni"
        Me.BarButtonItem3.Id = 5
        Me.BarButtonItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Professor"
        Me.BarButtonItem4.Id = 6
        Me.BarButtonItem4.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Add User"
        Me.BarButtonItem5.Id = 7
        Me.BarButtonItem5.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem5.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'AcadYear
        '
        Me.AcadYear.Caption = "Academic Year"
        Me.AcadYear.Id = 9
        Me.AcadYear.ImageOptions.Image = CType(resources.GetObject("AcadYear.ImageOptions.Image"), System.Drawing.Image)
        Me.AcadYear.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcadYear.ItemAppearance.Normal.Options.UseFont = True
        Me.AcadYear.Name = "AcadYear"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Membership"
        Me.BarButtonItem6.Id = 10
        Me.BarButtonItem6.ImageOptions.Image = CType(resources.GetObject("BarButtonItem6.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Guardian"
        Me.BarButtonItem7.Id = 15
        Me.BarButtonItem7.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem7.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4, Me.RibbonPageGroup5})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "Home"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem5)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "Server Settings"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem7)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Student"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Alumni"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Professor"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.AcadYear)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Membership"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Blank1)
        Me.PanelControl1.Controls.Add(Me.ControlGuardian1)
        Me.PanelControl1.Controls.Add(Me.ControlMembership1)
        Me.PanelControl1.Controls.Add(Me.ControlProfessors1)
        Me.PanelControl1.Controls.Add(Me.ControlAlumni1)
        Me.PanelControl1.Controls.Add(Me.ControlStudent1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 179)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(907, 562)
        Me.PanelControl1.TabIndex = 1
        '
        'Blank1
        '
        Me.Blank1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Blank1.Location = New System.Drawing.Point(2, 2)
        Me.Blank1.Name = "Blank1"
        Me.Blank1.Size = New System.Drawing.Size(903, 558)
        Me.Blank1.TabIndex = 5
        '
        'ControlGuardian1
        '
        Me.ControlGuardian1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlGuardian1.Location = New System.Drawing.Point(2, 2)
        Me.ControlGuardian1.Name = "ControlGuardian1"
        Me.ControlGuardian1.Size = New System.Drawing.Size(903, 558)
        Me.ControlGuardian1.TabIndex = 4
        '
        'ControlMembership1
        '
        Me.ControlMembership1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlMembership1.Location = New System.Drawing.Point(2, 2)
        Me.ControlMembership1.Name = "ControlMembership1"
        Me.ControlMembership1.Size = New System.Drawing.Size(903, 558)
        Me.ControlMembership1.TabIndex = 3
        '
        'ControlProfessors1
        '
        Me.ControlProfessors1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlProfessors1.Location = New System.Drawing.Point(2, 2)
        Me.ControlProfessors1.Name = "ControlProfessors1"
        Me.ControlProfessors1.Size = New System.Drawing.Size(903, 558)
        Me.ControlProfessors1.TabIndex = 2
        '
        'ControlAlumni1
        '
        Me.ControlAlumni1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlAlumni1.Location = New System.Drawing.Point(2, 2)
        Me.ControlAlumni1.Name = "ControlAlumni1"
        Me.ControlAlumni1.Size = New System.Drawing.Size(903, 558)
        Me.ControlAlumni1.TabIndex = 1
        '
        'ControlStudent1
        '
        Me.ControlStudent1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlStudent1.Location = New System.Drawing.Point(2, 2)
        Me.ControlStudent1.Name = "ControlStudent1"
        Me.ControlStudent1.Size = New System.Drawing.Size(903, 558)
        Me.ControlStudent1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 741)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Ribbon = Me.ribbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents AcadYear As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ControlProfessors1 As ControlProfessors
    Friend WithEvents ControlAlumni1 As ControlAlumni
    Friend WithEvents ControlStudent1 As ControlStudent
    Friend WithEvents ControlMembership1 As ControlMembership
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Blank1 As blank
    Friend WithEvents ControlGuardian1 As ControlGuardian
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
End Class
