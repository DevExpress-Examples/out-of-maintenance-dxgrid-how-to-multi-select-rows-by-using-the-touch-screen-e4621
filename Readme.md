<!-- default file list -->
*Files to look at*:

* [GridMultiTouchBehavior.cs](./CS/GridMultiTouchProject/GridMultiTouchBehavior.cs) (VB: [GridMultiTouchBehavior.vb](./VB/GridMultiTouchProject/GridMultiTouchBehavior.vb))
* [MainWindow.xaml](./CS/GridMultiTouchProject/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/GridMultiTouchProject/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/GridMultiTouchProject/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/GridMultiTouchProject/MainWindow.xaml))
<!-- default file list end -->
# DXGrid: how to Multi- select rows by using the touch screen.


<p>To implement it, you can create an attached behavior as shown below.</p><p><br />
1. To create an attached behavior, you can add a reference on the library System.Windows.Interactivity. (you may find it at /DevExpress/Dxepirience XX.X/Bin/Framework/System.Windows.Interactivity.dll)</p><p><br />
2. On creation of this behavior you have this additional capability:</p><p>- press and hold to select start row.</p><p>- press and hold to select finish row. (you can select the finish row multiple times)</p><p>- tap any row to deselect rows.</p><p><br />
For this example, your grid's View should be TableView and property MultiSelectMode should be Row.</p>

<br/>


