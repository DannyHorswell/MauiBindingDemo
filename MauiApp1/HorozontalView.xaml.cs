using MauiApp1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace MauiApp1
{
	public partial class HorozontalView : ContentView
	{
		public HorozontalView()
		{
			InitializeComponent();

            var bc = this.BindingContext;
		}

        private void AddHorizontalButton_Clicked(object sender, EventArgs e)
        {
            var hozCollection = this.BindingContext as HorizontalObjectCollection;

            var item = new Item();

            item.Name = MauiProgram.AppModleSingleton.NextThingName();

            hozCollection.Add(item);
        }

        private void DeleteHorizontalButton_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;

            var hozItem = button.BindingContext as Item;
            var hozCollection = this.BindingContext as HorizontalObjectCollection;

            hozCollection.Remove(hozItem);
        }
       
    }
}