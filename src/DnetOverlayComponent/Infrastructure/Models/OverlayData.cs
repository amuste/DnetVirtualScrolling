﻿using Microsoft.AspNetCore.Components;

namespace DnetOverlayComponent.Infrastructure.Models
{
    public class OverlayData
    {
        public RenderFragment Content { get; set; }

        public OverlayConfig OverlayConfig { get; set; }
    }
}
