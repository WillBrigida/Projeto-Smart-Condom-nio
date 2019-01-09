using CondominioSmart.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

//https://www.youtube.com/watch?v=dzviFuEU09Y

namespace CondominioSmart.Helpers
{

    public class Converter : Behavior<ListView>
    {
        public static readonly BindableProperty CommandProperty = BindableProperty.Create
            (
                propertyName: "Command",
                returnType: typeof(ICommand),
                declaringType: typeof(Convert)
            );

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.ItemSelected += BindableOnItemSelected;
            bindable.BindingContextChanged += BindingOnBindingContextChanged;
        }

        private void BindingOnBindingContextChanged(object sender, EventArgs e)
        {
            var lv = sender as ListView;
            BindingContext = lv?.BindingContext;
        }

        private void BindableOnItemSelected(object sender, SelectedItemChangedEventArgs selectedItemChangedEventArgs)
        {
            Command.Execute(null);
            //var lv = sender as ListView;
            //var vm = lv?.BindingContext as MenuViewModel;
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.ItemSelected -= BindableOnItemSelected;
            bindable.BindingContextChanged -= BindingOnBindingContextChanged;
        }

    }
}

