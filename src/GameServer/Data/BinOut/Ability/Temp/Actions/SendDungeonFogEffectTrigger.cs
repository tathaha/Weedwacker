﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SendDungeonFogEffectTrigger : BaseAction
    {
        [JsonProperty] public readonly string parameter;
        [JsonProperty] public readonly string cameraFogEffectName;
    }
}
