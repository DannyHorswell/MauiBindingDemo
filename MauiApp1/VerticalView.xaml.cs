using MauiApp1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace MauiApp1
{
	public partial class VerticalView : ContentView
    {
		public VerticalView ()
		{
            this.BindingContextChanged += VerticalView_BindingContextChanged;

            InitializeComponent();

            var bc = this.BindingContext;
        }

        private void AddVerticalButton_Clicked(object sender, EventArgs e)
        {
            var vertCollection = this.BindingContext as VerticalObjectCollection;

            var newVert = new VerticalObject();

            var item = new Item();
            item.Name = MauiProgram.AppModleSingleton.NextThingName();

            newVert.HozItems.Add(item);

            vertCollection.Add(newVert);
        }

        private void DeleteVerticalButton_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var vertObject = button.BindingContext as VerticalObject;

            MauiProgram.AppModleSingleton.VertItems.Remove(vertObject);

        }

        private void VerticalView_BindingContextChanged(object sender, EventArgs args)
        {
            var control = sender as VerticalView;
            var model = this.BindingContext as VerticalObjectCollection;

        }
    }
}