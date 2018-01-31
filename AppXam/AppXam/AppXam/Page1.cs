using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppXam
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            Label labelLarge = new Label { Text = "Label", FontSize = 40,
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.White,
            };
            Label labelSmall = new Label { Text = "This control is great for\n" + 
                "displaying one or more\n" + 
                "lines of text.", FontSize = 20,
                HorizontalOptions = LayoutOptions.CenterAndExpand };

            Button button = new Button { Text = "Make It So",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill };
            button.Clicked += (sender, args) => { button.Text = "It is so!"; };

            Entry entry = new Entry { Placeholder = "Username",
                VerticalOptions = LayoutOptions.Center,
                Keyboard = Keyboard.Text };

            BoxView boxView = new BoxView { Color = Color.Silver,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Fill };
            Image image = new Image { Source = "img.jpg",
                Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Fill };

            StackLayout stackLayoutHorizontal = new StackLayout
            { Spacing = 0,
                Orientation = StackOrientation.Horizontal,
                Children = { new Label { Text = "Start------" },
                    new Label { Text = "------Center------",
                        HorizontalOptions = LayoutOptions.CenterAndExpand },
                    new Label { Text = "------End" } } };



            StackLayout stackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new Label { XAlign = TextAlignment.Center,
                        Text = "Welcome to Xamarin Forms!" },
                     labelLarge,
                    labelSmall,
                    button,
                    entry,
                    boxView,
                    image,
                    stackLayoutHorizontal  //nested layout

                }

            };

            ScrollView scrollView = new ScrollView { VerticalOptions = LayoutOptions.FillAndExpand,
                Content = stackLayout };
            // Accomodate iPhone status bar.                
            this.Padding = new Thickness(60,70,80,90); 
            this.Content = scrollView;
            //this.Padding = new Thickness(20,20,20,20);
            this.BackgroundColor = Color.Pink;

        }
    }
}