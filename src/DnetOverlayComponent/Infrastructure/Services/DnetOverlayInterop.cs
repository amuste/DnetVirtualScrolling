﻿using System.Threading.Tasks;
using DnetOverlayComponent.Infrastructure.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace DnetOverlayComponent.Infrastructure.Services
{
    public class DnetOverlayInterop
    {

        private readonly IJSRuntime _jsRuntime;

        public DnetOverlayInterop(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public ValueTask<object> Focus(ElementReference element)
        {
            return _jsRuntime.InvokeAsync<object>("dnetoverlay.setFocus", element);
        }

        public ValueTask<object> AddKeyDownEventListener(ElementReference element)
        {
            return _jsRuntime.InvokeAsync<object>("dnetoverlay.addKeyDownEventListener", element);
        }

        public ValueTask<ViewportScrollPosition> GetViewportScrollPosition()
        {
            return _jsRuntime.InvokeAsync<ViewportScrollPosition>("dnetoverlay.getViewportScrollPosition");
        }

        public ValueTask<Size> GetViewportSize()
        {
            return _jsRuntime.InvokeAsync<Size>("dnetoverlay.getViewportSize");
        }

        public ValueTask<Size> GetViewportSizeNoScroll()
        {
            return _jsRuntime.InvokeAsync<Size>("dnetoverlay.getViewportSizeNoScroll");
        }

        public ValueTask<FlexibleConnectedPositionStrategyOrigin> GetBoundingClientRect(ElementReference element)
        {
            return _jsRuntime.InvokeAsync<FlexibleConnectedPositionStrategyOrigin>("dnetoverlay.getBoundingClientRect", element);
        }

        public ValueTask<FlexibleConnectedPositionStrategyOrigin> GetDocumentBoundingClientRect()
        {
            return _jsRuntime.InvokeAsync<FlexibleConnectedPositionStrategyOrigin>("dnetoverlay.getDocumentBoundingClientRect");
        }

        public ValueTask<int> GetDocumentClientHeight()
        {
            return _jsRuntime.InvokeAsync<int>("dnetoverlay.getDocumentClientHeight");
        }

        public ValueTask<int> GetDocumentClientWidth()
        {
            return _jsRuntime.InvokeAsync<int>("dnetoverlay.getDocumentClientWidth");
        }
    }
}
