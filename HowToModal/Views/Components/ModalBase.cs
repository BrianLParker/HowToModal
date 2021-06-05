// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

using HowToModal.Services;
using Microsoft.AspNetCore.Components;

namespace HowToModal.Views.Components
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

        public abstract void ShowModal();

        public void CloseModal() => ModalService.CloseModal();

    }
}
