// ListAggregator.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Runtime.CompilerServices;

namespace System.Collections.Generic {

    [IgnoreNamespace]
    [Imported]
    public delegate TAccumulated ListAggregator<TAccumulated, TValue>(TAccumulated aggregatedValue, TValue value, int index, IReadonlyCollection<TValue> list);
}
