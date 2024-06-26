using DotNETFrameworkSpecFlow.BaseClass;
using DotNETFrameworkSpecFlow.SpecFlow.Support.Helpers;
using DotNETFrameworkSpecFlow.SpecFlow.Support.POM_Pages;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace DotNETFrameworkSpecFlow.SpecFlow.StepDefinition
{
    [Binding]
    public sealed class StepHuBooHomePage
    {
        [Given(@"i have navigated to the HuBoo website")]
        public void GivenIHaveNavigatedToTheHuBooWebsite()
        {
            //
        }

        [Then(@"the user is on the HuBoo home page")]
        public void ThenTheUserIsOnTheHuBooHomePage(string HPExpectedText)
        {
            List<string> HomePageText_Actual = OnScreenTextHelper.DeSerializeActualScreenTextCssSeletor("#hero-c-block_d015f86c24c25db4313b9d0721eb42bc > div > div.hero-main__wrap > div.hero-main__content > h1 > span");
            List<string> HomePageText_Expected = OnScreenTextHelper.DeSerializeExpectedScreenTextString(HPExpectedText);
            HomePageText_Actual.Should().BeEquivalentTo(HomePageText_Expected);

        }

        [When(@"i click the telephone number")]
        public void WhenIClickTheTelephoneNumber()
        {
            Page_Home.TelephoneNumber.Click();
        }

        [Then(@"i am redirected to the contact us page")]
        public void ThenIAmRedirectedToTheContactUsPage(string ContactUs)
        {
            List<string> ContactusText_Actual = OnScreenTextHelper.DeSerializeActualScreenTextCssSeletor("#contact-us > div.wrapper > div > div.vestibulum__left > p");
            List<string> ContactusText_Expected = OnScreenTextHelper.DeSerializeExpectedScreenTextString(ContactUs);
            ContactusText_Actual[0].Should().BeEquivalentTo(ContactusText_Expected[0]);
        }

        [When(@"i click on the Login button")]
        public void WhenIClickOnTheLoginButton()
        {
            Page_Home.LoginButton.Click();
        }

        [When(@"i have naviagted to the Login Page")]
        public void WhenIHaveNaviagtedToTheLoginPage(string Login)
        {
            BaseStep.browserInstance.SwitchTo().Window(BaseStep.browserInstance.WindowHandles[1]);

            List<string> LoginText_Actual = OnScreenTextHelper.DeSerializeActualScreenTextCssSeletor("#localAccountForm > div.intro > h2");
            List<string> LoginText_Expected = OnScreenTextHelper.DeSerializeExpectedScreenTextString(Login);
            LoginText_Actual.Should().BeEquivalentTo(LoginText_Expected);
        }

        [Then(@"i can input user crednetials")]
        public void ThenICanInputUserCrednetials()
        {
            //Page_Login.email("mai").Value = "HuBoo@Huboo.co.uk";
            Page_Login.email.Value = "HuBoo@Huboo.co.uk";
            Page_Login.password.Value = "Password1!";
        }

        [Given(@"a user is on the Huboo Pricing page")]
        public void GivenAUserIsOnTheHubooPricingPage()
        {
            Page_Home.PricingButton.Click();
        }

        [Then(@"the Large Letter to 500g displays the correct price for Huboo 24 Hour Standard")]
        public void ThenTheLargeLetterToGDisplaysTheCorrectPriceForHubooHourStandard()
        {
            //int row = Page_Pricing.UKFulfillment_Table.SizeAndWeight.ReturnRowNumber().WhereCellContains("Large Letter to 500g");
            //string CellValue = Page_Pricing.UKFulfillment_Table.Huboo24HourStandard.getCellAtRow(row).Value;
            //CellValue.Should().BeEquivalentTo("£2.09");

            int row = Page_Pricing.UKFulfillment_Table.SizeAndWeight.ReturnRowNumber().WhereCellContains("Large Letter to 500g");
            string CellValue = Page_Pricing.UKFulfillment_Table.Huboo24HourStandard.getCellAtRow(row).Value;
            CellValue.Should().BeEquivalentTo("£2.09");
        }
    }
}
