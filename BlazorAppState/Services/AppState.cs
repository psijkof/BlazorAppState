using System;

namespace BlazorAppState.Services
{
    public class AppState

    {
        public delegate void DelegateHandleStateChange(object source, string property);

        public event DelegateHandleStateChange OnStateChanged;

        private void NotifyStateChanged(object source, string property)
        {
            if (OnStateChanged != null)
            {
                OnStateChanged(source, property);
            }
        }

        public string MyProperty { get; private set; } = $"initialized on {DateTime.Now} by {nameof(AppState)}";

        public int MyProperty2 { get; private set; } = 100;

        public void UpdateMyProperty(object source, string value)
        {
            MyProperty = value;
            NotifyStateChanged(source, property: nameof(MyProperty));
        }

        public void UpdateMyProperty2(object source, int value)
        {
            MyProperty2 = value;
            NotifyStateChanged(source, property: nameof(MyProperty2));
        }
    }
}