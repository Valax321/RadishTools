# ScopedAsyncOperation

ScopedAsyncOperation is an implementation of a scriptable version of Unity's builtin AsyncOperation for opaque async function calls.

`ScopedAsyncOperation.Create()` creates both the operation itself, which should be returned to the caller to await. It also returns a completion token that can be invoked when an asynchronous operation completes, notifying the operation that it has finished.

A version with a generic return value is also available to return a value to the awaitee.

ScopedAsyncOperations can be both `yield`ed (Unity coroutine style) or awaited using UniTask.

Usage:
```csharp
using Radish;

// Create an operation and completion token.
var operation = ScopedAsyncOperation.Create(out var token);
myStoredToken = token;
return operation;

// Then, somewhere else when the operation logic is completed...

// Let the code awaiting completion run.
myStoredToken.Complete();

// or for the generic version (using ScopedAsyncToken<T>):
myStoredToken.Complete(completionValue);
```