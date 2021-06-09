// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

using HowToModal.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace HowToModal.Views.Components
{
    public class TemplateModal<TContent> : ModalBase
    {
        [Parameter]
        public RenderFragment<TContent> ChildContent { get; set; }

        [Parameter]
        public TContent Value { get; set; }

        [Parameter]
        public EventCallback<ModalResult<TContent>> OnClose { get; set; }

        public override void ShowModal()
        {
            ModalService.OpenModal((ModalBase)this, ChildContent(Value), Background, BlurPixels, AllowBackgroundClick);
        }
        public void ShowModal(TContent value)
        {
            this.Value = value;
            ModalService.OpenModal(this, ChildContent(value), Background, BlurPixels, AllowBackgroundClick);
        }

        internal override void EmitClose(ModalCloseState modalCloseState)
        {
            OnClose.InvokeAsync(new ModalResult<TContent> { CloseState = modalCloseState, Value = Value });
        }

    }
}
