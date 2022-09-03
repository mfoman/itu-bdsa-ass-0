namespace App.Tests;

public class ProgramTest
{
    [Fact]
    public void is_divisible_by_four()
    {
        var app = new App.Program();

        Assert.True(app.IsLeapYear(4), "Year should be divisible by 4");
    }

    [Fact]
    public void is_divisible_by_four_unless_also_by_100()
    {
        var app = new App.Program();

        Assert.False(app.IsLeapYear(200), "Year should be divisible by 4");
    }

    [Fact]
    public void is_divisible_by_four_unless_also_by_100_unless_divisible_by_400()
    {
        var app = new App.Program();

        Assert.True(app.IsLeapYear(1600), "Year should be divisible by 4 unless by 100 unless by 400");
    }

    [Fact]
    public void returns_yay_or_nay()
    {
        var app = new App.Program();

        Assert.Equal(app.GetResponse(true), "yay");
        Assert.Equal(app.GetResponse(false), "nay");
    }
}
