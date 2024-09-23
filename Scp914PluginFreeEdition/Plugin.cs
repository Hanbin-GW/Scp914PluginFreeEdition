﻿using System;
using CustomPlayerEffects;
using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Scp914;
using MEC;
using PlayerRoles;
using Scp914;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Scp914PluginFreeEdition
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "Scp914Plugin-Free edition";
        public override string Author { get; } = "Hanbin-GW";
        public override Version Version { get; } = new Version(0, 2, 0);

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Scp914.UpgradingPlayer += OnUpgradingPlayer;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Scp914.UpgradingPlayer -= OnUpgradingPlayer;
            base.OnDisabled();
        }

        private void OnUpgradingPlayer(UpgradingPlayerEventArgs ev)
        {
            var random = Random.Range(0, 100);

            if (ev.KnobSetting == Scp914KnobSetting.VeryFine)
            {
                if (random <= 10)
                {
                    ev.Player.Scale = new Vector3(0.5f, 0.5f, 0.5f);
                    ev.Player.EnableEffect<MovementBoost>(duration: 30, intensity: 50);
                    ev.Player.Broadcast(5,Config.SizeSmallBroadcast);
                    Timing.CallDelayed(30, () => ev.Player.Scale = new Vector3(1f, 1f, 1f));
                }
                else if (random <= 40)
                {
                    RoleTypeId roleReference = RoleTypeIdData();
                    ev.Player.ChangeAppearance(roleReference, skipJump:true);
                    string message = Config.ChangeRoleBroadcast.Replace("%name%", roleReference.ToString());
                    ev.Player.Broadcast(5,Config.ChangeRoleBroadcast);
                }
                else if (random <= 90)
                {
                    ev.Player.EnableEffect<Slowness>(duration: 30, intensity: 30);
                    ev.Player.EnableEffect<DamageReduction>(duration: 30, intensity: 50);
                    ev.Player.Broadcast(5,Config.TankerBroadcast); 
                }
                else
                {
                    ev.Player.Broadcast(5,"당신의 몸은 부식되고 있습니다....");
                    ev.Player.EnableEffect<CardiacArrest>(duration: 5);
                    Timing.CallDelayed(5, () => ev.Player.Role.Set(RoleTypeId.Scp3114));
                }
            }
        }

        private RoleTypeId RoleTypeIdData()
        {
            RoleTypeId[] role =
            {
                RoleTypeId.Scp173, RoleTypeId.ClassD, RoleTypeId.Scp106, RoleTypeId.NtfSpecialist, RoleTypeId.Scp049,
                RoleTypeId.Scientist, RoleTypeId.ChaosConscript, RoleTypeId.Scp096, RoleTypeId.Scp0492, RoleTypeId.Tutorial,
                RoleTypeId.FacilityGuard,RoleTypeId.Scp939,RoleTypeId.ChaosRifleman, RoleTypeId.Scp3114
            };
            var newRole = role[Random.Range(0, role.Length)];
            return newRole;
        }
    }
}
