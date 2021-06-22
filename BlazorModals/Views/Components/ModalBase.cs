// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

using BlazorModals.Services;
using BlazorModals.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorModals.Views.Components
{
    public abstract class ModalBase : ComponentBase
    {
        [Inject]
        protected IModalService ModalService { get; set; }

        [Parameter]
        public string Background { get; set; } = "#00000077";

        [Parameter]
        public int BlurPixels { get; set; } = 5;

        [Parameter]
        public bool AllowBackgroundClick { get; set; } = true;

        internal abstract void EmitClose(ModalCloseState modalCloseState);


        public abstract void ShowModal();

        public void CloseModal(ModalCloseState modalCloseState) => ModalService.CloseModal(modalCloseState);

    }
}
