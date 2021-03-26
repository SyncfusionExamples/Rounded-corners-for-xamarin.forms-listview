# Rounded corner in ListViewItem

The SfListView allows customizing the item appearance like rounded corner by using the Frame layout in the ItemTemplate property. By defining the CornerRadius property of frame layout, you can perform the rounded corner for items.

You can also refer to the following article.
https://www.syncfusion.com/kb/8493/how-to-achieve-rounded-corner-for-items-in-sflistview

```
<StackLayout Spacing="0" Padding="0,5,0,0" BackgroundColor="LightGray">
    <sync:SfListView x:Name="listView"
                    AutoFitMode="Height"
                    ItemSpacing="5,0,5,10" 
                    IsScrollBarVisible="False"
                    ItemsSource="{Binding BookInfo}">
        <sync:SfListView.ItemTemplate>
            <DataTemplate>
                <Frame Padding="5,5,5,5" CornerRadius="7" HasShadow="False"  BackgroundColor="White">
                    <Grid>
                        ...
                    </Grid>
                </Frame>
            </DataTemplate>
        </sync:SfListView.ItemTemplate>
    </sync:SfListView>
</StackLayout>
```

To know more about ListView appearance, please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/viewappearance#rounded-corner-on-items)
