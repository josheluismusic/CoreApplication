using System;

namespace CoreApplication.Infrastructure.Interfaces
{
    public interface ITabInfoProvider
    {
        string TabHeader { get; }
        bool ShowCloseButton { get; }
        void ConfirmCloseTabRequest(Action<bool> confirmationCallback);
    }
}
