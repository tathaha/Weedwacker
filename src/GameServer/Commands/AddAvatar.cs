﻿using System.CommandLine;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Commands;
using Weedwacker.Shared.Enums;

namespace Weedwacker.GameServer.Commands
{
    internal static partial class GameServerCommands
    {
        private static void InitAvatarAdd()
        {
            var AvatarIdArgument = new Argument<int>(name: "AvatarId");

            Command AddavatarCommand = new("addavatar", "Add avatar to player") { };

            AddavatarCommand.SetHandler(OnAddAvatar, UserRank.Player, AvatarIdArgument, guidArgument);
            AddavatarCommand.AddArgument(guidArgument);
            AddavatarCommand.AddArgument(AvatarIdArgument);

            ConsoleHandler.AddCommand(AddavatarCommand);
        }

        internal static async Task OnAddAvatar(IConsole console, int avatarId, int guid) // AvatarId, GameUid
        {
            if (!GameServer.AvatarInfo.ContainsKey((uint)avatarId))
            {
                console.WriteLine( "Invalid avatar id");
                return;
            }
            if (!GameServer.OnlinePlayers.ContainsKey((uint)guid))
            {
                console.WriteLine("Player isn't online or doesn't exist");
                return;
            }
            Player player = GameServer.OnlinePlayers[(uint)guid].Player;

            if (player.Avatars.HasAvatar((uint)avatarId))
            {
                console.WriteLine ("You already have that avatar!");
                return;
            }

            var newAvatar = await Avatar.CreateAsync((uint)avatarId, GameServer.OnlinePlayers[(uint)guid].Player);
            await player.Avatars.AddAvatar(newAvatar);
            console.WriteLine($"Added avatar {avatarId} to player {guid}");
        }
    }
}
