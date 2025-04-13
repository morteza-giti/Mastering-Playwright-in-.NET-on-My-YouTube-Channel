using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.Xunit;

namespace PlaywrightTests;

public class TestClass1 : PageTest
{
    [Fact]
    public async Task HasTitle()
    {
        // Expect a title "to contain" a substring.
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));
    }

    [Fact]
    public async Task GetStartedLink()
    {
        await Page.GetByRole(AriaRole.Link, new PageGetByRoleOptions() { Name = "Get started" }).ClickAsync();

        await Expect(Page.GetByRole(AriaRole.Heading, new PageGetByRoleOptions() { Name = "Installation" })).ToBeVisibleAsync();
    }
}
