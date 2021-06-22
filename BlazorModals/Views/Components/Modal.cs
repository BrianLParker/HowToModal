// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

using BlazorModals.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorModals.Views.Components
{
    public class Modal : ModalBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public EventCallback<ModalCloseState> OnClose { get; set; }

        override internal void EmitClose(ModalCloseState modalCloseState)
            => OnClose.InvokeAsync(modalCloseState);

        public override void ShowModal() => ModalService.OpenModal(this, ChildContent, Background, BlurPixels, AllowBackgroundClick);
    }
}
