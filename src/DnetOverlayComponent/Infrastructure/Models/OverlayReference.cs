﻿using System;
using DnetOverlayComponent.Infrastructure.Services;

namespace DnetOverlayComponent.Infrastructure.Models
{
    public class OverlayReference
    {
        public event Action<OverlayResult> Close;

        internal int OverlayReferenceId { get; set; }

        public OverlayReference(int overlayReferenceId)
        {
            OverlayReferenceId = overlayReferenceId;
        }

        internal void CloseOverlayReference(OverlayResult overlayDataResult)
        {
            Close?.Invoke(overlayDataResult);
        }

        public int GetOverlayReferenceId()
        {
            return OverlayReferenceId;
        }
    }
}
