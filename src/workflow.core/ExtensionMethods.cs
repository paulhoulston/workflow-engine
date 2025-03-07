using System;
using System.Collections.Generic;

namespace Workflow.Core;

static class ExtensionMethods
{
    public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
    {
        foreach (var item in items)
        {
            action(item);
        }
    }
}