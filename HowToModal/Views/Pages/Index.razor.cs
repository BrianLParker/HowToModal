// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

using System;
using BlazorModals.Models;
using BlazorModals.Views.Components;
using Microsoft.AspNetCore.Components;

namespace HowToModal.Views.Pages
{
    public partial class Index : ComponentBase
    {
        private Modal modal1;
        private Modal modal2;
        private Modal modal3;
        private void Modal1Closed(ModalCloseState modalCloseState) => Console.WriteLine($"ModalCloseState : {modalCloseState}");
    }
}