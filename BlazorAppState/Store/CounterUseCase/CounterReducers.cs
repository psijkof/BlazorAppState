using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppState.Store.CounterUseCase
{
    public static class CounterReducers
    {
        [ReducerMethod]
        public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action)
            => new(clickCount: state.ClickCount + 1);
    }
}
