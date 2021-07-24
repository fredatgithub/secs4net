﻿using System;

namespace Secs4Net
{
    public record SecsGemOptions
    {
        public ushort DeviceId { get; init; }

        /// <summary>
        /// Configure connection as Active or Passive mode.
        /// </summary>
        public bool IsActive { get; init; }

        /// <summary>
        /// When <see cref="IsActive">IsActive</see> is <see langword="true"/> the IP address will be treated remote device's IP address, 
        /// opposite the connection will bind on this IP address as Passive mode.
        /// </summary>
        public string? IpAddress { get; init; }

        /// <summary>
        /// When <see cref="IsActive">IsActive</see> is <see langword="true"/> the port number will be treated remote device's TCP port number, 
        /// opposite the connection will bind on the port number as Passive mode.
        /// </summary>
        public int Port { get; init; }

        /// <summary>
        /// Configure the timeout interval in milliseconds between the primary message sent till to receive the secondary message.
        /// Default value is 45000 milliseconds.
        /// </summary>
        public int T3 { get; init; } = 45000;

        /// <summary>
        /// Configure the timeout interval in milliseconds between the connection state transition from <see cref="ConnectionState.Connecting">Connecting</see> to <see cref="ConnectionState.Connected">Connected</see>.
        /// Default value is 10000 milliseconds.
        /// </summary>
        public int T5 { get; init; } = 10000;

        /// <summary>
        /// Configure the timeout interval in milliseconds between the control message sent till to receive the reply message.
        /// Default value is 5000 milliseconds.
        /// </summary>
        public int T6 { get; init; } = 5000;

        /// <summary>
        /// Configure the timeout interval in milliseconds between the connection state transition from <see cref="ConnectionState.Connected">Connected</see> to <see cref="ConnectionState.Selected">Selected</see>.
        /// Default value is 10000 milliseconds.
        /// </summary>
        public int T7 { get; init; } = 10000;

        /// <summary>
        /// Configure the timeout interval in milliseconds between the chunk received to next chunk during decoding a <see cref="SecsMessage"/>.
        /// Default value is 5000 milliseconds.
        /// </summary>
        public int T8 { get; init; } = 5000;

        /// <summary>
        /// Configure the timer interval in milliseconds between each <see cref="MessageType.LinkTestRequest"/> request.
        /// Default value is 60000.
        /// </summary>
        public int LinkTestInterval { get; init; } = 60000;

        /// <summary>
        /// Configure the buffer size in bytes used for the <see cref="System.Net.Sockets.Socket.ReceiveAsync(Memory{byte}, System.Net.Sockets.SocketFlags, System.Threading.CancellationToken)">Socket.ReceiveAsync</see> receiving.
        /// Default value is 65535 bytes.
        /// </summary>
        public int SocketReceiveBufferSize { get; init; } = 65535;

        /// <summary>
        /// Configure the initial buffer size in bytes for the <see cref="SecsMessage"/> encoding.
        /// Default value is 65535 bytes.
        /// </summary>
        public int SocketSendBufferInitialSize { get; init; } = 65535;
    }
}
