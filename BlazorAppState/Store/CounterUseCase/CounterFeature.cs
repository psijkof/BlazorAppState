﻿using Fluxor;

namespace BlazorAppState.Store.CounterUseCase
{
    public class CounterFeature : Feature<CounterState>
    {
        public override string GetName() => "Counter";

        protected override CounterState GetInitialState() => new CounterState(clickCount: 0);
    }
}