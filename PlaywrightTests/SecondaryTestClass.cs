using Microsoft.Playwright.Xunit;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PlaywrightTests
{
    public class SecondaryTestClass : PageTest
    {
        public override async Task InitializeAsync()
        {
            await base.InitializeAsync();
            await Page.GotoAsync("https://playwright.dev");
        }

        public override async Task DisposeAsync()
        {
            Console.WriteLine("After each test cleanup");
            await base.DisposeAsync();
        }

        [Fact]
        public async Task GeneratedTestSample()
        {
            await Page.GotoAsync("https://demo.playwright.dev/todomvc/#/");
            await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "todos" })).ToBeVisibleAsync();
        }

    }
}