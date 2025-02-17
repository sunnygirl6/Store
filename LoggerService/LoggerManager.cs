﻿using NLog;
using Store.Core.Interfaces;

namespace Store.LoggerService
{
    public class LoggerManager : ILoggerManager
    {
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        public void Warn(string message)
        {
            logger.Warn(message);
        }
        public void Info(string message)
        {
            logger.Info(message);
        }
        public void Error(string message)
        {
            logger.Error(message);
        }
        public void Debug(string message)
        {
            logger.Debug(message);
        }
    }
}
