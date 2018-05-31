﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyApp.Behaviors
{
    public class ItemtappedAttached
    {
        public static readonly  BindableProperty CommandProperty=
            BindableProperty.CreateAttached(
                propertyName:"Command",
                returnType:typeof(ICommand),
                declaringType:typeof(ListView),
                defaultValue:null,
                defaultBindingMode:BindingMode.OneWay,
                validateValue:null,
                propertyChanged:OnItemTappedChanged);

        public static ICommand GetItemTapped(BindableObject bindable)
        {
            return (ICommand) bindable.GetValue(CommandProperty);
        }

        public static void SetItemTapped(BindableObject bindable,ICommand value)
        {
            bindable.SetValue(CommandProperty, value);
        }

        public static void OnItemTappedChanged(BindableObject bindable,object oldValue,object newValue)
        {
            var control = bindable as ListView;
            if (control != null)
            {
                control.ItemTapped += OnItemTapped;
            }
        }

        public static void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var control = sender as ListView;
            var command = GetItemTapped(control);
            if (command != null && command.CanExecute(e.Item))
            {
                command.Execute(e.Item);
            }
        }
    }
}
