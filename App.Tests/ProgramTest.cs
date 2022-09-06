namespace App.Tests;

public class ProgramTest
{
    [Fact]
    public void is_divisible_by_four()
    {
        var app = new App.Program();

        app.IsLeapYear(4).Should().BeTrue("Year should be divisible by 4");
    }

    [Fact]
    public void is_divisible_by_four_unless_also_by_100()
    {
        var app = new App.Program();

        app.IsLeapYear(200).Should().BeFalse("Year should be divisible by 4, but not by 100");
    }

    [Fact]
    public void is_divisible_by_four_unless_also_by_100_unless_divisible_by_400()
    {
        var app = new App.Program();

        app.IsLeapYear(1600).Should().BeTrue("Year should be divisible by 4, but not by 100, unless also by 400");
    }

    [Fact]
    public void year_is_after_or_on_1582()
    {
        var app = new App.Program();

        Action action = () => app.ValidateYear(1582);
        Action actionTwo = () => app.ValidateYear(1581);

        action.Should().NotThrow<ArgumentException>("Years after and on 1582 should be allowed");
        actionTwo.Should().Throw<ArgumentException>("Years before 1582 are not allowed");
    }

    [Fact]
    public void returns_yay_or_nay()
    {
        var app = new App.Program();

        var msgTrue = app.GetResponse(true);
        var msgFalse = app.GetResponse(false);

        msgTrue.Should().Be("yay");
        msgFalse.Should().Be("nay");
    }

    [Fact]
    public void test_app_with_not_leap_year()
    {
        var app = new App.Program();

        var output = new StringWriter();
        Console.SetOut(output);

        var input = new StringReader("1582");
        Console.SetIn(input);

        app.Run();

        output.ToString().Should().Contain("nay", "1582 should not be a leap year");
    }

    [Fact]
    public void test_app_with_leap_year()
    {
        var app = new App.Program();

        var output = new StringWriter();
        Console.SetOut(output);

        var input = new StringReader("1600");
        Console.SetIn(input);

        app.Run();

        output.ToString().Should().Contain("yay", "1582 should not be a leap year");
    }
}
