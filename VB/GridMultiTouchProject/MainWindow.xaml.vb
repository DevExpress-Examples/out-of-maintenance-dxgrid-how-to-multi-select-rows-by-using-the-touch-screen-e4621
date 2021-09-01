Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes


Namespace GridMultiTouchProject
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			ListPerson = New List(Of Person)()
			CreatePerson()
			DataContext = Me
		End Sub
	  Public Property ListPerson() As List(Of Person)
		Private Sub CreatePerson()
			For i As Integer = 0 To 49
				ListPerson.Add(New Person(i))
			Next i
		End Sub
	End Class
	Public Class Person
		Public Sub New(ByVal i As Integer)
			FirstName = String.Format("FirstName - {0}", i)
			LastName = String.Format("LastName - {0}", i)
		End Sub
		Public Property FirstName() As String
		Public Property LastName() As String

	End Class

End Namespace
