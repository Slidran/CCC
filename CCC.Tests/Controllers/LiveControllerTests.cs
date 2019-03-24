using CCC.Live.Controllers;
using CCC.Live.Interfaces;
using CCC.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using CCC.Live.Models;

namespace CCC.Tests.Controllers
{
    public class LiveControllerTests
    {
        LiveController _controller;
        ILiveService _services;

        public LiveControllerTests()
        {
            _services = new LiveServiceMock();
            _controller = new LiveController(_services);
        }

        [Fact]
        public async void Get_Live_Currencies_Data()
        {
            var okResult = await _controller.Get();
            
            Assert.IsType<CurrencyQuotesModel>(okResult.Value);
        }
    }
}
