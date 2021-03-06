﻿using System;
using System.Diagnostics;
using System.Reflection;

namespace FastCore
{
    /// <summary>
    /// 日志(输出到跟踪窗口)
    /// </summary>
    public static class LogTrace
    {
        /// <summary>
        /// 写调试日志
        /// </summary>
        /// <param name="exception">异常</param>
        /// <param name="source">来源</param>
        /// <param name="extraData">附加数据</param>
        public static void Debug(Exception exception, MethodBase source = null, string extraData = "")
        {
            // 设置类型
            Trace.Write("debug");

            // 设置时间
            Trace.Write($"({DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")})");

            // 设置消息
            Trace.Write(": " + exception.Message);

            // 设置来源
            if (source == null)
            {
                Trace.Write($" 发生在: {exception.Source}");
            }
            else
            {
                Trace.Write($" 发生在: {source.ReflectedType.FullName}.{source.Name}");
            }

            // 设置详情
            if (!string.IsNullOrEmpty(exception.StackTrace))
            {
                Trace.WriteLine("");
                Trace.Write(exception.StackTrace);
            }

            // 设置附加数据
            if (!string.IsNullOrEmpty(extraData))
            {
                Trace.WriteLine("");
                Trace.Write(extraData);
            }

            Trace.WriteLine("");
        }

        /// <summary>
        /// 写调试日志
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="source">来源</param>
        /// <param name="extraData">附加数据</param>
        public static void Debug(string message, MethodBase source = null, string extraData = "")
        {
            // 设置类型
            Trace.Write("debug");

            // 设置时间
            Trace.Write($"({DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")})");

            // 设置消息
            Trace.Write(": " + message);

            // 设置来源
            if (source != null)
            {
                Trace.Write($" 发生在: {source.ReflectedType.FullName}.{source.Name}");
            }

            // 设置附加数据
            if (!string.IsNullOrEmpty(extraData))
            {
                Trace.WriteLine("");
                Trace.Write(extraData);
            }

            Trace.WriteLine("");
        }

        /// <summary>
        /// 写信息日志
        /// </summary>
        /// <param name="exception">异常</param>
        /// <param name="source">来源</param>
        /// <param name="extraData">附加数据</param>
        public static void Info(Exception exception, MethodBase source = null, string extraData = "")
        {
            // 设置类型
            Trace.Write("info ");

            // 设置时间
            Trace.Write($"({DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")})");

            // 设置消息
            Trace.Write(": " + exception.Message);

            // 设置来源
            if (source == null)
            {
                Trace.Write($" 发生在: {exception.Source}");
            }
            else
            {
                Trace.Write($" 发生在: {source.ReflectedType.FullName}.{source.Name}");
            }

            // 设置详情
            if (!string.IsNullOrEmpty(extraData))
            {
                Trace.WriteLine("");
                Trace.Write(exception.StackTrace);
            }

            // 设置附加数据
            if (!string.IsNullOrEmpty(extraData))
            {
                Trace.WriteLine("");
                Trace.Write(extraData);
            }

            Trace.WriteLine("");
        }

        /// <summary>
        /// 写信息日志
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="source">来源</param>
        /// <param name="extraData">附加数据</param>
        public static void Info(string message, MethodBase source = null, string extraData = "")
        {
            // 设置类型
            Trace.Write("info ");

            // 设置时间
            Trace.Write($"({DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")})");

            // 设置消息
            Trace.Write(": " + message);

            // 设置来源
            if (source != null)
            {
                Trace.Write($" 发生在: {source.ReflectedType.FullName}.{source.Name}");
            }

            // 设置附加数据
            if (!string.IsNullOrEmpty(extraData))
            {
                Trace.WriteLine("");
                Trace.Write(extraData);
            }

            Trace.WriteLine("");
        }

        /// <summary>
        /// 写警告日志
        /// </summary>
        /// <param name="exception">异常</param>
        /// <param name="source">来源</param>
        /// <param name="extraData">附加数据</param>
        public static void Warn(Exception exception, MethodBase source = null, string extraData = "")
        {
            // 设置类型
            Trace.Write("warn ");

            // 设置时间
            Trace.Write($"({DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")})");

            // 设置消息
            Trace.Write(": " + exception.Message);

            // 设置来源
            if (source == null)
            {
                Trace.Write($" 发生在: {exception.Source}");
            }
            else
            {
                Trace.Write($" 发生在: {source.ReflectedType.FullName}.{source.Name}");
            }

            // 设置详情
            if (!string.IsNullOrEmpty(exception.StackTrace))
            {
                Trace.WriteLine("");
                Trace.Write(exception.StackTrace);
            }

            // 设置附加数据
            if (!string.IsNullOrEmpty(extraData))
            {
                Trace.WriteLine("");
                Trace.Write(extraData);
            }

            Trace.WriteLine("");
        }

        /// <summary>
        /// 写警告日志
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="source">来源</param>
        /// <param name="extraData">附加数据</param>
        public static void Warn(string message, MethodBase source = null, string extraData = "")
        {
            // 设置类型
            Trace.Write("warn ");

            // 设置时间
            Trace.Write($"({DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")})");

            // 设置消息
            Trace.Write(": " + message);

            // 设置来源
            if (source == null)
            { 
                Trace.Write($" 发生在: {source.ReflectedType.FullName}.{source.Name}");
            }

            // 设置附加数据
            if (!string.IsNullOrEmpty(extraData))
            {
                Trace.WriteLine("");
                Trace.Write(extraData);
            }

            Trace.WriteLine("");
        }

        /// <summary>
        /// 写错误日志
        /// </summary>
        /// <param name="exception">异常</param>
        /// <param name="source">来源</param>
        /// <param name="extraData">附加数据</param>
        public static void Error(Exception exception, MethodBase source = null, string extraData = "")
        {
            // 设置类型
            Trace.Write("error");

            // 设置时间
            Trace.Write($"({DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")})");

            // 设置消息
            Trace.Write($": {exception.Message}");

            // 设置来源
            if (source == null)
            {
                Trace.Write($" 发生在: {exception.Source}");
            }
            else
            {
                Trace.Write($" 发生在: {source.ReflectedType.FullName}.{source.Name}");
            }

            // 设置详情
            if (!string.IsNullOrEmpty(exception.StackTrace))
            {
                Trace.WriteLine("");
                Trace.Write(exception.StackTrace);
            }

            // 设置附加数据
            if (!string.IsNullOrEmpty(extraData))
            {
                Trace.WriteLine("");
                Trace.Write(extraData);
            }

            Trace.WriteLine("");
        }

        /// <summary>
        /// 写错误日志
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="source">来源</param>
        /// <param name="extraData">附加数据</param>
        public static void Error(string message, MethodBase source = null, string extraData = "")
        {
            // 设置类型
            Trace.Write("error");

            // 设置时间
            Trace.Write($"({DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")})");

            // 设置消息
            Trace.Write($": {message}");

            // 设置来源
            if (source != null)
            {
                Trace.Write($" 发生在: {source.ReflectedType.FullName}.{source.Name}");
            }

            // 设置附加数据
            if (!string.IsNullOrEmpty(extraData))
            {
                Trace.WriteLine("");
                Trace.Write(extraData);
            }

            Trace.WriteLine("");
        }

        /// <summary>
        /// 写致命日志
        /// </summary>
        /// <param name="exception">异常</param>
        /// <param name="source">来源</param>
        /// <param name="extraData">附加数据</param>
        public static void Fatal(Exception exception, MethodBase source = null, string extraData = "")
        {
            // 设置类型
            Trace.Write("fatal");

            // 设置时间
            Trace.Write($"({DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")})");

            // 设置消息
            Trace.Write($": {exception.Message}");

            // 设置来源
            if (source == null)
            {
                Trace.Write($" 发生在: {exception.Source}");
            }
            else
            {
                Trace.Write($" 发生在: {source.ReflectedType.FullName}.{source.Name}");
            }

            // 设置详情
            if (!string.IsNullOrEmpty(exception.StackTrace))
            {
                Trace.WriteLine("");
                Trace.Write(exception.StackTrace);
            }

            // 设置附加数据
            if (!string.IsNullOrEmpty(extraData))
            {
                Trace.WriteLine("");
                Trace.Write(extraData);
            }

            Trace.WriteLine("");
        }

        /// <summary>
        /// 写致命日志
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="source">来源</param>
        /// <param name="extraData">附加数据</param>
        public static void Fatal(string message, MethodBase source = null, string extraData = "")
        {
            // 设置类型
            Trace.Write("fatal");

            // 设置时间
            Trace.Write($"({DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")})");

            // 设置消息
            Trace.Write(": " + message);

            // 设置来源
            if (source != null)
            {
                Trace.Write($" 发生在: {source.ReflectedType.FullName}.{source.Name}");
            }

            // 设置附加数据
            if (!string.IsNullOrEmpty(extraData))
            {
                Trace.WriteLine("");
                Trace.Write(extraData);
            }

            Trace.WriteLine("");
        }
    }
}
