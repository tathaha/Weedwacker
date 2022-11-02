﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TriggerID
    {
        None,
        AimEnd,
        AlchemicalBreakOutSkin,
        Appear,
        Attack,
        AutoDefendTrigger,
        BornToClose,
        BornToOpen,
        Break,
        BurstSkinSet,
        Crow_Talent_C_ExtreAttack,
        DevilDash_Skin,
        Dice_Attack,
        Dice_Die,
        Die,
        DoSkill,
        ElementalBurst_Skin,
        EndHoldTrigger,
        ExtraAttack_Skin,
        GemStone_Impact,
        GeoOrderSkin_Strong,
        GeoOrderSkin_Weak,
        Heal,
        Hide_Avatar_OnRemoved,
        Idle,
        Mark_1,
        Mark_2,
        Mark_End_1,
        Mark_End_2,
        Mask_TriggerTalent,
        NextLoopTrigger,
        NextSkillTrigger,
        PRIVATE_DoLastSpecialExtra,
        PRIVATE_DoSpecialExtra,
        PRIVATE_ElementalArt_End,
        PRIVATE_ExtraEndCharging,
        PRIVATE_NormalToSneak,
        PRIVATE_SneakToNormal,
        Skill_E_SpecialSkin,
        Skill_E_SpecialToNormalSkin,
        Skin_Strong,
        SkinActive_1,
        SkinActive_2,
        SkinOn,
        SkinReset,
        SkinSet,
        SkinTrigger,
        Sprint_Skin,
        Start,
        StealthOff,
        StealthOn,
        Switch,
        Trigger_Burst,
        Trigger_Hit,
    }
}