// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

using System;
using HowToModal.Models;
using HowToModal.Views.Components;
using Microsoft.AspNetCore.Components;

namespace HowToModal.Views.Pages
{
    public partial class Index : ComponentBase
    {
        private Modal modal1;
        private Modal modal2;
        private Modal modal3;
        private TemplateModal<SomeDataModel> modal4;

        private SomeDataModel someData1 = new SomeDataModel { Name = "Brian" };
        private SomeDataModel someData2 = new SomeDataModel { Name = "Brian Parker" };

        private void Modal1Closed(ModalCloseState modalCloseState) => Console.WriteLine($"ModalCloseState : {modalCloseState}");

        private void Modal4Closed(ModalResult<SomeDataModel> modalResult) => Console.WriteLine($"ModalCloseState : {modalResult.CloseState} Value: {modalResult.Value.Name}");
    }
}