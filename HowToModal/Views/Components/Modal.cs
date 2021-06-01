using HowToModal.Services;
using Microsoft.AspNetCore.Components;

namespace HowToModal.Views.Components
{
    public class Modal : ComponentBase
    {
        [Inject]
        private IModalService ModalService { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string Background { get; set; } = "#00000077";

        [Parameter]
        public int BlurPixels { get; set; } = 5;

        [Parameter]
        public bool AllowBackgroundClick { get; set; } = true;

        public void ShowModal() => ModalService.OpenModal(ChildContent, Background, BlurPixels, AllowBackgroundClick);

        public void CloseModal() => ModalService.CloseModal();

    }
}
