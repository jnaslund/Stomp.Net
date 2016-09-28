#region Usings

using System;

#endregion

namespace Apache.NMS
{
    /// <summary>
    ///     A consumer of messages
    /// </summary>
    public interface IMessageConsumer : IDisposable
    {
        /// <summary>
        ///     Closes the message consumer.
        /// </summary>
        /// <remarks>
        ///     Clients should close message consumers them when they are not needed.
        ///     This call blocks until a receive or message listener in progress has completed.
        ///     A blocked message consumer receive call returns null when this message consumer is closed.
        /// </remarks>
        void Close();

        /// <summary>
        ///     An asynchronous listener which can be used to consume messages asynchronously
        /// </summary>
        event Action<IMessage> Listener;

        /// <summary>
        ///     If a message is available within the timeout duration it is returned otherwise this method returns null
        /// </summary>
        /// <param name="timeout">An optimal timeout, if not specified infinity will be used.</param>
        /// <returns>Returns the received message, or null in case of a timeout.</returns>
        IMessage Receive( TimeSpan? timeout = null );
    }
}