<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alumni
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alumni))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Footer_PNL = New DevExpress.XtraEditors.PanelControl()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.compname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.job_tb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.acadyear = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.studid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Footer_PNL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Footer_PNL.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(200, 100)
        Me.PanelControl1.TabIndex = 0
        '
        'Footer_PNL
        '
        Me.Footer_PNL.Controls.Add(Me.Button2)
        Me.Footer_PNL.Controls.Add(Me.Button1)
        Me.Footer_PNL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Footer_PNL.Location = New System.Drawing.Point(2, 204)
        Me.Footer_PNL.Name = "Footer_PNL"
        Me.Footer_PNL.Size = New System.Drawing.Size(560, 47)
        Me.Footer_PNL.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(333, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "SAVE"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(427, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CANCEL"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.PanelControl3)
        Me.PanelControl2.Controls.Add(Me.Footer_PNL)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(564, 253)
        Me.PanelControl2.TabIndex = 1
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.TextBox6)
        Me.PanelControl3.Controls.Add(Me.compname)
        Me.PanelControl3.Controls.Add(Me.Label3)
        Me.PanelControl3.Controls.Add(Me.job_tb)
        Me.PanelControl3.Controls.Add(Me.Label2)
        Me.PanelControl3.Controls.Add(Me.acadyear)
        Me.PanelControl3.Controls.Add(Me.Label1)
        Me.PanelControl3.Controls.Add(Me.studid)
        Me.PanelControl3.Controls.Add(Me.Label7)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(560, 202)
        Me.PanelControl3.TabIndex = 2
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Silver
        Me.TextBox6.Font = New System.Drawing.Font("Stencil Std", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(-2, -2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(564, 35)
        Me.TextBox6.TabIndex = 25
        Me.TextBox6.Text = "Alum Information"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'compname
        '
        Me.compname.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compname.Location = New System.Drawing.Point(241, 166)
        Me.compname.Name = "compname"
        Me.compname.Size = New System.Drawing.Size(311, 26)
        Me.compname.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 18)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Company Name:"
        '
        'job_tb
        '
        Me.job_tb.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.job_tb.Location = New System.Drawing.Point(240, 126)
        Me.job_tb.Name = "job_tb"
        Me.job_tb.Size = New System.Drawing.Size(311, 26)
        Me.job_tb.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(170, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Job:"
        '
        'acadyear
        '
        Me.acadyear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acadyear.Location = New System.Drawing.Point(240, 90)
        Me.acadyear.Name = "acadyear"
        Me.acadyear.Size = New System.Drawing.Size(311, 26)
        Me.acadyear.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Academic Year Graduated:"
        '
        'studid
        '
        Me.studid.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studid.Location = New System.Drawing.Point(240, 55)
        Me.studid.Name = "studid"
        Me.studid.Size = New System.Drawing.Size(311, 26)
        Me.studid.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(116, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Student ID:"
        '
        'Alumni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 253)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Alumni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alumni"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Footer_PNL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Footer_PNL.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Footer_PNL As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents compname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents job_tb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents acadyear As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents studid As TextBox
    Friend WithEvents Label7 As Label
End Class
