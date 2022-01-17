using System;

public class UserInfo
{
    private int userInfo_id;
    private string name;
    private string email;
    private string username;
    private string password;
    private bool gender;
    private int age;
    private string address;

    public string getUsername() => this.username;
    public string getName() => this.name;
    public string getEmail() => this.email;
    public string getPassword() => this.password;
    public bool getGender() => this.gender;
    public int getAge() => this.age;
    public string getAddress() => this.address;
    public int getUserInfo_id() => this.userInfo_id;
}

