using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumControlCustomBrowser
{
    public partial class Form1 : Form
    {
        private readonly List<DataSetModel> dataNames;
        private readonly List<DataSetModel> maleDataName;
        public List<DataSetModel> femaleDataNames { get; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var smsPvaService = new SMSPVA();

            var userInfo = smsPvaService.GetUserInfo();

            var countriesOrderByPriceDesc = smsPvaService.GetChepeastCountrySMSReceive();

            var lowestPriceCountries = countriesOrderByPriceDesc.Where(x => x.price <= Convert.ToDecimal(0.20)).ToList();


            while (userInfo.balance >= lowestPriceCountries.Last().price)
            {

                var r = new Random();
                var y = r.Next(0, lowestPriceCountries.Count);
                var lowestPriceRandomCountry = lowestPriceCountries.ElementAt(y);

                var lowestPriceCountry = lowestPriceRandomCountry;

                ChromeDriver driver = null;
                Process process = null;

                try
                {


                    var _profileGenerator = new ProfilerGenerator();
                    var pessoa = _profileGenerator.Generate();
                    
                

                    MongoConnection _mongoConnection = new MongoConnection();


                    ProcessStartInfo info = new ProcessStartInfo()
                    {
                        CreateNoWindow = true,
                        FileName = @"C:\Users\Peterson Andrade\source\repos\InstaAccCreator_netframework\bin\x64\Debug\InstaAccCreator_netframework.exe",
                        Arguments = pessoa.Proxy.username + ":" + pessoa.Proxy.password + "@" + pessoa.Proxy.proxy_address + ":" + pessoa.Proxy.ports.http.ToString()
                    };
                    process = Process.Start(info);




                    CountryCodes countryCodes = new CountryCodes();

                    var countryCodeDetails = countryCodes.AllCountries.Where(x => x.isoCode2digits == lowestPriceCountry.country).First();

                    var numberObject = smsPvaService.GetNumber(lowestPriceCountry.country);

                    numberObject.number = "+" + countryCodeDetails.countryCode + numberObject.number;


                    //var getSms = smsPvaService.GetSms(lowestPriceCountry.country, numberObject.id);
                    pessoa.Number = numberObject;


                    var options = new ChromeOptions();
                    //options.BinaryLocation = @"C:\Users\Peterson Andrade\source\repos\InstaAccCreator_netframework\bin\x64\Debug\InstaAccCreator_netframework.exe";
                    //options.AddArgument("url=data:,");
                    //options.AddArgument("no-sandbox");
                    //options.AddArgument("--headless");
                    //options
                    options.DebuggerAddress = "localhost:8081";


                    //var driverService = ChromeDriverService.CreateDefaultService();
                    //driverService.HideCommandPromptWindow = true;
                    options.PageLoadStrategy = PageLoadStrategy.Normal;

                    var driverService = ChromeDriverService.CreateDefaultService();
                    driverService.HideCommandPromptWindow = true;


                    driver = new ChromeDriver(driverService, options);
                    driver.Navigate().GoToUrl("https://instagram.com");
                    //driver.Navigate().GoToUrl("http://google.com");
                    //AppDomain.CurrentDomain.ProcessExit += new EventHandler((x, y) =>
                    //{
                    //    driver.Close();
                    //    process.Kill();
                    //});


                    var search_Locator = By.TagName("a");
                    var wait = new WebDriverWait(driver, new System.TimeSpan(0, 1, 0));
                    wait.Until(ExpectedConditions.ElementIsVisible(search_Locator));
                    //System.Threading.Thread.Sleep(10000);
                    bool IsVisibleSignUpLink = false;
                    do
                    {
                        var elements = driver.FindElements(search_Locator);//.Where(x => x.GetAttribute("href") == "//");

                        foreach (var element in elements)
                        {
                            var elementHreftext = (element.GetProperty("href"));
                            if (elementHreftext.Contains("accounts/emailsignup"))
                            {
                                //MessageBox.Show("Found!");
                                IsVisibleSignUpLink = true;
                                element.Click();

                            }
                            this.richTextBox1.AppendText(elementHreftext + "\n");
                        }
                    } while (!IsVisibleSignUpLink);


                    var email_Locator = By.Name("emailOrPhone");
                    wait.Until(ExpectedConditions.ElementIsVisible(email_Locator));
                    var emailElement = driver.FindElement(email_Locator);
                    emailElement.Click();
                    //emailElement.SendKeys("+5521987655678");
                    emailElement.SendKeys(numberObject.number);



                    //emailElement.FindElement(By.ClassName("coreSpriteInputAccepted"));
                    //emailElement.FindElement(By.ClassName("coreSpriteInputError"));
                    //emailElement.FindElement(By.ClassName("coreSpriteInputRefresh"));



                    var fullName_Locator = By.Name("fullName");
                    wait.Until(ExpectedConditions.ElementIsVisible(fullName_Locator));
                    var fullNameElement = driver.FindElement(fullName_Locator);
                    fullNameElement.Click();
                    fullNameElement.SendKeys(pessoa.Nome);


                    var userName_Locator = By.Name("username");
                    wait.Until(ExpectedConditions.ElementIsVisible(userName_Locator));
                    var userNameElement = driver.FindElement(userName_Locator);
                    userNameElement.Click();
                    userNameElement.SendKeys(pessoa.UserName);


                    var password_Locator = By.Name("password");
                    wait.Until(ExpectedConditions.ElementIsVisible(password_Locator));
                    var passwordElement = driver.FindElement(password_Locator);
                    passwordElement.Click();
                    passwordElement.SendKeys(pessoa.Senha);


                    userNameElement = driver.FindElement(userName_Locator);
                    IWebElement userNameDivElement = userNameElement.FindElement(By.XPath("..")).FindElement(By.XPath(".."));

                    try
                    {
                        var acceptedLocator = By.ClassName("coreSpriteInputAccepted");
                        wait.Until(ExpectedConditions.ElementIsVisible(acceptedLocator));
                        var userNameInputAcceptedElement = userNameDivElement.FindElement(acceptedLocator);
                        if (!userNameInputAcceptedElement.Displayed)
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            var errorLocator = By.ClassName("coreSpriteInputError");
                            wait.Until(ExpectedConditions.ElementIsVisible(errorLocator));
                            var userNameInputErrorElement = userNameDivElement.FindElement(errorLocator);
                            if (userNameInputErrorElement.Displayed)
                            {
                                var refreshLocator = By.ClassName("coreSpriteInputRefresh");
                                wait.Until(ExpectedConditions.ElementIsVisible(refreshLocator));
                                var userNameInputRefreshElement = userNameDivElement.FindElement(By.ClassName("coreSpriteInputRefresh"));
                                userNameInputRefreshElement.Click();
                                passwordElement.Click();

                                userNameElement = driver.FindElement(userName_Locator);
                                pessoa.UserName = userNameElement.GetProperty("value");
                            }

                        }
                        catch (Exception exc)
                        {

                        }
                    }



                    var signUpButton_Locator = By.TagName("button");
                    wait.Until(ExpectedConditions.ElementIsVisible(signUpButton_Locator));
                    var elementsBtn = driver.FindElements(signUpButton_Locator);//.Where(x => x.GetAttribute("href") == "//");


                    foreach (var element in elementsBtn)
                    {
                        var elementHreftext = (element.GetProperty("type"));
                        if (elementHreftext.Contains("submit"))
                        {
                            //new Actions(driver).MoveToElement(element).Perform();
                            //MessageBox.Show("Found!");
                            element.Click();
                        }
                    }

                    //Verificar a presença do Sprite de Aniversário
                    var birthDayClass = By.ClassName("glyphsSpriteBirthday_cake");
                    wait.Until(ExpectedConditions.ElementIsVisible(birthDayClass));

                    var selectElementLocator = By.TagName("select");
                    wait.Until(ExpectedConditions.ElementIsVisible(selectElementLocator));
                    var selectElement = driver.FindElements(selectElementLocator);//.Where(x => x.GetAttribute("href") == "//");

                    //MessageBox.Show("Quantidade de Selects = " + selectElement.Count.ToString());

                    //select 0 = mês
                    //select 1 = dia
                    //select 2 = ano
                    //select 3 = idioma

                    var selectMes = new SelectElement(selectElement[0]);
                    selectMes.SelectByValue(pessoa.DataNascimento.Month.ToString());

                    var selectDia = new SelectElement(selectElement[1]);
                    selectDia.SelectByValue(pessoa.DataNascimento.Day.ToString());

                    var selectAno = new SelectElement(selectElement[2]);
                    selectAno.SelectByValue(pessoa.DataNascimento.Year.ToString());





                    var buttonLocator = By.TagName("Button");
                    wait.Until(ExpectedConditions.ElementIsVisible(buttonLocator));
                    var buttonElement = driver.FindElements(buttonLocator);

                    //foreach (var element in buttonElement)
                    //{
                    //    this.richTextBox1.AppendText("button Type=:" + element.GetProperty("type"));
                    //    this.richTextBox1.AppendText(element.Text + "\n");

                    //}

                    buttonElement[1].Click();

                    //Verificar a presença do Sprite de Confirmação
                    var phoneSpriteConfirmationClass = By.ClassName("glyphsSpritePhone_confirm");
                    wait.Until(ExpectedConditions.ElementIsVisible(phoneSpriteConfirmationClass));


                    //TryGet SMS
                    var getSms = smsPvaService.GetSms(lowestPriceCountry.country, numberObject.id);

                    int i = 0;

                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    while (getSms.sms == null)
                    {
                        getSms = smsPvaService.GetSms(lowestPriceCountry.country, numberObject.id);
                        System.Threading.Thread.Sleep(20000);
                        i += 20000;
                        
                        if (stopwatch.ElapsedMilliseconds >= TimeSpan.FromMinutes(10).TotalMilliseconds)
                        {
                            //TODO: ban Number
                            var retornoBan = smsPvaService.BanNumber(numberObject.id);
                            break;
                        }
                    }


                    //Confirmation Code Input
                    var confirmCodeInputLocator = By.Name("confirmationCode");
                    wait.Until(ExpectedConditions.ElementIsVisible(confirmCodeInputLocator));
                    var confirmationCodeInputElement = driver.FindElement(confirmCodeInputLocator);
                    //confirmationCodeInputElement.SendKeys("9829384");
                    confirmationCodeInputElement.SendKeys(getSms.sms);

                    //Click The Button
                    //Wich button ? 
                    buttonLocator = By.TagName("Button");
                    wait.Until(ExpectedConditions.ElementIsVisible(buttonLocator));
                    buttonElement = driver.FindElements(buttonLocator);

                    buttonElement[0].Click();
                    //0-button text: Confirm
                    //1-button text: Change Number
                    //2-button text: Request New Code

                    //Esperar aparecer o SearchBar
                    var searchBarIconClass = By.ClassName("coreSpriteSearchIcon");
                    wait.Until(ExpectedConditions.ElementIsVisible(searchBarIconClass));

                    //foreach (var element in buttonElement)
                    //{
                    //    //this.richTextBox1.AppendText("button Type=:" + element.GetProperty("type"));
                    //    this.richTextBox1.AppendText("button text::" + element.Text);
                    //    this.richTextBox1.AppendText(element.Text + "\n");

                    //}



                    richTextBox1.ScrollToCaret();

                    //0 - Why Do we need birthday
                    //1 - next
                    //2 - back


                    //foreach (var element in selectElement)
                    //{
                    //    var select = new SelectElement(element);


                    //    var elementHreftext = (element.GetProperty("title"));
                    //    this.richTextBox1.AppendText(elementHreftext + "\n");

                    //    foreach (var option in select.Options)
                    //    {
                    //        var valuefromOption = option.GetProperty("value");

                    //        this.richTextBox1.AppendText(valuefromOption + "\n");

                    //    }
                    //    //  selectElelemt.Options.ToList().ForEach(x => {
                    //    //      x.GetProperty("value")
                    //    //var elementHreftext = (element.GetProperty("type"));
                    //    //  if (elementHreftext.Contains("submit"))

                    //}

                    _mongoConnection.Pessoas.InsertOne(pessoa);

                 
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    try
                    {
                        if (driver != null)
                            driver.Close();

                        if (process != null)
                        process.Kill();
                    }
                    catch (Exception exc)
                    {

                    }
                    finally
                    {
                        userInfo = smsPvaService.GetUserInfo();
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SMSPVA _smsPvaService = new SMSPVA();
            //_smsPvaService.GetChepeastCountrySMSReceive();
            var _profileGenerator = new ProfilerGenerator();
            var pessoa = _profileGenerator.Generate();

            ProcessStartInfo info = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                FileName = @"C:\Users\Peterson Andrade\source\repos\InstaAccCreator_netframework\bin\x64\Debug\InstaAccCreator_netframework.exe",
                Arguments = pessoa.Proxy.username + ":" + pessoa.Proxy.password + "@" + pessoa.Proxy.proxy_address + ":" + pessoa.Proxy.ports.http.ToString()
            };
            var process = Process.Start(info);


            //var smsPvaService = new SMSPVA();
            //var lowestPriceCountry = smsPvaService.GetChepeastCountrySMSReceive().ElementAt(0);

            //var numberObject = smsPvaService.GetNumber(lowestPriceCountry.country);


            //var getSms = smsPvaService.GetSms(lowestPriceCountry.country, numberObject.id);

            var options = new ChromeOptions();
            //options.AddArgument("--proxy-server=" + pessoa.Proxy.username + ":" + pessoa.Proxy.password + "@" + pessoa.Proxy.proxy_address + ":" + pessoa.Proxy.ports.http.ToString());
            options.DebuggerAddress = "localhost:8081";
            options.PageLoadStrategy = PageLoadStrategy.Normal;
            var driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://instagram.com");



        }

        private void button3_Click(object sender, EventArgs e)
        {

            var smsPvaService = new SMSPVA();
            var userInfo = smsPvaService.GetUserInfo();
            this.smsPvaBalanceLabel.Text = userInfo.balance.ToString();

            var _profileGenerator = new ProfilerGenerator();
            var pessoa = _profileGenerator.Generate();

            var countriesOrderByPriceDesc = smsPvaService.GetChepeastCountrySMSReceive();
            var lowestPriceCountries = countriesOrderByPriceDesc.Where(x => x.price <= Convert.ToDecimal(0.20)).ToList();
            var r = new Random();
            var y = r.Next(0, lowestPriceCountries.Count);
            var lowestPriceRandomCountry = lowestPriceCountries.ElementAt(y);
            var lowestPriceCountry = lowestPriceRandomCountry;
            CountryCodes countryCodes = new CountryCodes();
            var countryCodeDetails = countryCodes.AllCountries.Where(x => x.isoCode2digits == lowestPriceCountry.country).First();
            var numberObject = smsPvaService.GetNumber(lowestPriceCountry.country);
            numberObject.number = "+" + countryCodeDetails.countryCode + numberObject.number;
            pessoa.Number = numberObject;

            this.profileNameBox.Text = pessoa.Nome;
            this.profileGenderBox.Text = pessoa.Sexo.ToString();
            this.profileUsernameBox.Text = pessoa.UserName;
            this.profilePasswordBox.Text = pessoa.Senha;
            this.profileProxyBox.Text = pessoa.Proxy.proxy_address;
            this.profileNumberBox.Text = pessoa.Number.number;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new PythonWrapper().run_cmd("", "");
        }
    }
}
