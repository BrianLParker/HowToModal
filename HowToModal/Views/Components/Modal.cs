// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

using Microsoft.AspNetCore.Components;

namespace HowToModal.Views.Components
{
    public class Modal : ModalBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        public override void ShowModal() => ModalService.OpenModal(ChildContent, Background, BlurPixels, AllowBackgroundClick);
    }
}
