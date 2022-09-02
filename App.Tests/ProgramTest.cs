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
    public void will_return_yay_on_leap_year()
    {
        var app = new App.Program();

        Assert.Equal(app.PromptForLeapYear(1600), "yay");
    }

    [Fact]
    public void will_return_nay_on_any_other_year()
    {
        var app = new App.Program();

        Assert.Equal(app.PromptForLeapYear(1234), "nay");
    }
}
