# Rounded corner in ListViewItem

The SfListView allows customizing the item appearance like rounded corner by using the Frame layout in the ItemTemplate property. By defining the CornerRadius property of frame layout, you can perform the rounded corner for items.

```
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms">
    <ContentPage.Content>
        <syncfusion:SfListView x:Name="listView" ItemSize="60" ItemsSource="{Binding customerDetails}">
            <syncfusion:SfListView.ItemTemplate>
                <DataTemplate>
                    <Frame x:Name="frame" CornerRadius="10" >
                        <StackLayout>
                                <Label Text="{Binding ContactName}" />
                                <Label Text="{Binding ContactNumber}" />
                                <Label Text="{Binding ContactType}" />
                        </StackLayout>
                    </Frame>
                </DataTemplate>
            </syncfusion:SfListView.ItemTemplate>
        </syncfusion:SfListView>
    </ContentPage.Content>
</ContentPage>
```

To know more about ListView appearance, please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/viewappearance#rounded-corner-on-items)