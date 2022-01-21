<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlStudent
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlStudent))
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.Bar6 = New DevExpress.XtraBars.Bar()
        Me.Bar5 = New DevExpress.XtraBars.Bar()
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.ControlAlumni = New Alumni_TS.ControlAlumni()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MarkAsGraduateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenewMembershipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.add_button = New DevExpress.XtraBars.BarButtonItem()
        Me.edit_button = New DevExpress.XtraBars.BarButtonItem()
        Me.delete_button = New DevExpress.XtraBars.BarButtonItem()
        Me.print_button = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar7 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'Bar6
        '
        Me.Bar6.BarName = "Status bar"
        Me.Bar6.DockCol = 0
        Me.Bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar6.Text = "Status bar"
        '
        'Bar5
        '
        Me.Bar5.BarName = "Main menu"
        Me.Bar5.DockCol = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar5.Text = "Main menu"
        '
        'Bar4
        '
        Me.Bar4.BarName = "Tools"
        Me.Bar4.DockCol = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar4.Text = "Tools"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 59)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(955, 581)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.ControlAlumni)
        Me.PanelControl2.Controls.Add(Me.GridControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(951, 577)
        Me.PanelControl2.TabIndex = 0
        '
        'ControlAlumni
        '
        Me.ControlAlumni.Location = New System.Drawing.Point(459, 115)
        Me.ControlAlumni.Name = "ControlAlumni"
        Me.ControlAlumni.Size = New System.Drawing.Size(8, 8)
        Me.ControlAlumni.TabIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(947, 573)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarkAsGraduateToolStripMenuItem, Me.RenewToolStripMenuItem, Me.RenewMembershipToolStripMenuItem, Me.NewMemberToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(276, 132)
        '
        'MarkAsGraduateToolStripMenuItem
        '
        Me.MarkAsGraduateToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarkAsGraduateToolStripMenuItem.Image = CType(resources.GetObject("MarkAsGraduateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MarkAsGraduateToolStripMenuItem.Name = "MarkAsGraduateToolStripMenuItem"
        Me.MarkAsGraduateToolStripMenuItem.Size = New System.Drawing.Size(275, 32)
        Me.MarkAsGraduateToolStripMenuItem.Text = "Mark As Graduated"
        '
        'RenewToolStripMenuItem
        '
        Me.RenewToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenewToolStripMenuItem.Image = CType(resources.GetObject("RenewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RenewToolStripMenuItem.Name = "RenewToolStripMenuItem"
        Me.RenewToolStripMenuItem.Size = New System.Drawing.Size(275, 32)
        Me.RenewToolStripMenuItem.Text = "Renew Membership"
        '
        'RenewMembershipToolStripMenuItem
        '
        Me.RenewMembershipToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenewMembershipToolStripMenuItem.Image = CType(resources.GetObject("RenewMembershipToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RenewMembershipToolStripMenuItem.Name = "RenewMembershipToolStripMenuItem"
        Me.RenewMembershipToolStripMenuItem.Size = New System.Drawing.Size(275, 32)
        Me.RenewMembershipToolStripMenuItem.Text = "Non-Member"
        '
        'NewMemberToolStripMenuItem
        '
        Me.NewMemberToolStripMenuItem.Image = CType(resources.GetObject("NewMemberToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewMemberToolStripMenuItem.Name = "NewMemberToolStripMenuItem"
        Me.NewMemberToolStripMenuItem.Size = New System.Drawing.Size(275, 32)
        Me.NewMemberToolStripMenuItem.Text = "New Member"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar7})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.add_button, Me.edit_button, Me.delete_button, Me.print_button})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar7
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 1
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.add_button, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.edit_button, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.delete_button, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.print_button, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Text = "Tools"
        '
        'add_button
        '
        Me.add_button.Caption = "Add"
        Me.add_button.Id = 0
        Me.add_button.ImageOptions.Image = CType(resources.GetObject("add_button.ImageOptions.Image"), System.Drawing.Image)
        Me.add_button.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_button.ItemAppearance.Normal.Options.UseFont = True
        Me.add_button.Name = "add_button"
        '
        'edit_button
        '
        Me.edit_button.Caption = "Edit"
        Me.edit_button.Id = 1
        Me.edit_button.ImageOptions.Image = CType(resources.GetObject("edit_button.ImageOptions.Image"), System.Drawing.Image)
        Me.edit_button.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_button.ItemAppearance.Normal.Options.UseFont = True
        Me.edit_button.Name = "edit_button"
        '
        'delete_button
        '
        Me.delete_button.Caption = "Delete"
        Me.delete_button.Id = 2
        Me.delete_button.ImageOptions.Image = CType(resources.GetObject("delete_button.ImageOptions.Image"), System.Drawing.Image)
        Me.delete_button.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_button.ItemAppearance.Normal.Options.UseFont = True
        Me.delete_button.Name = "delete_button"
        '
        'print_button
        '
        Me.print_button.Caption = "Print"
        Me.print_button.Id = 3
        Me.print_button.ImageOptions.Image = CType(resources.GetObject("print_button.ImageOptions.Image"), System.Drawing.Image)
        Me.print_button.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.print_button.ItemAppearance.Normal.Options.UseFont = True
        Me.print_button.Name = "print_button"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        Me.Bar2.Visible = False
        '
        'Bar7
        '
        Me.Bar7.BarName = "Status bar"
        Me.Bar7.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar7.DockCol = 0
        Me.Bar7.DockRow = 0
        Me.Bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar7.OptionsBar.AllowQuickCustomization = False
        Me.Bar7.OptionsBar.DrawDragBorder = False
        Me.Bar7.OptionsBar.UseWholeRow = True
        Me.Bar7.Text = "Status bar"
        Me.Bar7.Visible = False
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(955, 59)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 640)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(955, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 59)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 581)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(955, 59)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 581)
        '
        'ControlStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ControlStudent"
        Me.Size = New System.Drawing.Size(955, 665)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar6 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents add_button As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents edit_button As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents delete_button As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents print_button As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar7 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MarkAsGraduateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenewMembershipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlAlumni As Alumni_TS.ControlAlumni
End Class
