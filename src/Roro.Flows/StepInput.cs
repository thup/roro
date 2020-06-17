﻿using Roro.Flows.Framework;
using System.Text.Json;

namespace Roro.Flows
{
    public sealed class StepInput : NameTypeValue<Step, StepInputCollection, StepInput>
    {
        internal StepInput(Step parent) : base(parent)
        {
        }

        internal StepInput(Step parent, JsonElement jsonElement) : base(parent, jsonElement)
        {
        }

        public override bool NameIsReadOnly => false;

        public override bool TypeIsReadOnly => false;

        public override bool ValueIsReadOnly => false;
    }
}
