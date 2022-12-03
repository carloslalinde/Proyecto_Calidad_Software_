using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace G2_SC405_JN_EJECUCION
{
    [TestFixture]
    [Parallelizable]
    public class Test : Base
    {
        [Test]
        public void Login()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
            System.Threading.Thread.Sleep(8000);
            driver.FindElement(By.Name("USERNAME")).SendKeys("manu1");
            driver.FindElement(By.Name("PASSWORD")).SendKeys("123");
            driver.FindElement(By.Name("login")).Click();
            System.Threading.Thread.Sleep(5000);

        }


        [TestFixture]
        [Parallelizable]
        public class Test2 : Base
        {
            [Test]
            public void ResetPass()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("forgot")).Click();
                driver.FindElement(By.Name("USERNAME")).SendKeys("test123");
                driver.FindElement(By.Name("send")).Click();
                System.Threading.Thread.Sleep(5000);

            }
        }


        [TestFixture]
        [Parallelizable]
        public class Test3 : Base
        {
            [Test]
            public void LoginFailed()
            {

                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("USERNAME")).SendKeys("Test");
                driver.FindElement(By.Name("login")).Click();
                System.Threading.Thread.Sleep(5000);

            }
        }

        [TestFixture]
        [Parallelizable]
        public class Test4 : Base
        {
            [Test]
            public void HomeNavBarSideBar()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("USERNAME")).SendKeys("manu1");
                driver.FindElement(By.Name("PASSWORD")).SendKeys("123");
                driver.FindElement(By.Name("login")).Click();
            }
        }



        [TestFixture]
        [Parallelizable]
        public class Test5 : Base
        {
            [Test]
            public void InventoryView()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("USERNAME")).SendKeys("manu1");
                driver.FindElement(By.Name("PASSWORD")).SendKeys("123");
                driver.FindElement(By.Name("login")).Click();
                driver.FindElement(By.Name("inventario")).Click();
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.Name("ver inventario")).Click();
                System.Threading.Thread.Sleep(5000);

            }
        }

        [TestFixture]
        [Parallelizable]
        public class Test6 : Base
        {
            [Test]
            public void CartView()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("USERNAME")).SendKeys("manu1");
                driver.FindElement(By.Name("PASSWORD")).SendKeys("123");
                driver.FindElement(By.Name("login")).Click();
                driver.FindElement(By.Name("compras")).Click();
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.Name("ver carrito")).Click();
                System.Threading.Thread.Sleep(5000);

            }
        }

        [TestFixture]
        [Parallelizable]
        public class Test7 : Base
        {
            [Test]
            public void ViewCustomer()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("USERNAME")).SendKeys("manu1");
                driver.FindElement(By.Name("PASSWORD")).SendKeys("123");
                driver.FindElement(By.Name("login")).Click();
                driver.FindElement(By.Name("clientes")).Click();
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.Name("ver clientes")).Click();
                System.Threading.Thread.Sleep(5000);

            }
        }

        [TestFixture]
        [Parallelizable]
        public class Test8 : Base
        {
            [Test]
            public void GoogleMaps()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("USERNAME")).SendKeys("manu1");
                driver.FindElement(By.Name("PASSWORD")).SendKeys("123");
                driver.FindElement(By.Name("login")).Click();
                driver.FindElement(By.Name("ubicacion")).Click();
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.Name("ver ubicacion")).Click();
                System.Threading.Thread.Sleep(5000);

            }
        }

        [TestFixture]
        [Parallelizable]
        public class Test9 : Base
        {
            [Test]
            public void ChangePassword()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("USERNAME")).SendKeys("manu1");
                driver.FindElement(By.Name("PASSWORD")).SendKeys("123");
                driver.FindElement(By.Name("login")).Click();
                driver.FindElement(By.Name("configuracion")).Click();
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.Name("cambiar contraseña")).Click();
                System.Threading.Thread.Sleep(5000);

            }
        }

        [TestFixture]
        [Parallelizable]
        public class Test10 : Base
        {
            [Test]
            public void ViewProfile()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("USERNAME")).SendKeys("manu1");
                driver.FindElement(By.Name("PASSWORD")).SendKeys("123");
                driver.FindElement(By.Name("login")).Click();
                driver.FindElement(By.Name("configuracion")).Click();
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.Name("ver perfil")).Click();
                System.Threading.Thread.Sleep(5000);

            }
        }

        [TestFixture]
        [Parallelizable]
        public class Test11 : Base
        {
            [Test]
            public void ViewEmployees()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("USERNAME")).SendKeys("manu1");
                driver.FindElement(By.Name("PASSWORD")).SendKeys("123");
                driver.FindElement(By.Name("login")).Click();
                driver.FindElement(By.Name("empleados")).Click();
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.Name("ver empleados")).Click();
                System.Threading.Thread.Sleep(5000);

            }
        }

        [TestFixture]
        [Parallelizable]
        public class Test12 : Base
        {
            [Test]
            public void RegisterEmployees()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("USERNAME")).SendKeys("manu1");
                driver.FindElement(By.Name("PASSWORD")).SendKeys("123");
                driver.FindElement(By.Name("login")).Click();
                driver.FindElement(By.Name("empleados")).Click();
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.Name("registrar empleados")).Click();
                System.Threading.Thread.Sleep(5000);

            }
        }

        [TestFixture]
        [Parallelizable]
        public class Test13 : Base
        {
            [Test]
            public void ViewPurchases()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("USERNAME")).SendKeys("manu1");
                driver.FindElement(By.Name("PASSWORD")).SendKeys("123");
                driver.FindElement(By.Name("login")).Click();
                driver.FindElement(By.Name("compras")).Click();
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.Name("ver compras")).Click();
                System.Threading.Thread.Sleep(5000);

            }
        }

        [TestFixture]
        [Parallelizable]
        public class Test14 : Base
        {
            [Test]
            public void ViewInventoryChanges()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("USERNAME")).SendKeys("manu1");
                driver.FindElement(By.Name("PASSWORD")).SendKeys("123");
                driver.FindElement(By.Name("login")).Click();
                driver.FindElement(By.Name("inventario")).Click();
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.Name("ver registro inventario")).Click();
                System.Threading.Thread.Sleep(5000);

            }
        }

        [TestFixture]
        [Parallelizable]
        public class Test15 : Base
        {
            [Test]
            public void Logout()
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://localhost:44369/Login/Index");
                driver.FindElement(By.Name("USERNAME")).SendKeys("manu1");
                driver.FindElement(By.Name("PASSWORD")).SendKeys("123");
                driver.FindElement(By.Name("login")).Click();
                System.Threading.Thread.Sleep(5000);
                driver.FindElement(By.Name("logout")).Click();
                System.Threading.Thread.Sleep(1000);
            }
        }

    }

}
