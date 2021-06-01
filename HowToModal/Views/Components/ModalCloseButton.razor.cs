// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

using System.Collections.Generic;
using HowToModal.Services;
using Microsoft.AspNetCore.Components;

namespace HowToModal.Views.Components
{
    public partial class ModalCloseButton : ComponentBase
    {
        [Inject]
        private IModalService ModalService { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> ButtonAttributes { get; set; }

        private void CloseDialog() => ModalService.CloseModal();
    }
}