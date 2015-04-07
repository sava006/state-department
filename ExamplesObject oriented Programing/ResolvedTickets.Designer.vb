<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResolvedTickets
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.lstResolvedtickets = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "resolved tickes "
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(332, 23)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 2
        Me.btn_Save.Text = "save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'lstResolvedtickets
        '
        Me.lstResolvedtickets.FormattingEnabled = True
        Me.lstResolvedtickets.Location = New System.Drawing.Point(84, 147)
        Me.lstResolvedtickets.Name = "lstResolvedtickets"
        Me.lstResolvedtickets.Size = New System.Drawing.Size(464, 173)
        Me.lstResolvedtickets.TabIndex = 3
        '
        'ResolvedTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 332)
        Me.Controls.Add(Me.lstResolvedtickets)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ResolvedTickets"
        Me.Text = "ResolvedTickets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lstResolvedtickets As System.Windows.Forms.ListBox
End Class
