Imports System.Drawing
Imports System.Reflection
Imports Zoople

Public Class htmlEditZoople
	Implements IDisposable

	Public Shadows Event TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

	Public ReadOnly Property DocumentHTML As String
		Get
			Return oEdit.DocumentHTML
		End Get
	End Property

	Private Sub SpellCheckButton_Click(sender As Object, e As EventArgs)
		Me.oEdit.SpellCheckDocument(False)
	End Sub

	Private _defaultFont As FontFamily = Nothing
	Public Property DefaultFontProperty() As FontFamily
		Get
			If _defaultFont Is Nothing Then
				Return New FontFamily("Arial")
			End If
			Return _defaultFont
		End Get
		Set(ByVal value As FontFamily)
			_defaultFont = value
		End Set
	End Property
	Private _defaultFontSize As Integer = 10
	Public Property DefaultFontsize() As Integer
		Get
			Return _defaultFontSize
		End Get
		Set(ByVal value As Integer)
			_defaultFontSize = value
		End Set
	End Property

	Private _docComplete As Boolean = False
	Private _text As String = String.Empty
	Private Sub HtmlEditControl1_DocumentLoadComplete(sender As Object, e As EventArgs) Handles oEdit.DocumentLoadComplete
		If oEdit.EnableInlineSpelling Then
			Me.oEdit.SpellCheckDocument(False)
		End If
		_docComplete = True
		SetDefaultFontsInText()
	End Sub

	Private Sub SetDefaultFontsInText()
		Dim _Text As String = oEdit.DocumentHTML
		'If String.IsNullOrEmpty(_Text) Then
		'	oEdit.DocumentHTML = "<font face='" & DefaultFontProperty.Name & "' size='" & DefaultFontsize & "'></font>"
		'ElseIf _Text.Contains("<font ") Then
		'	Return
		'Else
		'	oEdit.DocumentHTML = "<font face='" & DefaultFontProperty.Name & "' size='" & DefaultFontsize & "'>" & _Text & "</font>"
		'End If

		SetDefaultFontFamily(DefaultFontProperty, DefaultFontsize)
		'SetExecCommand("FontName", False, DefaultFontProperty.Name)
		'SetExecCommand("FontSize", False, DefaultFontsize)
	End Sub

	Private Sub htmlEditZoople_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Dim oSpellCheckButton As ToolStripItem

		oSpellCheckButton = Me.oEdit.ToolStripItems.Add("Spell Check")
		oSpellCheckButton.Padding = New Padding(3)
		AddHandler oSpellCheckButton.Click, AddressOf SpellCheckButton_Click

		Dim oDefaultFontButton As ToolStripItem

		oDefaultFontButton = Me.oEdit.ToolStripItems.Add("Font to Courier")
		oDefaultFontButton.Padding = New Padding(3)
		AddHandler oDefaultFontButton.Click, AddressOf DefFontClick

		Me.oEdit.EnableInlineSpelling = True

		' add some custom autotext replacements
		Me.oEdit.SpellingAutoCorrectionList.Add("cw", "&copy;")
		Me.oEdit.SpellingAutoCorrectionList.Add("td", "trademark")
		Me.oEdit.SpellingAutoCorrectionList.Add("pp", "<span style='color:red'>pianissimo</span>")

		Me.oEdit.FontSizesList = "5pt; 8pt; 10pt; 12pt; 15pt; 18pt;"
		If _docComplete Then
			Me.oEdit.SpellCheckDocument(False)
		End If
	End Sub

	Private Sub DefFontClick(sender As Object, e As EventArgs)

		oEdit.CSSText = "body {font-family: courier new;}"
	End Sub

	Public Sub SetDefaultFontFamily(fontFamily As FontFamily, fontSize As Integer)
		_defaultFont = fontFamily
		_defaultFontSize = fontSize

		oEdit.CSSText = "body {font-family: " & fontFamily.Name & "; font-size: " & fontSize & "pt;}"

		'SetDefaultFontsInText()
	End Sub

	Public Sub InsertAtCursor(link As String, ed_InsertReplaceSelection As HTMLEditControl.ed_InsertType)
		oEdit.InsertAtCursor(link, ed_InsertReplaceSelection)
	End Sub

	Public Sub InsertAtCursor(link As String)
		oEdit.InsertAtCursor(link, HTMLEditControl.ed_InsertType.ed_InsertReplaceSelection)
	End Sub

	Public Sub InsertText(text As String)
		InsertAtCursor(text)
	End Sub

	Public Sub ResetDocument()
		_docComplete = False
		oEdit.DocumentHTML = String.Empty
	End Sub

	Public ReadOnly Property InnerHtml() As String
		Get
			Return oEdit.Document.Body.InnerHtml
		End Get
	End Property

	Public Overrides Property Text As String
		Get
			Return oEdit.DocumentHTML
		End Get
		Set(value As String)
			oEdit.DocumentHTML = value
		End Set
	End Property

	Public Overloads Sub Dispose() Implements System.IDisposable.Dispose
		If Not oEdit Is Nothing Then
			oEdit.DocumentHTML = Nothing
			oEdit.Dispose()
			oEdit = Nothing
		End If

		MyBase.Dispose()
	End Sub

	Protected Overrides Sub Finalize()
		Dispose()
	End Sub

	Private Sub SetExecCommand(command As String, showui As Boolean, value As Object)
		If _docComplete = False Then
			Exit Sub
		End If
		Try
			oEdit.Document.ExecCommand(command, showui, value)
		Catch ex As Exception
		End Try

	End Sub

	Private Sub oEdit_HTMLChanged(sender As Object, e As EventArgs) Handles oEdit.HTMLChanged
		RaiseEvent TextChanged(Me, New System.EventArgs)
	End Sub
End Class
