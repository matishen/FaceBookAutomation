namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement UsernameInput { get; set; }

        [FindsBy(How = How.Id, Using = "pass")]
        public IWebElement PasswordInput { get; set; }

        [FindsBy(How = How.Id, Using = "u_0_b")]
        public IWebElement LoginBtn { get; set; }
    }
}
