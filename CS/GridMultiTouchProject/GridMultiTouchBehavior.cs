using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interactivity;
using DevExpress.Xpf.Grid;

namespace GridMultiTouchProject {
    class GridMultiTouchBehavior : Behavior<GridControl> {
        protected override void OnAttached() {
            base.OnAttached();
            owner = this.AssociatedObject;
            owner.MouseRightButtonUp += owner_MouseRightButtonUp;
            owner.MouseLeftButtonDown += owner_MouseLeftButtonDown;
            _isCanMultiSelect = false;
        }
        int _startRowSelect;
        int _finishRowSelect;
        GridControl owner;
        bool _isMultiSelection;
        bool _isCanMultiSelect;
        TableView tableView1;

        void SelectRows() {
            this.tableView1.ClearSelection();
            this.tableView1.SelectRange(_startRowSelect, _finishRowSelect);
        }

        void tableView1_ShowingEditor(object sender, ShowingEditorEventArgs e) {
            if(_isMultiSelection)
                e.Cancel = true;
        }
        void owner_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) {
            if(_isMultiSelection)
                _isMultiSelection = false;
        }
        void owner_MouseRightButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e) {
            if(tableView1 == null) {
                tableView1 = owner.View as TableView;
                if(tableView1 != null) {
                    tableView1.ShowingEditor += tableView1_ShowingEditor;
                    _isCanMultiSelect = true;
                }
            }
            if(_isCanMultiSelect) {
                if(!_isMultiSelection) {
                    _isMultiSelection = true;
                    _startRowSelect = this.tableView1.FocusedRowHandle;
                    _finishRowSelect = this.tableView1.FocusedRowHandle;
                    this.tableView1.CancelRowEdit();
                    SelectRows();
                }
                else {
                    _finishRowSelect = this.tableView1.FocusedRowHandle;
                    SelectRows();
                }
            }
        }
    }
}
