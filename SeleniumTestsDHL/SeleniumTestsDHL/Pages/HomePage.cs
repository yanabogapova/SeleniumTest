using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace SeleniumTestsDHL.Pages
{
    class HomePage : BaseClass
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver, this);
        }
        Actions hover = new Actions(Driver);

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement EmailId { get; set; }

        [FindsBy(How = How.Id, Using = "TPcockpit")]
        public IWebElement tpCockpitTile { get; set; }

        [FindsBy(How = How.Id, Using = "TPworkflow")]
        public IWebElement tpWorkflowTile { get; set; }

        [FindsBy(How = How.Id, Using = "TPtransactions")]
        public IWebElement tpTransactionsTile { get; set; }

        public string HoverTiles(string tilesName)
        {
            IWebElement tile = Driver.FindElement(By.Id(tilesName));
            hover.MoveToElement(tile);
            Thread.Sleep(2000);
            hover.Perform();
            string tooltipText = tile.GetAttribute("longdesc");
            return tooltipText;

        }


    }
}
