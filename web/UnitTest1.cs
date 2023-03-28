namespace web;

[TestFixture]
public class Tests
{
    IWebDriver driver;

    [OneTimeSetUp]
        public void Setup()
    {
        driver = new ChromeDriver();
    }

    [Test]
    public void TestAgeRange()
    {
        driver.Url="C:\\Users\\AYBİLGİSAYAR\\nUnitTest\\web\\index.html";
        IWebElement txtAge = driver.FindElement(By.Id("txtAge"));
        IWebElement validations = driver.FindElement(By.Id("validations"));

        txtAge.SendKeys("5");
        txtAge.SendKeys("\t");

        string validationText = validations.GetAttribute("innetHTML");
        if (validationText != "")
        {
            Assert.Fail();
        }
        else
        {
            Assert.Pass();
        }

    }


    [OneTimeTearDown]
    public void Close()
    {
        //driver.Close();
    }
}