using System.Collections.Generic;
using HowToModal.Services;
using Microsoft.AspNetCore.Components;

namespace HowToModal.Views.Components
{
    public partial class ModalCloseButton : ComponentBase
    {
        [Inject]
        IModalService ModalService { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> ButtonAttributes { get; set; }

        void CloseDialog() => ModalService.CloseModal();
    }
}