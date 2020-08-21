using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Storage.Blob;
using Prototype;
using Xamarin.Forms;
using System.IO;
using SQLite;
using Prototype.data;

namespace Prototype
{
    public partial class MainHomeView : ContentView
    {
        public MainHomeView()
        {
            InitializeComponent();
            DisplayPosts();
        }

        /*public async void Appearing()
        {
            var blobList = await BlobStorageService.GetBlobs<CloudBlockBlob>("Photos");

            var firstBlob = blobList?.FirstOrDefault();
            var photo = new PhotoModel {Title = firstBlob?.Name, Uri = firstBlob?.Uri };

            DescriptionT.Text = photo?.Title;
            PostImage.Source = ImageSource.FromUri(photo?.Uri);


        } */

        public async void DisplayPosts()
        {
            var blobList = await BlobStorageService.GetBlobs<CloudBlockBlob>("teststorage1");
            const string V = "!&%#%#&!";

            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            //var myquery = db.Table<RegistrationTable>().Where(u => u.UserName.Equals(UsernameInput.Text) && u.Password.Equals(PasswordInput.Text)).FirstOrDefault();

            string userName;

            var u = db.Table<RegistrationTable>();

            

            foreach (var posts in blobList)
            {
                var photo = new PhotoModel {Title = posts?.Name, Uri = posts?.Uri };
                string description = photo?.Title;
                string[] des = description.Split(V.ToCharArray());

                PostScrollPage.Children.Add(new Grid
                {
                    Margin = new Thickness(0,10,0,0),
                    HeightRequest = 400,
                    BackgroundColor = Color.White,
                    Children =
                    {
                        new Grid
                        {
                            Margin = new Thickness(0,0,0,330), Children =
                            {
                                new Image{Source = ImageSource.FromResource("Prototype.assets.HomePage.PostElements.defaultProfilePic.ProfilePic3x.png"), Margin = new Thickness(0,10,350,20) },
                                new Label{Text=userName, Margin = new Thickness(60,10,0,0), FontSize = 12},
                                new Label{Text="[BestDropComp]", Margin = new Thickness(60,25,0,0), FontSize=14, FontAttributes = FontAttributes.Bold, TextColor = Color.FromHex("#00BCCF") },
                                new Image{Source=ImageSource.FromResource("Prototype.assets.HomePage.PostElements.DropVoteIcons.upvoteIconBOLD2x.jpg"), Margin = new Thickness(350,18,0,20) }
                            }
                        },
                        new Grid
                        {
                            Margin = new Thickness(0,70,0,90), Children =
                            {
                                new Image{Source = ImageSource.FromUri(photo?.Uri)}
                            }
                        },  
                        new Grid
                        {
                            ColumnDefinitions =
                            {
                                new ColumnDefinition{Width = new GridLength(0.5, GridUnitType.Star) }
                            },
                            RowDefinitions =
                            {
                                new RowDefinition{Height = new GridLength(90) }
                            },
                            Margin = new Thickness(0,310,10,50), ColumnSpacing = 20, Children =
                            {
                                new Button{ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.PostElements.DropVoteIcons.upvoteIcon2x.jpg"), Margin = new Thickness(0,0,0,50)},
                                new Button{ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.PostElements.thumbsUpIcon.ThumbsUpIcon2x.jpg"), Margin = new Thickness(0,0,0,50) /* column 1 */ },
                                new Button{ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.PostElements.betIcons.betIcon2x.jpg"), Margin = new Thickness(0,0,0,50)/* column 2 */},
                                new Button{ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.PostElements.SendIcons.sendIcon2x.jpg"), Margin = new Thickness(0,0,0,50) /* column 3 */},
                                new Button{ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.PostElements.saveIcons.saveIcon2x.jpg"), Margin = new Thickness(0,0,0,50)/* column 4 */},
                                new Button{ImageSource = ImageSource.FromResource("Prototype.assets.HomePage.PostElements.CommentIcons.commentBubble2x.jpg"), Margin = new Thickness(0,0,0,50)/* column 5 */ }
                            },
                        },
                        new Grid
                        {
                            Margin = new Thickness(10,350,10,0), Children =
                            {
                                new Label{Text = des[0], FontSize = 10 }
                            }
                        }
                    }
                });
            }
        }


        async void DropVote_Clicked(System.Object sender, System.EventArgs e)
        {
            var blobList = await BlobStorageService.GetBlobs<CloudBlockBlob>("teststorage1");

            var firstBlob = blobList?.FirstOrDefault();
            var photo = new PhotoModel { Title = firstBlob?.Name, Uri = firstBlob?.Uri };

            string description = photo?.Title;
            const string V = "!&%#%#&!";
            string[] des = description.Split(V.ToCharArray());
            DescriptionT.Text = des[0];
            PostImage.Source = ImageSource.FromUri(photo?.Uri);
        }
    }
}