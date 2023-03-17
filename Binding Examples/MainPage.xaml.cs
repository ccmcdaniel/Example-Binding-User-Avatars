using System.Collections.ObjectModel;

namespace Binding_Examples;

public partial class MainPage : ContentPage
{
	public ObservableCollection<User> myList;

	public MainPage()
	{
		InitializeComponent();
		myList = new ObservableCollection<User>();
		myList.Add(new User { Name = "Chad", UserName = "ccmcdaniel", Avatar="user.png"});
		myList.Add(new User { Name = "Corey", UserName = "caharper", Avatar = "man.png" });
		myList.Add(new User { Name = "Jessica", UserName = "jharmon", Avatar = "woman.png" });

		lstMyList.ItemsSource = myList;
	}

	public class User
	{
		private string _name;
		private string _username;
		private string _image;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public string UserName 
		{ 
			get { return $"@{_username}"; }
			set { _username = value; }
		}

		public string Avatar
		{
			get { return _image; }
			set { _image = value; }
		}
	}
}

