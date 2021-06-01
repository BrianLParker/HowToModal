using Microsoft.AspNetCore.Components;
using System;

namespace HowToModal.Services
{
    public interface IModalService
    {
        bool IsOpen { get; }
        RenderFragment ModalFragment { get; }
        string ModalColour { get; }
        event Action<bool> IsOpenChanged;
        void OpenModal(RenderFragment modalFragment);
        void CloseModal();
        void Refresh();
    }
}
