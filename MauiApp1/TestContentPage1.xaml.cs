using MauiApp1.Classes;

namespace MauiApp1;

public partial class TestContentPage1 : ContentPage
{
    public TestContentPage1()
	{
        this.BindingContext = MauiProgram.AppModleSingleton;

        InitializeComponent();
    }
}

