namespace CheckBox
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }
        bool skip = false;
        private void SelectAll_StateChanged(object sender, Syncfusion.Maui.Buttons.StateChangedEventArgs e)
        {
            if (!skip)
            {
                skip = true;
                pepperoni.IsChecked = beef.IsChecked = mushroom.IsChecked = onion.IsChecked = e.IsChecked;
                skip = false;
            }
        }

        private void CheckBox_StateChanged(object sender, Syncfusion.Maui.Buttons.StateChangedEventArgs e)
        {
            if (!skip)
            {
                skip = true;
                if (pepperoni.IsChecked.Value && beef.IsChecked.Value && mushroom.IsChecked.Value && onion.IsChecked.Value)
                    selectAll.IsChecked = true;
                else if (!pepperoni.IsChecked.Value && !beef.IsChecked.Value && !mushroom.IsChecked.Value && !onion.IsChecked.Value)
                    selectAll.IsChecked = false;
                else
                    selectAll.IsChecked = null;
                skip = false;
            }
        }

    }

}
