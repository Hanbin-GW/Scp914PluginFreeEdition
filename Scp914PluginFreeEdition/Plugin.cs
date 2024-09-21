using System;
using Exiled.API.Features;

namespace Scp914PluginFreeEdition
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "Scp914Plugin-Free edition";
        public override string Author { get; } = "Hanbin-GW";
        public override Version Version { get; } = new Version(0, 1, 0);

        public override void OnEnabled()
        {
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
        }
    }
}