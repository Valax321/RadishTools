
#if ZSTRING_AVAILABLE
using System;
using Cysharp.Text;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Radish.Logging
{
	internal sealed class RadishLogger : ILogger
	{
		public string Name { get; }

		internal RadishLogger(string name)
		{
			Name = name;
		}

		#region Static Write Methods

		[HideInCallstack]
		private static void Write(LogLevel level, Object context, string category, string message)
		{
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, message.AsSpan());
			}
		}

		[HideInCallstack]
		private static void WriteException(LogLevel level, Object context, string category, Exception ex)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException(LogLevel level, Object context, string category, Exception ex, string message)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.Append(message);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			[HideInCallstack]
		private static void Write<T1>(LogLevel level, Object context, string category, string format, T1 arg1)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException<T1>(LogLevel level, Object context, string category, Exception ex, string format, T1 arg1)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			[HideInCallstack]
		private static void Write<T1, T2>(LogLevel level, Object context, string category, string format, T1 arg1, T2 arg2)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException<T1, T2>(LogLevel level, Object context, string category, Exception ex, string format, T1 arg1, T2 arg2)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			[HideInCallstack]
		private static void Write<T1, T2, T3>(LogLevel level, Object context, string category, string format, T1 arg1, T2 arg2, T3 arg3)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException<T1, T2, T3>(LogLevel level, Object context, string category, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			[HideInCallstack]
		private static void Write<T1, T2, T3, T4>(LogLevel level, Object context, string category, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException<T1, T2, T3, T4>(LogLevel level, Object context, string category, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			[HideInCallstack]
		private static void Write<T1, T2, T3, T4, T5>(LogLevel level, Object context, string category, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException<T1, T2, T3, T4, T5>(LogLevel level, Object context, string category, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			[HideInCallstack]
		private static void Write<T1, T2, T3, T4, T5, T6>(LogLevel level, Object context, string category, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException<T1, T2, T3, T4, T5, T6>(LogLevel level, Object context, string category, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			[HideInCallstack]
		private static void Write<T1, T2, T3, T4, T5, T6, T7>(LogLevel level, Object context, string category, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException<T1, T2, T3, T4, T5, T6, T7>(LogLevel level, Object context, string category, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			[HideInCallstack]
		private static void Write<T1, T2, T3, T4, T5, T6, T7, T8>(LogLevel level, Object context, string category, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException<T1, T2, T3, T4, T5, T6, T7, T8>(LogLevel level, Object context, string category, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			[HideInCallstack]
		private static void Write<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LogLevel level, Object context, string category, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LogLevel level, Object context, string category, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			[HideInCallstack]
		private static void Write<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LogLevel level, Object context, string category, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LogLevel level, Object context, string category, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			[HideInCallstack]
		private static void Write<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LogLevel level, Object context, string category, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LogLevel level, Object context, string category, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			[HideInCallstack]
		private static void Write<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LogLevel level, Object context, string category, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LogLevel level, Object context, string category, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			[HideInCallstack]
		private static void Write<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LogLevel level, Object context, string category, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LogLevel level, Object context, string category, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			[HideInCallstack]
		private static void Write<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LogLevel level, Object context, string category, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LogLevel level, Object context, string category, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			[HideInCallstack]
		private static void Write<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(LogLevel level, Object context, string category, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(LogLevel level, Object context, string category, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			[HideInCallstack]
		private static void Write<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(LogLevel level, Object context, string category, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

		[HideInCallstack]
		private static void WriteException<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(LogLevel level, Object context, string category, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
		{
			using var fmt = ZString.CreateStringBuilder();
			fmt.AppendFormat(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
			fmt.Append(' ');
			fmt.Append(ex);
			var span = fmt.AsSpan();
			foreach (var writer in LogManager.registeredLoggers)
			{
				writer.Write(level, context, category, span);
			}
		}

			#endregion

		#region Info (Interface)

		[HideInCallstack]
		public void Info(string message)
			=> Write(LogLevel.Info, null, Name, message);

		[HideInCallstack]
		public void Info(Object context, string message)
			=> Write(LogLevel.Info, context, Name, message);

			[HideInCallstack]
		public void Info<T1>(string format, T1 arg1) 
			=> Write(LogLevel.Info, null, Name, format, arg1);

		[HideInCallstack]
		public void Info<T1>(Object context, string format, T1 arg1) 
			=> Write(LogLevel.Info, context, Name, format, arg1);

			[HideInCallstack]
		public void Info<T1, T2>(string format, T1 arg1, T2 arg2) 
			=> Write(LogLevel.Info, null, Name, format, arg1, arg2);

		[HideInCallstack]
		public void Info<T1, T2>(Object context, string format, T1 arg1, T2 arg2) 
			=> Write(LogLevel.Info, context, Name, format, arg1, arg2);

			[HideInCallstack]
		public void Info<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) 
			=> Write(LogLevel.Info, null, Name, format, arg1, arg2, arg3);

		[HideInCallstack]
		public void Info<T1, T2, T3>(Object context, string format, T1 arg1, T2 arg2, T3 arg3) 
			=> Write(LogLevel.Info, context, Name, format, arg1, arg2, arg3);

			[HideInCallstack]
		public void Info<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) 
			=> Write(LogLevel.Info, null, Name, format, arg1, arg2, arg3, arg4);

		[HideInCallstack]
		public void Info<T1, T2, T3, T4>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) 
			=> Write(LogLevel.Info, context, Name, format, arg1, arg2, arg3, arg4);

			[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) 
			=> Write(LogLevel.Info, null, Name, format, arg1, arg2, arg3, arg4, arg5);

		[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) 
			=> Write(LogLevel.Info, context, Name, format, arg1, arg2, arg3, arg4, arg5);

			[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) 
			=> Write(LogLevel.Info, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6);

		[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) 
			=> Write(LogLevel.Info, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6);

			[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) 
			=> Write(LogLevel.Info, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

		[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) 
			=> Write(LogLevel.Info, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

			[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) 
			=> Write(LogLevel.Info, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

		[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) 
			=> Write(LogLevel.Info, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

			[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) 
			=> Write(LogLevel.Info, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

		[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) 
			=> Write(LogLevel.Info, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

			[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) 
			=> Write(LogLevel.Info, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

		[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) 
			=> Write(LogLevel.Info, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

			[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) 
			=> Write(LogLevel.Info, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

		[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) 
			=> Write(LogLevel.Info, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

			[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) 
			=> Write(LogLevel.Info, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

		[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) 
			=> Write(LogLevel.Info, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

			[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) 
			=> Write(LogLevel.Info, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

		[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) 
			=> Write(LogLevel.Info, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

			[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) 
			=> Write(LogLevel.Info, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

		[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) 
			=> Write(LogLevel.Info, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

			[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) 
			=> Write(LogLevel.Info, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

		[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) 
			=> Write(LogLevel.Info, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

			[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) 
			=> Write(LogLevel.Info, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

		[HideInCallstack]
		public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) 
			=> Write(LogLevel.Info, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

			#endregion

		#region Warning (Interface)

		[HideInCallstack]
		public void Warn(string message)
			=> Write(LogLevel.Warning, null, Name, message);

		[HideInCallstack]
		public void Warn(Object context, string message)
			=> Write(LogLevel.Warning, null, Name, message);

			[HideInCallstack]
		public void Warn<T1>(string format, T1 arg1) 
			=> Write(LogLevel.Warning, null, Name, format, arg1);

		[HideInCallstack]
		public void Warn<T1>(Object context, string format, T1 arg1) 
			=> Write(LogLevel.Warning, context, Name, format, arg1);

			[HideInCallstack]
		public void Warn<T1, T2>(string format, T1 arg1, T2 arg2) 
			=> Write(LogLevel.Warning, null, Name, format, arg1, arg2);

		[HideInCallstack]
		public void Warn<T1, T2>(Object context, string format, T1 arg1, T2 arg2) 
			=> Write(LogLevel.Warning, context, Name, format, arg1, arg2);

			[HideInCallstack]
		public void Warn<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) 
			=> Write(LogLevel.Warning, null, Name, format, arg1, arg2, arg3);

		[HideInCallstack]
		public void Warn<T1, T2, T3>(Object context, string format, T1 arg1, T2 arg2, T3 arg3) 
			=> Write(LogLevel.Warning, context, Name, format, arg1, arg2, arg3);

			[HideInCallstack]
		public void Warn<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) 
			=> Write(LogLevel.Warning, null, Name, format, arg1, arg2, arg3, arg4);

		[HideInCallstack]
		public void Warn<T1, T2, T3, T4>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) 
			=> Write(LogLevel.Warning, context, Name, format, arg1, arg2, arg3, arg4);

			[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) 
			=> Write(LogLevel.Warning, null, Name, format, arg1, arg2, arg3, arg4, arg5);

		[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) 
			=> Write(LogLevel.Warning, context, Name, format, arg1, arg2, arg3, arg4, arg5);

			[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) 
			=> Write(LogLevel.Warning, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6);

		[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) 
			=> Write(LogLevel.Warning, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6);

			[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) 
			=> Write(LogLevel.Warning, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

		[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) 
			=> Write(LogLevel.Warning, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

			[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) 
			=> Write(LogLevel.Warning, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

		[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) 
			=> Write(LogLevel.Warning, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

			[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) 
			=> Write(LogLevel.Warning, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

		[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) 
			=> Write(LogLevel.Warning, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

			[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) 
			=> Write(LogLevel.Warning, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

		[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) 
			=> Write(LogLevel.Warning, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

			[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) 
			=> Write(LogLevel.Warning, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

		[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) 
			=> Write(LogLevel.Warning, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

			[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) 
			=> Write(LogLevel.Warning, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

		[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) 
			=> Write(LogLevel.Warning, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

			[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) 
			=> Write(LogLevel.Warning, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

		[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) 
			=> Write(LogLevel.Warning, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

			[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) 
			=> Write(LogLevel.Warning, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

		[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) 
			=> Write(LogLevel.Warning, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

			[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) 
			=> Write(LogLevel.Warning, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

		[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) 
			=> Write(LogLevel.Warning, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

			[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) 
			=> Write(LogLevel.Warning, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

		[HideInCallstack]
		public void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) 
			=> Write(LogLevel.Warning, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

			#endregion

		#region Error (Interface)

		[HideInCallstack]
		public void Error(string message)
			=> Write(LogLevel.Error, null, Name, message);

		[HideInCallstack]
		public void Error(Object context, string message)
			=> Write(LogLevel.Error, context, Name, message);

			[HideInCallstack]
		public void Error<T1>(string format, T1 arg1) 
			=> Write(LogLevel.Error, null, Name, format, arg1);

		[HideInCallstack]
		public void Error<T1>(Object context, string format, T1 arg1) 
			=> Write(LogLevel.Error, context, Name, format, arg1);

			[HideInCallstack]
		public void Error<T1, T2>(string format, T1 arg1, T2 arg2) 
			=> Write(LogLevel.Error, null, Name, format, arg1, arg2);

		[HideInCallstack]
		public void Error<T1, T2>(Object context, string format, T1 arg1, T2 arg2) 
			=> Write(LogLevel.Error, context, Name, format, arg1, arg2);

			[HideInCallstack]
		public void Error<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) 
			=> Write(LogLevel.Error, null, Name, format, arg1, arg2, arg3);

		[HideInCallstack]
		public void Error<T1, T2, T3>(Object context, string format, T1 arg1, T2 arg2, T3 arg3) 
			=> Write(LogLevel.Error, context, Name, format, arg1, arg2, arg3);

			[HideInCallstack]
		public void Error<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) 
			=> Write(LogLevel.Error, null, Name, format, arg1, arg2, arg3, arg4);

		[HideInCallstack]
		public void Error<T1, T2, T3, T4>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) 
			=> Write(LogLevel.Error, context, Name, format, arg1, arg2, arg3, arg4);

			[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) 
			=> Write(LogLevel.Error, null, Name, format, arg1, arg2, arg3, arg4, arg5);

		[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) 
			=> Write(LogLevel.Error, context, Name, format, arg1, arg2, arg3, arg4, arg5);

			[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) 
			=> Write(LogLevel.Error, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6);

		[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) 
			=> Write(LogLevel.Error, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6);

			[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) 
			=> Write(LogLevel.Error, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

		[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) 
			=> Write(LogLevel.Error, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

			[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) 
			=> Write(LogLevel.Error, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

		[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) 
			=> Write(LogLevel.Error, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

			[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) 
			=> Write(LogLevel.Error, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

		[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) 
			=> Write(LogLevel.Error, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

			[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) 
			=> Write(LogLevel.Error, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

		[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) 
			=> Write(LogLevel.Error, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

			[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) 
			=> Write(LogLevel.Error, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

		[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) 
			=> Write(LogLevel.Error, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

			[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) 
			=> Write(LogLevel.Error, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

		[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) 
			=> Write(LogLevel.Error, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

			[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) 
			=> Write(LogLevel.Error, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

		[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) 
			=> Write(LogLevel.Error, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

			[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) 
			=> Write(LogLevel.Error, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

		[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) 
			=> Write(LogLevel.Error, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

			[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) 
			=> Write(LogLevel.Error, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

		[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) 
			=> Write(LogLevel.Error, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

			[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) 
			=> Write(LogLevel.Error, null, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

		[HideInCallstack]
		public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) 
			=> Write(LogLevel.Error, context, Name, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

			#endregion

		#region Warning (Exception)

		[HideInCallstack]
		public void Exception(Exception ex)
			=> WriteException(LogLevel.Exception, null, Name, ex);

		[HideInCallstack]
		public void Exception(Object context, Exception ex)
			=> WriteException(LogLevel.Exception, context, Name, ex);

		[HideInCallstack]
		public void Exception(Exception ex, string message)
			=> WriteException(LogLevel.Exception, null, Name, ex, message);

		[HideInCallstack]
		public void Exception(Object context, Exception ex, string message)
			=> WriteException(LogLevel.Exception, context, Name, ex, message);

			[HideInCallstack]
		public void Exception<T1>(Exception ex, string format, T1 arg1) 
			=> WriteException(LogLevel.Exception, null, Name, ex, format, arg1);

		[HideInCallstack]
		public void Exception<T1>(Object context, Exception ex, string format, T1 arg1) 
			=> WriteException(LogLevel.Exception, context, Name, ex, format, arg1);

			[HideInCallstack]
		public void Exception<T1, T2>(Exception ex, string format, T1 arg1, T2 arg2) 
			=> WriteException(LogLevel.Exception, null, Name, ex, format, arg1, arg2);

		[HideInCallstack]
		public void Exception<T1, T2>(Object context, Exception ex, string format, T1 arg1, T2 arg2) 
			=> WriteException(LogLevel.Exception, context, Name, ex, format, arg1, arg2);

			[HideInCallstack]
		public void Exception<T1, T2, T3>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3) 
			=> WriteException(LogLevel.Exception, null, Name, ex, format, arg1, arg2, arg3);

		[HideInCallstack]
		public void Exception<T1, T2, T3>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3) 
			=> WriteException(LogLevel.Exception, context, Name, ex, format, arg1, arg2, arg3);

			[HideInCallstack]
		public void Exception<T1, T2, T3, T4>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) 
			=> WriteException(LogLevel.Exception, null, Name, ex, format, arg1, arg2, arg3, arg4);

		[HideInCallstack]
		public void Exception<T1, T2, T3, T4>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) 
			=> WriteException(LogLevel.Exception, context, Name, ex, format, arg1, arg2, arg3, arg4);

			[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) 
			=> WriteException(LogLevel.Exception, null, Name, ex, format, arg1, arg2, arg3, arg4, arg5);

		[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) 
			=> WriteException(LogLevel.Exception, context, Name, ex, format, arg1, arg2, arg3, arg4, arg5);

			[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) 
			=> WriteException(LogLevel.Exception, null, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6);

		[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) 
			=> WriteException(LogLevel.Exception, context, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6);

			[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) 
			=> WriteException(LogLevel.Exception, null, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

		[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) 
			=> WriteException(LogLevel.Exception, context, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

			[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) 
			=> WriteException(LogLevel.Exception, null, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

		[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) 
			=> WriteException(LogLevel.Exception, context, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

			[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) 
			=> WriteException(LogLevel.Exception, null, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

		[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) 
			=> WriteException(LogLevel.Exception, context, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

			[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) 
			=> WriteException(LogLevel.Exception, null, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

		[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) 
			=> WriteException(LogLevel.Exception, context, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

			[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) 
			=> WriteException(LogLevel.Exception, null, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

		[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) 
			=> WriteException(LogLevel.Exception, context, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

			[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) 
			=> WriteException(LogLevel.Exception, null, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

		[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) 
			=> WriteException(LogLevel.Exception, context, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

			[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) 
			=> WriteException(LogLevel.Exception, null, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

		[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) 
			=> WriteException(LogLevel.Exception, context, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

			[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) 
			=> WriteException(LogLevel.Exception, null, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

		[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) 
			=> WriteException(LogLevel.Exception, context, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

			[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) 
			=> WriteException(LogLevel.Exception, null, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

		[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) 
			=> WriteException(LogLevel.Exception, context, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

			[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) 
			=> WriteException(LogLevel.Exception, null, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

		[HideInCallstack]
		public void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) 
			=> WriteException(LogLevel.Exception, context, Name, ex, format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

			#endregion
	}
}
#endif