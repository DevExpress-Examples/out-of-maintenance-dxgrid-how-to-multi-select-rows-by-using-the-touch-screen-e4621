Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls

Namespace GridMultiTouchProject

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            ListPerson = New List(Of Person)()
            CreatePerson()
            DataContext = Me
        End Sub

        Public Property ListPerson As List(Of Person)

        Private Sub CreatePerson()
            For i As Integer = 0 To 50 - 1
                ListPerson.Add(New Person(i))
            Next
        End Sub
    End Class

    Public Class Person

        Public Sub New(ByVal i As Integer)
            FirstName = String.Format("FirstName - {0}", i)
            LastName = String.Format("LastName - {0}", i)
        End Sub

        Public Property FirstName As String

        Public Property LastName As String
    End Class
End Namespace
