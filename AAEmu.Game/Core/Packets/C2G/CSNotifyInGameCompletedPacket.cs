using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSNotifyInGameCompletedPacket : GamePacket
    {
        public CSNotifyInGameCompletedPacket() : base(0x028, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            _log.Info("NotifyInGameCompleted");
        }
    }
}