using Syncfusion.DataSource;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using ListSortDirection = Syncfusion.DataSource.ListSortDirection;

namespace Sorting
{
   public class Behavior : Behavior<ContentPage>
    {
        #region Fields

        SfListView ListView;
        static bool isAscending = true;
        Button sortButton;
        
        #endregion
        protected override void OnAttachedTo(ContentPage bindable)
        {
            sortButton = bindable.FindByName<Button>("sortButton");
            ListView = bindable.FindByName<SfListView>("listView");
            sortButton.Clicked += SortButton_Clicked;
            base.OnAttachedTo(bindable);
        }

        private void SortButton_Clicked(object sender, EventArgs e)
        {
            //Applying Sorting when sort button is clicked
            var button = (sender as Button);
            ListView.DataSource.SortDescriptors.Clear();
            ListView.DataSource.SortDescriptors.Add(new SortDescriptor()
            {
                PropertyName = "ContactName",
                Direction = isAscending ? Syncfusion.DataSource.ListSortDirection.Ascending : ListSortDirection.Descending
            });

            isAscending = isAscending ? false : true;
        }
        
    }
}
