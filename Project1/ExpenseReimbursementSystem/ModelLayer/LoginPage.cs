namespace ModelLayer;

public class LoginPage
{
    public int loginID {get; set;}
    public string userName {get; set;}  
    public string userPassword {get; set;}
    public UserInfo.userRoleEnum Role {get; set;}

    public LoginPage(int loginID, string userName, string userPassword, UserInfo.userRoleEnum Role)
    {
        this.loginID = loginID;
        this.userName = userName;
        this.userPassword = userPassword;
        this.Role = Role;
    }
}