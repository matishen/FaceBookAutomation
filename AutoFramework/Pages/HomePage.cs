namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#navItem_100001902274277 > a > div")]
        public IWebElement ProfileName { get; set; }

        [FindsBy(How = How.Id, Using = "userNavigationLabel")]
        public IWebElement UserNavigationLabel { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#js_w > div > div > ul > li._54ni.navSubmenu._6398._6393.__MenuItem > a")]
        public IWebElement ActivityLogBtn { get; set; }

        [FindsBy(How = How.ClassName, Using = "uiScrollableAreaContent")]
        public IWebElement ScrollableAreaContent { get; set; }
    }
}
