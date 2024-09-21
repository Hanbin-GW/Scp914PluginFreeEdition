using Exiled.API.Interfaces;

namespace Scp914PluginFreeEdition
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public string ChangeRoleBroadcast { get; set; } = "당신은 %role 로 외형이 변화되었습니다.";
    }
}