using System;

namespace Ascender
{
    /// <summary>
    /// Interface to implement for your own logger
    /// </summary>
    public interface INetLogger
    {
        void WriteNet(ConsoleColor color, string str, params object[] args);
    }

    /// <summary>
    /// Static class for defining your own Ascender logger instead of Console.WriteLine
    /// or Debug.Log if compiled with UNITY flag
    /// </summary>
    public static class NetDebug
    {
        public static INetLogger Logger = null;
    }
}
