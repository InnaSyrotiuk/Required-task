using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestFramework.POM
{
    public abstract class BasePage
    {
        protected ExtDriver driver;

        public BasePage()
        {
            driver = DriverFabric.GetDriver();
        }

        public void Wait(int time)
        {
            Thread.Sleep(time);
        }

        public virtual void Initialize()
        {

        }

    }
}
