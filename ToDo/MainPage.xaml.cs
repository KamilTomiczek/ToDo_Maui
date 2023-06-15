namespace ToDo;

public partial class MainPage : ContentPage
{
    Color checkBoxColor;

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

    private void CheckBoxCheckedChange(object sender, CheckedChangedEventArgs e)
    {
        var checkBox = sender as CheckBox;
        checkBox.Color = Color.FromArgb("#666");

        var parent = checkBox.Parent as Layout;

        var label = parent.FirstOrDefault(c => c.GetType() == typeof(Label)) as Label;

        if (checkBox.IsChecked)
        {
            label.TextDecorations = TextDecorations.Strikethrough;
            label.TextColor = Color.FromArgb("#666");
            parent.Background = Color.FromArgb("#c8c7c9");
            checkBox.Color = Color.FromArgb("#512BD4");
        }
        else
        {
            label.TextDecorations = TextDecorations.None;
            label.TextColor = Color.FromArgb("#000");
            parent.Background = Color.FromArgb("#e7defc");
        }
    }
}

