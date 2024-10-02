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
        [Description("Veryfine 랜덤 효과")]
        public string SizeSmallBroadcast { get; set; } = "당신은 30초동안 작아지고 빨라집니다.";
        [Description("Veryfine 랜덤 효과")]
        public string TankerBroadcast { get; set; } = "당신은 30초동안 탱커입니다!\n이동속도 감소 + 대미지 저항 감소";
        [Description("1:1 랜덤 효과")]
        public string Invincibility { get; set; } = "당신은 60초동안 무적입니다!!!";
    }
}