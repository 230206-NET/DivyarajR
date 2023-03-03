using Models;
using Services;

namespace API;

public class Tests
{
    [Fact]
    public void MatchEmployeeTest()
    {
        string? firstname = "firstname of user(Employee or Manager)";
        string? lastname = "lastname of user(Employee or Manager)";
        string? username = "Employee or Manager username";
        string? password = "Employee or Manager Password";
        string? position = "Employee or Manager Position";

        User user = new User(firstname, lastname, username, password, position);
        Assert.Equal(user.FirstName, firstname);
        Assert.Equal(user.LastName, lastname);
        Assert.Equal(user.UserName, username);
        Assert.Equal(user.Password, password);
        Assert.Equal(user.Position, position);
    }
}

        // [Fact]
    // public void ERTTesting()
    // {
    //     string? username = "valid";
    //     DateTime date = DateTime.Now;
    //     string? title = "Plane Travel";            
    //     string? description = "Flew from dsm to nyw";
    //     decimal amount = 100;
    //     string? status = "rejected";
    //     ERT ert = new ERT(username, date, title, description, amount, status);
    //     Assert.Equal(ert.UserName, username);
    //     Assert.Equal(ert.TicketDateTime, date);
    //     Assert.Equal(ert.Title, title);
    //     Assert.Equal(ert.Description, description);
    //     Assert.Equal(ert.Amount, amount);
    //     Assert.Equal(ert.Status, status);
    // }
// }
