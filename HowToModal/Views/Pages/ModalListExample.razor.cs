// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using BlazorModals.Models;
using BlazorModals.Views.Components;
using HowToModal.Models;

namespace HowToModal.Views.Pages
{
    public partial class ModalListExample
    {
        private TemplateModal<SomeDataModel> modal;
        private SomeDataModel currentModel;
        private IEnumerable<SomeDataModel> someData;

        protected override void OnInitialized() => this.someData = Enumerable.Range(1, 20).Select(i => new SomeDataModel
        {
            Id = i,
            Name = $"Name {i}",
            DateOfBirth = DateTimeOffset.Now - TimeSpan.FromDays(i * 25)
        }).ToList();

        private void OpenModal(SomeDataModel data)
        {
            this.currentModel = data;
            SomeDataModel temp = new SomeDataModel();
            CopyModel(data, temp);
            this.modal.ShowModal(temp);
        }

        private void ModalClosed(ModalResult<SomeDataModel> modalResult)
        {
            if (modalResult.CloseState == ModalCloseState.Ok)
            {
                CopyModel(modalResult.Value, this.currentModel);
                StateHasChanged();
            }

        }

        private void CopyModel(SomeDataModel source, SomeDataModel dest)
        {
            dest.Id = source.Id;
            dest.Name = source.Name;
            dest.DateOfBirth = source.DateOfBirth;
            dest.Email = source.Email;
        }
    }
}