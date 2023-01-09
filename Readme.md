<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128647627/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4621)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Data Grid - Select Multiple Rows with the Touch Screen

This example allows touchscreen users to select a range of rows.

1. Create a behavior that implements the following capabilities:
   * Press and hold a row to select the first selected item.
   * Press and hold a row to select the last selected item.
   * Tap a row to reset the selection.
2. Attach this behavior to the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl).
3. Set the [DataControlBase.SelectionMode](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.SelectionMode) property to `Row`.

## Files to Review

* [GridMultiTouchBehavior.cs](./CS/GridMultiTouchProject/GridMultiTouchBehavior.cs) (VB: [GridMultiTouchBehavior.vb](./VB/GridMultiTouchProject/GridMultiTouchBehavior.vb))
* [MainWindow.xaml](./CS/GridMultiTouchProject/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/GridMultiTouchProject/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/GridMultiTouchProject/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/GridMultiTouchProject/MainWindow.xaml.vb))

## Documentation

* [Multiple Row Selection](https://docs.devexpress.com/WPF/7359/controls-and-libraries/data-grid/focus-navigation-selection/multiple-row-selection)
* [DataControlBase.SelectionMode](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.SelectionMode)

## More Examples

* [WPF Data Grid - Select Rows that Contain a Specific Value](https://github.com/DevExpress-Examples/wpf-data-grid-select-rows-that-contain-specific-value)
* [WPF Data Grid - Bind Selected Rows to a ViewModel Property](https://github.com/DevExpress-Examples/wpf-data-grid-bind-selected-rows-to-viewmodel-property)
* [WPF Data Grid - Change the Appearance of Focused and Selected Rows](https://github.com/DevExpress-Examples/how-to-change-the-appearance-of-a-focused-data-row-and-selected-rows-e2066)
