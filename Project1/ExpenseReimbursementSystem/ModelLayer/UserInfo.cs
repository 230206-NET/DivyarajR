namespace ModelLayer;

public class UserInfo
{
    public int userID {get; set;}
    public string userFirstName {get; set;}
    public string userLastName {get; set;}
    public string userName {get; set;}
    public string userPassword {get; set;}
    public userRoleEnum Role {get; set;}

    public UserInfo(int userID, string userFirstName, string userLastName, string userName, string userPassword, string userRoleType)
    {
        this.userID = userID;
        this.userFirstName = userFirstName;
        this.userLastName = userLastName;
        this.userName = userName;
        this.userPassword = userPassword;
        this.userRoleEnum = userRoleEnum;
    }

    public enum Role{
        Employee, Manager
    }
}