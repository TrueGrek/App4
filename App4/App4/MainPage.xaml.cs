using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        int i = 0;
        public List<NoteModel> NoteList { get; set; }

        public MainPage()
        {
            InitializeComponent();

            NoteList = new List<NoteModel>
            {
                new NoteModel {Day=1, Title ="Первая заметка", Message = "Программировать каждый день!"},
                new NoteModel {Day=2, Title ="Первая заметка2", Message = "Программировать каждый день!"},
                new NoteModel {Day=3, Title ="Первая заметка3", Message = "Программировать каждый день!"},
                new NoteModel {Day=4, Title ="Первая заметка4", Message = "Программировать каждый день!"},
                new NoteModel {Day=5, Title ="Первая заметка5", Message = "Программировать каждый день!"}
            };
            ScrollView scrollView = new ScrollView();
            scrollView.Content = Tripoly;
            this.Content = scrollView;
        }
        
        
        private void Bb_Clicked(object sender, EventArgs e)
        {
            

            Label label = new Label
            {
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Start
            };
            label.BindingContext = NoteList[i];
            label.SetBinding(Label.TextProperty, "Title");

            Label label2 = new Label
            {
                TextColor = Color.Black,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.Start
            };
            label2.BindingContext = NoteList[i];
            label2.SetBinding(Label.TextProperty, "Message");

            Frame frame = new Frame
            {
                Content = label,
                BorderColor = Color.Salmon,
                BackgroundColor = Color.AliceBlue,
                CornerRadius = 8,
                Padding = 10,
                Margin = new Thickness(20, 10, 20, 0)
            };
            Frame frame2 = new Frame
            {
                Content = label2,
                BorderColor = Color.Salmon,
                BackgroundColor = Color.AliceBlue,
                CornerRadius = 8,
                Padding = 10,
                Margin = new Thickness(20, -6, 20, 10)
            };
            //StackLayout stackLayout = new StackLayout() { Children = { frame }, Padding = 20 };
            //Добавляем в stack layout label
            Tripoly.Children.Add(frame);
            Tripoly.Children.Add(frame2);
            i++;

            //Добавляем скрол ленты
            
        }

        private void CreateNoteButton_Clicked(object sender, EventArgs e)
        {
            Tripoly.Opacity = 50;
            Tripoly.IsEnabled = !Tripoly.IsEnabled;
            //The end 
            Tripoly.Opacity = 100;
            Tripoly.IsEnabled = Tripoly.IsEnabled;
        }
    }
}
