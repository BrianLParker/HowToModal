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

        override protected void OnInitialized()
        {
            ModalService.IsOpenChanged += ModalService_IsOpenChanged;
            base.OnInitialized();
        }

        private void ModalService_IsOpenChanged(bool obj) => StateHasChanged();
    }
}