// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

using BlazorModals.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorModals.Views.Components
{
    public partial class ModalLauncher : ComponentBase
    {
        [Inject]
        private IModalService ModalService { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        private string ChildContentCss => ModalService.IsOpen ? "modal-child-content" : "";

        private void OnBackgroundClicked()
        {
            if (ModalService.AllowBackgroundClick)
            {
                ModalService.CloseModal(modalCloseState: Models.ModalCloseState.Cancel);
            }
        }

        protected override void OnInitialized()
            => ModalService.IsOpenChanged += (changed) => StateHasChanged();
    }
}