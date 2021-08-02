namespace AutoFramework
{
    using NUnit.Framework;
    using AutoFramework.Pages;

    public class GmailAutomation
    {
        private HomePage home;
        public GmailAutomation()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }
        [Test, Order(1)]
        public void SignIn()
        {
            LoginPage loginpage = new LoginPage();
            loginpage.UsernameInput.SendKeys(Config.Credentials.Valid.Email);
            loginpage.PasswordInput.SendKeys(Config.Credentials.Valid.Password);
            loginpage.LoginBtn.Click();
            Driver.WaitForElementUpTo(Config.ElementsWaitingShortTimeout);
        }
        [Test,Order(2)]
        public void UserIsInHomePage()
        {
            home = new HomePage();
            Assert.NotNull(home.ProfileName.Text);
        }

        [Test, Order(3)]
        public void GoToActivityLog()
        {
            home.UserNavigationLabel.Click();
            Driver.WaitForElementUpTo(Config.ElementsWaitingLongTimeout);
            var text = home.ScrollableAreaContent;
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            //Driver.driver.Quit();
        }
    }
}