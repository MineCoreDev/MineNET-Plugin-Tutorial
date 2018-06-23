using MineNET;
using MineNET.Plugins;

namespace PluginTemplate
{
    public class Plugin : PluginBase
    {
        public override string Name
        {
            get
            {
                return "PluginTemplate";
            }
        }

        public override void OnEnable()
        {
            OutLog.Info($"> Enable {this.Name}!!");
        }

        public override void OnDisable()
        {
            OutLog.Info($"> Disable {this.Name}!!");
        }
    }
}
