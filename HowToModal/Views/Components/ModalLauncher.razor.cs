using HowToModal.Services;
using Microsoft.AspNetCore.Components;

namespace HowToModal.Views.Components
{
    public partial class ModalLauncher : ComponentBase
    {
        [Inject]
        private IModalService ModalService { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        void OnBackgroundClicked()
        {
            if(ModalService.AllowBackgroundClick)
            {
                ModalService.CloseModal();
            }
        }

        protected override void OnInitialized()
        {
            ModalService.IsOpenChanged += (changed) => StateHasChanged();
            base.OnInitialized();
        }
    }
}