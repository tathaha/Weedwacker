﻿using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AirFlowMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int gadgetID;
        [JsonProperty] public readonly TargetType campTargetType;
        [JsonProperty] public readonly ConfigBornType born;
    }
}
