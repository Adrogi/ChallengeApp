using System.Reflection.Metadata;

namespace ChallengeApp.Tests;


public class EmployeeTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddScorePointsCollectedByUser_ReturnsCorrectResult()
    {
       
        var user = new Employee("Marek","Balski", "22");
        user.AddScore(5);
        user.AddScore(6);
        user.AddScore(7);


        int result = user.Result;

        Assert.AreEqual(18, result);
    }
    [Test]
    public void PenaltyPointsCollectedByUser_ReturnsCorrectResult()
    {

        var user = new Employee("Daniel", "Kot", "17");
        user.AddScore(5);
        user.AddScore(6);
        user.PenaltyPoints(10);


        int result = user.Result;

        Assert.AreEqual(1, result);
    }
}