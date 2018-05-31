using System;
using System.Collections.Generic;
using System.Text;
using MyApp.renderer;
using Xamarin.Forms;

namespace MyApp.Behaviors
{
    public class MaxLengthValidator : Behavior<CustomEntry>
    {
        public static readonly BindableProperty MaxLengthProperty = BindableProperty.Create("MaxLength", typeof(int), typeof(MaxLengthValidator), 0);
 
        public int MaxLength
        {
            get { return (int)GetValue(MaxLengthProperty); }
            set { SetValue(MaxLengthProperty, value); }
        }
 
        protected override void OnAttachedTo(CustomEntry entry)
        {
            entry.TextChanged += TextChanged;
            base.OnAttachedTo(entry);
        }
        // Devuelve una cadena de máximo una longitud permitida
        private void Unfocused(object sender, FocusEventArgs e)
        {
            CustomEntry entry = (CustomEntry)sender;
            if (string.IsNullOrEmpty(entry.Text))
            {
                
            }
            else
            {
                entry.Text = entry.Text.Substring(0, MaxLength);
            }
            
        }
        void TextChanged(object sender, TextChangedEventArgs e)
        {
            CustomEntry entry = (CustomEntry)sender;
            if (string.IsNullOrEmpty(entry.Text))
            {
                
            }
            else
            {
                var length = entry.Text.Length;
                if (length >=MaxLength)
                {
                    entry.Text = entry.Text.Substring(0, MaxLength);
                }
                else
                {
                }
                
            }
        }
        protected override void OnDetachingFrom(CustomEntry entry)
        {
            entry.TextChanged -= TextChanged;
            base.OnDetachingFrom(entry);
        }
    }
}
