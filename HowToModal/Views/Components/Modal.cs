// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

using HowToModal.Models;
using Microsoft.AspNetCore.Components;

namespace HowToModal.Views.Components
{
    public class Modal : ModalBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public EventCallback<ModalCloseState> OnClose { get; set; }

        internal override void EmitClose(ModalCloseState modalCloseState)
            => OnClose.InvokeAsync(modalCloseState);
        
        public override void ShowModal() => ModalService.OpenModal(this, ChildContent, Background, BlurPixels, AllowBackgroundClick);
    }
}
