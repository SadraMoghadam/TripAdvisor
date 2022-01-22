using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TripAdvisor;

public class User
{
	#region Singleton Pattern

	static User instance;

	public static User Instance
	{
		get
		{
			return instance;
		}
		set
		{
			instance = value;
		}
	}

	#endregion
	
	private int userId { get; set; }
	private UserInfo userInfo;
	private bool loggedIn;
	private List<Review> reviews;

	public List<Review> Reviews => reviews;

	public UserInfo UserInfo => userInfo;

	public User(int userId,UserInfo userInfo)
	{
		this.userId = userId;
		this.userInfo = userInfo;
		this.loggedIn = false;
	}

	public void updateUser(UserInfo userInfo)
	{
		Console.WriteLine("profile edited successfullty");
		this.userInfo = userInfo;
	}

	public bool logIn(string username, string password)
	{
		this.loggedIn = true;
		instance = new User(1, userInfo);
		Console.WriteLine("logged in successfullty");
		Console.WriteLine("welcome " + username);
		return this.loggedIn;
	}

	public bool register()
	{
		Console.WriteLine("registered successfullty");
		return true;
	}

	public void showReviews(int userId)
	{
		Console.WriteLine("showing user reviews");
	}
}
