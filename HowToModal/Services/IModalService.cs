using System;
using Microsoft.AspNetCore.Components;

namespace HowToModal.Services
{
    public interface IModalService
    {
        bool IsOpen { get; }
        RenderFragment ModalFragment { get; }
        event Action<bool> IsOpenChanged;
        void OpenModal(RenderFragment modalFragment);
        void CloseModal();
    }
}
