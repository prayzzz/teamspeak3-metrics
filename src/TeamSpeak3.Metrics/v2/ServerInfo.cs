namespace TeamSpeak3.Metrics.v2
{
    public class ServerInfo
    {
        public int ConnectionBytesReceivedTotal { get; set; }

        public int ConnectionBytesSentTotal { get; set; }

        public int VirtualServerChannelsOnline { get; set; }

        public int VirtualServerClientConnections { get; set; }

        public int VirtualServerClientsOnline { get; set; }

        public string VirtualServerCreated { get; set; }

        public int VirtualServerId { get; set; }

        public string VirtualServerIp { get; set; }

        public int VirtualServerMaxclients { get; set; }

        public string VirtualServerName { get; set; }

        public string VirtualServerPlattform { get; set; }

        public int VirtualServerPort { get; set; }

        public int VirtualServerQueryClientConnections { get; set; }

        public int VirtualServerQueryClientsOnline { get; set; }

        public string VirtualServerStatus { get; set; }

        public double VirtualServerTotalPing { get; set; }

        public string VirtualServerUniqueIdentifier { get; set; }

        public string VirtualServerUptime { get; set; }

        public string VirtualServerVersion { get; set; }
    }
}