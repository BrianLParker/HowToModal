// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

using System;
using HowToModal.Models;
using HowToModal.Views.Components;
using Microsoft.AspNetCore.Components;

namespace HowToModal.Services
{
    public class ModalService : IModalService
    {
        private readonly NavigationManager navigationManager;
        private ModalBase modal;

        public ModalService(NavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
            this.navigationManager.LocationChanged += (sender, args) => CloseModal(ModalCloseState.Cancel);
        }

        public bool IsOpen { get; private set; }
        public RenderFragment ModalFragment { get; private set; }
        public bool AllowBackgroundClick { get; set; }
        public string BackgroundColour { get; set; }
        public int BlurPixels { get; set; }

        public event Action<bool> IsOpenChanged;

        public void OpenModal(
            ModalBase modal,
            RenderFragment modalFragment,
            string background,
            int blurPixels,
            bool allowBackgroundClick)
        {
            this.modal = modal;
            ModalFragment =  modalFragment;
            BackgroundColour = background;
            BlurPixels = blurPixels;
            AllowBackgroundClick = allowBackgroundClick;

            IsOpen = true;
            IsOpenChanged?.Invoke(IsOpen);
}

        public void CloseModal(ModalCloseState modalCloseState)
        {
            if (IsOpen)
            {
                IsOpen = false;
                ModalFragment = null;
                modal.EmitClose(modalCloseState);
                IsOpenChanged?.Invoke(IsOpen);
            }
        }
    }
}
