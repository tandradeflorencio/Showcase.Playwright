using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System.Text.RegularExpressions;

namespace Showcase;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public async Task WhenLoadThePage_ShouldDisplayTheTitleCorrectly()
    {
        //Arrange
        const string ExpectedPageTitle = "Google";
        const string TargetPageUrl = "https://google.com";

        //Act
        await Page.GotoAsync(TargetPageUrl);
        
        //Assert
        await Expect(Page).ToHaveTitleAsync(new Regex(ExpectedPageTitle));        
    }
}