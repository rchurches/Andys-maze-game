<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSingle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTimersignle = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picboxplayer = New System.Windows.Forms.PictureBox()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFinish = New System.Windows.Forms.Label()
        CType(Me.picboxplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTimersignle
        '
        Me.lblTimersignle.AutoSize = True
        Me.lblTimersignle.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTimersignle.Location = New System.Drawing.Point(753, 18)
        Me.lblTimersignle.Name = "lblTimersignle"
        Me.lblTimersignle.Size = New System.Drawing.Size(35, 20)
        Me.lblTimersignle.TabIndex = 0
        Me.lblTimersignle.Text = "120"
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(812, 72)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(50, 37)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'picboxplayer
        '
        Me.picboxplayer.BackColor = System.Drawing.Color.Black
        Me.picboxplayer.Location = New System.Drawing.Point(115, 80)
        Me.picboxplayer.Name = "picboxplayer"
        Me.picboxplayer.Size = New System.Drawing.Size(20, 20)
        Me.picboxplayer.TabIndex = 2
        Me.picboxplayer.TabStop = False
        '
        'picBack
        '
        Me.picBack.Location = New System.Drawing.Point(1, 1)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(752, 460)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBack.TabIndex = 3
        Me.picBack.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(69, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(479, 10)
        Me.Label1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(69, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 176)
        Me.Label2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(538, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 118)
        Me.Label3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(69, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(479, 10)
        Me.Label4.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(538, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 10)
        Me.Label5.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(613, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 188)
        Me.Label6.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(538, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 118)
        Me.Label7.TabIndex = 10
        '
        'lblFinish
        '
        Me.lblFinish.Image = Global.Andys_maze_game.My.Resources.Resources.finishline
        Me.lblFinish.Location = New System.Drawing.Point(538, 335)
        Me.lblFinish.Name = "lblFinish"
        Me.lblFinish.Size = New System.Drawing.Size(104, 23)
        Me.lblFinish.TabIndex = 11
        '
        'frmSingle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.lblFinish)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picboxplayer)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblTimersignle)
        Me.Controls.Add(Me.picBack)
        Me.KeyPreview = True
        Me.Name = "frmSingle"
        Me.Text = "frmSingle"
        CType(Me.picboxplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTimersignle As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picboxplayer As PictureBox
    Friend WithEvents picBack As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblFinish As Label
End Class
