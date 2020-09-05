using TAPI;
using PoroCYon.MCT;

namespace PollensMod
{
    public class PollensMod : ModBase
    {
        public override void OnLoad()
        {
            Mct.Init();
        }
    }
}
