﻿using Akka.Actor;

using Google.Protobuf;
using Google.Protobuf.Protocol;
using Server;
using ServerCore;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

public class PacketHandler
{
    public static void C_EnterServerHandler(PacketSession session, IMessage packet)
    {
        ClientSession clientSession = (ClientSession)session;
        C_EnterServer enterPacket = (C_EnterServer)packet;

        clientSession.EnterServerHandler();
    }
    public static void C_ChatHandler(PacketSession session, IMessage packet)
    {
        ClientSession clientSession = (ClientSession)session;
        C_Chat c_chat = (C_Chat)packet;

        if (clientSession == null)
            return;

        IActorRef room = clientSession.Room;

        if (room == null)
            return;

        room.Tell(new MessageCustom<ClientSession, C_Chat>(clientSession, c_chat));
    }
}
