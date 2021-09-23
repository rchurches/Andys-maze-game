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
        CType(Me.picboxplayer, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'frmSingle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.picboxplayer)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblTimersignle)
        Me.KeyPreview = True
        Me.Name = "frmSingle"
        Me.Text = "frmSingle"
        CType(Me.picboxplayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTimersignle As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picboxplayer As PictureBox
End Class
