using System;
using System.Collections.Generic;
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
		this.userInfo = userInfo;
	}

	public bool logIn(string username, string password)
	{
		this.loggedIn = true;
		Console.WriteLine("logged in successfullty");
		return this.loggedIn;
	}

	public bool register(UserInfo userInfo)
	{
		Console.WriteLine("registered successfullty");
		return true;
	}

	public void showReviews(List<Review> reviews)
	{
		Console.WriteLine("showing user reviews");
	}
}
