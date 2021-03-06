using AAEmu.Game.Models.Game.Skills.Templates;
using AAEmu.Game.Models.Game.World;

namespace AAEmu.Game.Models.Game.Skills.Effects
{
    public class InteractionEffect : EffectTemplate
    {
        public WorldInteractionType WorldInteraction { get; set; }
        public uint DoodadId { get; set; }

        public override bool OnActionTime { get { return false; } }
    }
}