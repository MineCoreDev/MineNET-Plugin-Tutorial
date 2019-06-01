using MineNET;
using MineNET.IO;
using MineNET.Plugins;

namespace PluginTemplate
{
    public class Plugin : PluginBase
    {
        public override string Name => "PluginTemplate";

        public override void OnEnable()
        {
            Logger.Info($"> Enable {this.Name}!!");
        }

        public override void OnDisable()
        {
            Logger.Info($"> Disable {this.Name}!!");
        }
    }
}