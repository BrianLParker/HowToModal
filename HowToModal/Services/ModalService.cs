using System;
using Microsoft.AspNetCore.Components;

namespace HowToModal.Services
{
    public class ModalService : IModalService
    {
        public bool IsOpen { get; private set; }
        public RenderFragment ModalFragment { get; private set; }
        public string ModalColour { get; private set; }

        public event Action<bool> IsOpenChanged;

        public void OpenModal(RenderFragment modalFragment)
        {
            IsOpen = true;
            ModalFragment = modalFragment;
            IsOpenChanged?.Invoke(IsOpen);
        }

        public void CloseModal()
        {
            IsOpen = false;
            ModalFragment = null;
            IsOpenChanged?.Invoke(IsOpen);
        }

        public void Refresh() => IsOpenChanged?.Invoke(IsOpen);
    }
}
