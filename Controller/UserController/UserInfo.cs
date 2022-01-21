using System;

public class UserInfo
{
    private int userInfoId;
    private string name;
    private string email;
    private string username;
    private string password;
    private bool gender;
    private int age;
    private string address;

    public string Username() => this.username;
    public string Name() => this.name;
    public string Email() => this.email;
    public string Password() => this.password;
    public bool Gender() => this.gender;
    public int Age() => this.age;
    public string Address() => this.address;
    public int UserInfoId() => this.userInfoId;

    public UserInfo(int userInfoId, string name, string email, string username, string password, bool gender, int age, string address)
    {
        this.userInfoId = userInfoId;
        this.name = name;
        this.email = email;
        this.username = username;
        this.password = password;
        this.gender = gender;
        this.age = age;
        this.address = address;
    }
}

