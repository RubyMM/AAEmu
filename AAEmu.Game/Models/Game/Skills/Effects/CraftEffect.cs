using AAEmu.Game.Models.Game.Skills.Templates;

namespace AAEmu.Game.Models.Game.Skills.Effects
{
    public class CraftEffect : EffectTemplate
    {
        public uint WorldInteractionId { get; set; }

        public override bool OnActionTime => false;
    }
}