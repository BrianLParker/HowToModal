using System;
using Microsoft.AspNetCore.Components;

namespace HowToModal.Services
{
    public interface IModalService
    {
        bool IsOpen { get; }
        RenderFragment ModalFragment { get; }
        string BackgroundColour { get; set; }
        int BlurPixels { get; set; }
        bool AllowBackgroundClick { get; set; }

        event Action<bool> IsOpenChanged;
        void OpenModal(RenderFragment modalFragment, string background, int blurPixels, bool allowBackgroundClick);
        void CloseModal();
    }
}
