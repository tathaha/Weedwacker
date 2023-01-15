﻿using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class AbilityGadgetEntity : BaseGadgetEntity
    {
        private uint CampId;
        private uint CampType;
        private uint TargetEntityId;
        protected AbilityGadgetEntity(Scene? scene, uint gadgetId) : base(scene, gadgetId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();
            AbilityGadgetInfo abilityGadget = new()
            {
                CampId = CampId,
                CampTargetType = CampType,
                TargetEntityId = TargetEntityId
            };
            info.Gadget.AbilityGadget = abilityGadget;

            return info;
        }
    }
}
