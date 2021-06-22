// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

using BlazorModals.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorModals.Views.Components
{
    public class TemplateModal<TContent> : ModalBase
    {
        [Parameter]
        public RenderFragment<TContent> ChildContent { get; set; }

        public TContent Value { get; set; }

        [Parameter]
        public EventCallback<ModalResult<TContent>> OnClose { get; set; }

        public override void ShowModal() => ModalService.OpenModal(this, ChildContent(Value), Background, BlurPixels, AllowBackgroundClick);
        public void ShowModal(TContent value)
        {
            Value = value;
            ModalService.OpenModal(this, ChildContent(value), Background, BlurPixels, AllowBackgroundClick);
        }

        override internal void EmitClose(ModalCloseState modalCloseState) => OnClose.InvokeAsync(new ModalResult<TContent> { CloseState = modalCloseState, Value = Value });

    }
}
