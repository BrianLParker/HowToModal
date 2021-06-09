// -------------------------------------------
// Copyright (c) 2021, Brian Parker
// Free to use just pay your knowledge forward
// -------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
