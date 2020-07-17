﻿using System.Collections.Generic;
using DnetOverlayComponent.Infrastructure.Enums;

namespace DnetOverlayComponent.Infrastructure.Models
{
    public class ConnectedPosition
    {
        public int ConnectedPositionId { get; set; }

        public HorizontalConnectionPos OriginX { get; set; }

        public VerticalConnectionPos OriginY { get; set; }

        public HorizontalConnectionPos OverlayX { get; set; }

        public VerticalConnectionPos OverlayY { get; set; }

        public int Weight { get; set; }

        public double? OffsetX { get; set; }

        public double? OffsetY { get; set; }

        public List<string> PanelClass { get; set; }
    }
}
