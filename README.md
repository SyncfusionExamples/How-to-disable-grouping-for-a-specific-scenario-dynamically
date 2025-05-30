The [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) allows you to disable grouping dynamically by clearing the `GroupColumnDescriptions` collection. Additionally, if you want to remove grouping when there's only one group, you can use the following code snippet. The code below illustrates how to dynamically disable grouping for a specific scenario.


 ##### C#
 ```c#
public MainPage()
{
	InitializeComponent();
	viewModel.InstalledModels.CollectionChanged += InstalledModels_CollectionChanged;
}

private void InstalledModels_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
{
	if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
	{
		if (datagrid.View!.Groups.Count() == 1)
		{
			datagrid.GroupColumnDescriptions.Clear();
		}
	}
}
 ```
 


Download the complete sample from [GitHub](https://github.com/SyncfusionExamples/How-to-disable-grouping-for-a-specific-scenario-dynamically/tree/Dynamic_Change_Grouping)

##### Conclusion

I hope you enjoyed learning how to disable grouping for a specific scenario dynamically. You can refer to our [.NET MAUI DataGrid feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking features. Explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. For current customers, check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/account/downloads) page. If you are new to Syncfusion®, try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components. Please let us know in the comments section if you have any queries or require clarification. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or feedback portal. We are always happy to assist you!
