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
            List<string> HomePageText_Actual = OnScreenTextHelper.DeSerializeActualScreenTextCssSeletor("#top > section.sec-home.sec-home-huboo > div > header > h1");
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
            List<string> LoginText_Actual = OnScreenTextHelper.DeSerializeActualScreenTextCssSeletor("#page-wrapper > div:nth-child(1) > div > div > h1");
            List<string> LoginText_Expected = OnScreenTextHelper.DeSerializeExpectedScreenTextString(Login);
            LoginText_Actual.Should().BeEquivalentTo(LoginText_Expected);
        }

        [Then(@"i can input user crednetials")]
        public void ThenICanInputUserCrednetials()
        {
            Page_Login.email("mai").Value = "HuBoo@Huboo.co.uk";
            Page_Login.password.Value = "Password1!";
        }

        [Then(@"the Covid update is displayedhuboo")]
        public void ThenTheCovidUpdateIsDisplayedhuboo(string Covid)
        {
            List<string> CovidText_Actual = OnScreenTextHelper.DeSerializeActualScreenTextCssSeletor("#top > section.sec-home.sec-home-huboo > div > header > p:nth-child(1) > b");
            List<string> CovidText_Expected = OnScreenTextHelper.DeSerializeExpectedScreenTextString(Covid);
            CovidText_Actual.Should().BeEquivalentTo(CovidText_Expected);
        }

        [Given(@"a user is on the Huboo Pricing page")]
        public void GivenAUserIsOnTheHubooPricingPage()
        {
            Page_Home.PricingButton.Click();
        }

        [Then(@"the Large Letter to 500g displays the correct price for Huboo 24 Hour Standard")]
        public void ThenTheLargeLetterToGDisplaysTheCorrectPriceForHubooHourStandard()
        {
            int row = Page_Pricing.UKFulfillment_Table.SizeAndWeight.ReturnRowNumber().WhereCellContains("Large Letter to 500g");
            string CellValue = Page_Pricing.UKFulfillment_Table.Huboo24HourStandard.getCellAtRow(row).Value;
            CellValue.Should().BeEquivalentTo("£2.09");
        }
    }
}
