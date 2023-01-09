Imports DevExpress.Mvvm.UI.Interactivity
Imports DevExpress.Xpf.Grid

Namespace GridMultiTouchProject

    Friend Class GridMultiTouchBehavior
        Inherits Behavior(Of GridControl)

        Protected Overrides Sub OnAttached()
            MyBase.OnAttached()
            owner = AssociatedObject
            AddHandler owner.MouseRightButtonUp, AddressOf owner_MouseRightButtonUp
            AddHandler owner.MouseLeftButtonDown, AddressOf owner_MouseLeftButtonDown
            _isCanMultiSelect = False
        End Sub

        Private _startRowSelect As Integer

        Private _finishRowSelect As Integer

        Private owner As GridControl

        Private _isMultiSelection As Boolean

        Private _isCanMultiSelect As Boolean

        Private tableView1 As TableView

        Private Sub SelectRows()
            owner.UnselectAll()
            owner.SelectRange(_startRowSelect, _finishRowSelect)
        End Sub

        Private Sub tableView1_ShowingEditor(ByVal sender As Object, ByVal e As ShowingEditorEventArgs)
            If _isMultiSelection Then e.Cancel = True
        End Sub

        Private Sub owner_MouseLeftButtonDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
            If _isMultiSelection Then _isMultiSelection = False
        End Sub

        Private Sub owner_MouseRightButtonUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
            If tableView1 Is Nothing Then
                tableView1 = TryCast(owner.View, TableView)
                If tableView1 IsNot Nothing Then
                    AddHandler tableView1.ShowingEditor, AddressOf tableView1_ShowingEditor
                    _isCanMultiSelect = True
                End If
            End If

            If _isCanMultiSelect Then
                If Not _isMultiSelection Then
                    _isMultiSelection = True
                    _startRowSelect = tableView1.FocusedRowHandle
                    _finishRowSelect = tableView1.FocusedRowHandle
                    tableView1.CancelRowEdit()
                    SelectRows()
                Else
                    _finishRowSelect = tableView1.FocusedRowHandle
                    SelectRows()
                End If
            End If
        End Sub
    End Class
End Namespace
