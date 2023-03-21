using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altom.AltDriver;

namespace Assets.AltTester.Editor.pages
{
    public class BasePage
    {
        AltDriver altDriver;

        //Getter trả về giá trị của biến altDriver và Setter gán giá trị của biến altDriver bằng giá trị được truyền vào.
        public AltDriver Driver { 
            get => altDriver; 
            set => altDriver = value; 
        }
        public BasePage(AltDriver driver)
        {
            Driver = driver;
        }
    }
}
