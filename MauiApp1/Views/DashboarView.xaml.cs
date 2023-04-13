using MauiApp1.Models;
using System.Collections.ObjectModel;

namespace MauiApp1.Views;

public partial class DashboarView : ContentPage
{
	public ObservableCollection<Profile> Profiles { get; set; }
	public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }
	public DashboarView()
	{
		InitializeComponent();
		LoadData();
		BindingContext = this;
	}

    private void LoadData()
    {
		Profiles = new ObservableCollection<Profile>
		{
			new Profile
			{
				Name = "Anita Onofre",
                ProfileImage = "user1.jpg",
                NoPhotos = 12
			},
            new Profile
            {
                Name = "Daiela Alcaraz",
                ProfileImage = "user2.jpg",
                NoPhotos = 12
            },
            new Profile
            {
                Name = "JadePicon",
                ProfileImage = "user3.jpg",
                NoPhotos = 12
            },

        };

        GeneratedImages = new ObservableCollection<GeneratedImage>
        {
            new GeneratedImage
            {
                ImagePath = "katsudo.jpg",
                MainKeyword = "Katsudo",
                Keywords = new List<string>
                {
                    "Epick , hill, mountain, trees, blue sky"
                }
            },
             new GeneratedImage
            {
                ImagePath = "furai.jpg",
                MainKeyword = "Furai",
                Keywords = new List<string>
                {
                    "Epick , hill, mountain, trees, blue sky"
                }
            },
              new GeneratedImage
            {
                ImagePath = "okinawa_soba.jpg",
                MainKeyword = "Okinawa Soba",
                Keywords = new List<string>
                {
                    "Epick , hill, mountain, trees, blue sky"
                }
            },
                new GeneratedImage
            {
                ImagePath = "oyakodon.jpg",
                MainKeyword = "Oyakodon",
                Keywords = new List<string>
                {
                    "Epick , hill, mountain, trees, blue sky"
                }
            },
        };
    }
}