<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class htmlEditZoople
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(htmlEditZoople))
		Me.oEdit = New Zoople.HTMLEditControl()
		Me.SuspendLayout()
		'
		'oEdit
		'
		Me.oEdit.AcceptsReturn = True
		Me.oEdit.AvailableInlineStyles = CType(resources.GetObject("oEdit.AvailableInlineStyles"), System.Collections.Generic.List(Of String))
		Me.oEdit.BaseURL = Nothing
		Me.oEdit.CleanMSWordHTMLOnPaste = True
		Me.oEdit.CodeEditor.Enabled = True
		Me.oEdit.CodeEditor.Locked = False
		Me.oEdit.CodeEditor.TabWidth = 720
		Me.oEdit.CodeEditor.WordWrap = False
		Me.oEdit.CSSText = "body {font-family: Arial; font-size: 12pt}"
		Me.oEdit.CustomColorPalette = Nothing
		Me.oEdit.Dock = System.Windows.Forms.DockStyle.Fill
		Me.oEdit.DocumentHTML = Nothing
		Me.oEdit.DuplicateBasicTextFormattingAfterEnterKey = False
		Me.oEdit.EnableInlineSpelling = False
		Me.oEdit.FontSizesList = Nothing
		Me.oEdit.FontsList = Nothing
		Me.oEdit.HiddenButtons = "tsbElementproperties;tsbPrint;tsbCut;tsbCopy;tsbPaste;tsbSuperscript;tsbSubscript" &
	";tsbInsertSymbol;tsbPrintpreview"
		Me.oEdit.HideDOMToolbar = True
		Me.oEdit.ImageStorageLocation = Nothing
		Me.oEdit.InCodeView = False
		Me.oEdit.LanguageFile = Nothing
		Me.oEdit.LicenceActivationKey = resources.GetString("oEdit.LicenceActivationKey")
		Me.oEdit.LicenceKey = "KPH1019-8340-1D83"
		Me.oEdit.LicenceKeyInlineSpelling = "AMB1124-9547-2395-F58A"
		Me.oEdit.Location = New System.Drawing.Point(0, 0)
		Me.oEdit.Name = "oEdit"
		Me.oEdit.Size = New System.Drawing.Size(692, 345)
		Me.oEdit.SpellingAutoCorrectionList = CType(resources.GetObject("oEdit.SpellingAutoCorrectionList"), System.Collections.Hashtable)
		Me.oEdit.TabIndex = 34
		Me.oEdit.ToolstripImageScalingSize = New System.Drawing.Size(16, 16)
		Me.oEdit.UseParagraphAsDefault = True
		'
		'htmlEditZoople
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.oEdit)
		Me.Name = "htmlEditZoople"
		Me.Size = New System.Drawing.Size(692, 345)
		Me.ResumeLayout(False)

	End Sub

	Public WithEvents oEdit As Zoople.HTMLEditControl
End Class
