
using System;
using JetBrains.Annotations;
using Object = UnityEngine.Object;

namespace Radish.Logging2 {

/// <summary>
/// Interface for logging implementations.
/// </summary>
public interface ILogger
{
	public string Name { get; }

	#region Info

	void Info(string message);

	void Info(Object context, string message);

	[StringFormatMethod("format")]
	void Info<T1>(string format, T1 arg1);

	[StringFormatMethod("format")]
	void Info<T1>(Object context, string format, T1 arg1);

	[StringFormatMethod("format")]
	void Info<T1, T2>(string format, T1 arg1, T2 arg2);

	[StringFormatMethod("format")]
	void Info<T1, T2>(Object context, string format, T1 arg1, T2 arg2);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3>(Object context, string format, T1 arg1, T2 arg2, T3 arg3);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);

	[StringFormatMethod("format")]
	void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);

	#endregion

	#region Warning

	void Warn(string message);

	void Warn(Object context, string message);

	[StringFormatMethod("format")]
	void Warn<T1>(string format, T1 arg1);

	[StringFormatMethod("format")]
	void Warn<T1>(Object context, string format, T1 arg1);

	[StringFormatMethod("format")]
	void Warn<T1, T2>(string format, T1 arg1, T2 arg2);

	[StringFormatMethod("format")]
	void Warn<T1, T2>(Object context, string format, T1 arg1, T2 arg2);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3>(Object context, string format, T1 arg1, T2 arg2, T3 arg3);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);

	[StringFormatMethod("format")]
	void Warn<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);

	#endregion

	#region Error

	void Error(string message);

	void Error(Object context, string message);

	[StringFormatMethod("format")]
	void Error<T1>(string format, T1 arg1);

	[StringFormatMethod("format")]
	void Error<T1>(Object context, string format, T1 arg1);

	[StringFormatMethod("format")]
	void Error<T1, T2>(string format, T1 arg1, T2 arg2);

	[StringFormatMethod("format")]
	void Error<T1, T2>(Object context, string format, T1 arg1, T2 arg2);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3>(Object context, string format, T1 arg1, T2 arg2, T3 arg3);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);

	[StringFormatMethod("format")]
	void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Object context, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);

	#endregion

	#region Exception

	void Exception(Exception ex);

	void Exception(Object context, Exception ex);

	void Exception(Exception ex, string message);

	void Exception(Object context, Exception ex, string message);

	[StringFormatMethod("format")]
	void Exception<T1>(Exception ex, string format, T1 arg1);

	[StringFormatMethod("format")]
	void Exception<T1>(Object context, Exception ex, string format, T1 arg1);

	[StringFormatMethod("format")]
	void Exception<T1, T2>(Exception ex, string format, T1 arg1, T2 arg2);

	[StringFormatMethod("format")]
	void Exception<T1, T2>(Object context, Exception ex, string format, T1 arg1, T2 arg2);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);

	[StringFormatMethod("format")]
	void Exception<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Object context, Exception ex, string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);


	#endregion
}
}