public void Find_pos(IWebDriver path, IWebElement serch, string FindElement)
        {    
            path = new ChromeDriver();
            path.Navigate().GoToUrl("https://hh.ru/");

            serch = path.FindElement(By.ClassName("bloko-input-wrapper"));
            serch.SendKeys(FindElement + OpenQA.Selenium.Keys.Enter);
        }