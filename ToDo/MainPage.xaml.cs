namespace ToDo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void ItemTapped(object sender, EventArgs e)
    {
        var layout = sender as Layout;
        var check = layout.FirstOrDefault(c => c.GetType() == typeof(CheckBox));

        if (check != null)
        {
            ((CheckBox)check).IsChecked = !((CheckBox)check).IsChecked;
        }
    }
}

