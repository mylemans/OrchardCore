﻿using Microsoft.Dnx.Runtime;
using OrchardVNext.Abstractions.Localization;

namespace OrchardVNext.Environment {
    public class DefaultHostEnvironment : HostEnvironment {
        public DefaultHostEnvironment(
            IApplicationEnvironment applicationEnvironment) : base(applicationEnvironment) {
            T = NullLocalizer.Instance;
        }

        public Localizer T { get; set; }
    }
}