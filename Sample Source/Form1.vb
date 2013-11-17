Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHijri As System.Windows.Forms.TextBox
    Friend WithEvents txtGregorian As System.Windows.Forms.TextBox
    Friend WithEvents txtJalali As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGregorianDays As System.Windows.Forms.TextBox
    Friend WithEvents txtJalaliDays As System.Windows.Forms.TextBox
    Friend WithEvents txtHijriDays As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtHijri = New System.Windows.Forms.TextBox
        Me.txtGregorian = New System.Windows.Forms.TextBox
        Me.txtJalali = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtHijriDays = New System.Windows.Forms.TextBox
        Me.txtGregorianDays = New System.Windows.Forms.TextBox
        Me.txtJalaliDays = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHijri)
        Me.GroupBox1.Controls.Add(Me.txtGregorian)
        Me.GroupBox1.Controls.Add(Me.txtJalali)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 112)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Today"
        '
        'txtHijri
        '
        Me.txtHijri.Location = New System.Drawing.Point(96, 72)
        Me.txtHijri.Name = "txtHijri"
        Me.txtHijri.TabIndex = 11
        Me.txtHijri.Text = ""
        '
        'txtGregorian
        '
        Me.txtGregorian.Location = New System.Drawing.Point(96, 48)
        Me.txtGregorian.Name = "txtGregorian"
        Me.txtGregorian.TabIndex = 10
        Me.txtGregorian.Text = ""
        '
        'txtJalali
        '
        Me.txtJalali.Location = New System.Drawing.Point(96, 24)
        Me.txtJalali.Name = "txtJalali"
        Me.txtJalali.TabIndex = 6
        Me.txtJalali.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Hijri:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Gregorian:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Jalali:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtHijriDays)
        Me.GroupBox2.Controls.Add(Me.txtGregorianDays)
        Me.GroupBox2.Controls.Add(Me.txtJalaliDays)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(264, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 112)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Days in Month"
        '
        'txtHijriDays
        '
        Me.txtHijriDays.Location = New System.Drawing.Point(96, 72)
        Me.txtHijriDays.Name = "txtHijriDays"
        Me.txtHijriDays.TabIndex = 11
        Me.txtHijriDays.Text = ""
        '
        'txtGregorianDays
        '
        Me.txtGregorianDays.Location = New System.Drawing.Point(96, 48)
        Me.txtGregorianDays.Name = "txtGregorianDays"
        Me.txtGregorianDays.TabIndex = 10
        Me.txtGregorianDays.Text = ""
        '
        'txtJalaliDays
        '
        Me.txtJalaliDays.Location = New System.Drawing.Point(96, 24)
        Me.txtJalaliDays.Name = "txtJalaliDays"
        Me.txtJalaliDays.TabIndex = 6
        Me.txtJalaliDays.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Hijri:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Gregorian:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Jalali:"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(496, 150)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dtToday As New XDate(Now.Year, Now.Month, Now.Day)
        txtGregorian.Text = dtToday.Day & "/" & dtToday.Month & "/" & dtToday.Year
        txtGregorianDays.Text = dtToday.GetDaysInMothGregorian

        dtToday = dtToday.GregorianToJalali
        txtJalali.Text = dtToday.Day & "/" & dtToday.Month & "/" & dtToday.Year
        txtJalaliDays.Text = dtToday.GetDaysInMothJalali

        dtToday = dtToday.JalaliToHijri
        txtHijri.Text = dtToday.Day & "/" & dtToday.Month & "/" & dtToday.Year
        txtHijriDays.Text = dtToday.GetDaysInMothHijri

    End Sub
End Class
