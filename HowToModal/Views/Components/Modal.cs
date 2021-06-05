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

    public class TemplateModal<TContent> : ModalBase
    {
        [Parameter]
        public RenderFragment<TContent> ChildContent { get; set; }

        public TContent Value { get; set; }

        public override void ShowModal() => ModalService.OpenModal(ChildContent(Value), Background, BlurPixels, AllowBackgroundClick);

        public void ShowModal(TContent content) => ModalService.OpenModal(ChildContent(content), Background, BlurPixels, AllowBackgroundClick);
    }
}
