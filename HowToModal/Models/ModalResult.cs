// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

namespace HowToModal.Models
{
    public class ModalResult<TContent>
    {
        public TContent Value { get; set; }

        public ModalCloseState CloseState { get; set; }
    }

    public enum ModalCloseState
    {
        Cancel,
        Close,
        Ok
    }
}
