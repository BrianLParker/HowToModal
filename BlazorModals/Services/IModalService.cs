// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

using System;
using BlazorModals.Models;
using BlazorModals.Views.Components;
using Microsoft.AspNetCore.Components;

namespace BlazorModals.Services
{
    public interface IModalService
    {
        bool IsOpen { get; }
        RenderFragment ModalFragment { get; }
        string BackgroundColour { get; set; }
        int BlurPixels { get; set; }
        bool AllowBackgroundClick { get; set; }

        event Action<bool> IsOpenChanged;
        void OpenModal(ModalBase modal, RenderFragment modalFragment, string background, int blurPixels, bool allowBackgroundClick);
        void CloseModal(ModalCloseState modalCloseState);
    }
}
