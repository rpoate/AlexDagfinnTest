<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.HtmlEditZoople1 = New AlexDagfinnTest.htmlEditZoople()
        Me.SuspendLayout()
        '
        'HtmlEditZoople1
        '
        Me.HtmlEditZoople1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HtmlEditZoople1.DefaultFontsize = 3
        Me.HtmlEditZoople1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HtmlEditZoople1.Location = New System.Drawing.Point(0, 0)
        Me.HtmlEditZoople1.Name = "HtmlEditZoople1"
        Me.HtmlEditZoople1.Size = New System.Drawing.Size(800, 450)
        Me.HtmlEditZoople1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.HtmlEditZoople1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HtmlEditZoople1 As htmlEditZoople
End Class
