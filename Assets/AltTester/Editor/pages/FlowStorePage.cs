using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altom.AltDriver;
using static UnityEditor.Experimental.GraphView.GraphView;

namespace Assets.AltTester.Editor.pages
{
    public class FlowStorePage : BasePage
    {
        public FlowStorePage(AltDriver driver) : base(driver)
        {
        }

        public AltObject ItemInvincible { get => Driver.WaitForObject(By.PATH, "//Canvas/Background/ItemsList/Container/ItemEntry(Clone)/NamePriceButtonZone/Name[@text=Invincible]", timeout: 15); }
        public void ScrollBottom()
        {
            AltVector3 cubeInitialPosition = new AltVector3(ItemInvincible.worldX, ItemInvincible.worldY, ItemInvincible.worldY);
            Driver.Scroll(3, 2);

        }
    }
}
