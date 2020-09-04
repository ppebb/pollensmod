using PoroCYon.MCT;
using TAPI;

namespace PollensMod
{
    class PollensMod : ModBase
    {
        public override void OnLoad()
        {
            Mct.Init();
        }
    }
}
