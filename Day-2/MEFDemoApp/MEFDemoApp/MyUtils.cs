﻿using System;
using System.Collections.Generic;

namespace MEFDemoApp
{
    public static class MyUtils
    {
        public static void ForEach<T>(this IEnumerable<T> list, Action<T> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
        }
    }
}