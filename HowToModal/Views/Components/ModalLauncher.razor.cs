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

        protected override void OnInitialized()
        {
            ModalService.IsOpenChanged += (changed) => StateHasChanged();
            base.OnInitialized();
        }
    }
}