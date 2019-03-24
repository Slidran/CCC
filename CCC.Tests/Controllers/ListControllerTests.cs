using CCC.List.Controllers;
using CCC.List.Interfaces;
using CCC.List.Models;
using CCC.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CCC.Tests.Controllers
{
    public class ListControllerTests
    {
        ListController _controller;
        IListService _services;

        public ListControllerTests()
        {
            _services = new ListServiceMock();
            _controller = new ListController(_services);
        }

        [Fact]
        public async void Get_Live_Currencies_Data()
        {
            var okResult = await _controller.Get();

            Assert.IsType<CurrencyListModel>(okResult.Value);
        }
    }
}
