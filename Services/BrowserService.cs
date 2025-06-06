﻿using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace FW.Client
{
    public class BrowserService
    {
        private readonly IJSRuntime _js;

        public BrowserService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task<BrowserDimension> GetDimensions()
        {
            return await _js.InvokeAsync<BrowserDimension>("getDimensions");
        }

        public void Log(string message)
        {
            _js.InvokeVoidAsync("console.log", message);
        }

    }
    public class BrowserDimension
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}