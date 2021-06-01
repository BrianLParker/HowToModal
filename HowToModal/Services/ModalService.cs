using System;
using Microsoft.AspNetCore.Components;

namespace HowToModal.Services
{
    public class ModalService : IModalService
    {
        private readonly NavigationManager navigationManager;

        public ModalService(NavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
            this.navigationManager.LocationChanged += (sender, args) => CloseModal();
        }

        public bool IsOpen { get; private set; }

        public RenderFragment ModalFragment { get; private set; }

        public string BackgroundColour { get; set; }
        public int BlurPixels { get; set; }
        public bool AllowBackgroundClick { get; set; }

        public event Action<bool> IsOpenChanged;

        public void OpenModal(RenderFragment modalFragment, string background, int blurPixels, bool allowBackgroundClick)
        {
            ModalFragment = modalFragment;
            BackgroundColour = background;
            BlurPixels = blurPixels;
            AllowBackgroundClick = allowBackgroundClick;
            IsOpen = true;
            IsOpenChanged?.Invoke(IsOpen);
        }

        public void CloseModal()
        {
            if (IsOpen)
            {
                IsOpen = false;
                ModalFragment = null;
                IsOpenChanged?.Invoke(IsOpen);
            }
        }
    }
}
