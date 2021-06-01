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

        public void ShowModal() => ModalService.OpenModal(ChildContent);

        public void CloseModal() => ModalService.CloseModal();

    }
}
