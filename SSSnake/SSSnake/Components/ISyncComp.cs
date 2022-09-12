using Lidgren.Network;

namespace SSSnake.Components;

public interface ISyncComp
{
    public void ReadFromServer(NetIncomingMessage msg);

    public void SendToClient(NetOutgoingMessage msg);
}