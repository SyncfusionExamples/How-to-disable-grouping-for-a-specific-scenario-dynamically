using Syncfusion.Maui.DataGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample.Helper
{
	public class CustomLoadMoreView : DataGridLoadMoreView
	{
		protected override void OnDraw(ICanvas canvas, RectF dirtyRect)
		{
			return; 
		}
	}
}
