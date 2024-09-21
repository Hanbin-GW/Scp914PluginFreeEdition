using Exiled.API.Interfaces;

namespace Scp914PluginFreeEdition
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
    }
}