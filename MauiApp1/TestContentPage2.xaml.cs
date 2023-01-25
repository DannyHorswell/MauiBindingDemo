using MauiApp1.Classes;

namespace MauiApp1;

public partial class TestContentPage2 : ContentPage
{
    public TestContentPage2()
	{
        this.BindingContext = MauiProgram.AppModleSingleton;

        InitializeComponent();
    }
}

