using System;
using UserInfo

public class User
{
	private int user_Id { get; set; }
	private UserInfo userInfo; 

	public User(int id,UserInfo user_info)
	{
		user_Id = id;
		this.userInfo = user_info;
	}

	public UserInfo getUserInfo() => this.userInfo;
	
}
