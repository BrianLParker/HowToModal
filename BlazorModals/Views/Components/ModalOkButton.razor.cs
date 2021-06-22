// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

using System.Collections.Generic;
using BlazorModals.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorModals.Views.Components
{
    public partial class ModalOkButton : ComponentBase
    {
        [Inject]
        private IModalService ModalService { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> ButtonAttributes { get; set; }

        private void CloseDialog() => ModalService.CloseModal(modalCloseState: Models.ModalCloseState.Ok);
    }
}