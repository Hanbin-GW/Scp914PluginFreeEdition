using System.ComponentModel;
using Exiled.API.Interfaces;

namespace Scp914PluginFreeEdition
{
    public class Config : IConfig
    {
        [Description("플러그인 활성화 여부")]
        public bool IsEnabled { get; set; } = true;
        [Description("플러그인 디버그 여부")]
        public bool Debug { get; set; } = false;

        [Description("Veryfine 랜덤 효과")]
        public string ChangeRoleBroadcast { get; set; } = "당신의 외형은 %name% 로 변경되었습니다.";
    }
}