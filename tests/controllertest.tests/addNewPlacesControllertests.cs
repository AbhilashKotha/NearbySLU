//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NearbySluWeb;
//using Xunit;
//using AutoFixture;
//using Moq;
//using FluentAssertions;
//using Microsoft.AspNetCore.Mvc;
//using NearbySluWeb.Controllers;
//using NearbySluWeb.Models;

//namespace controllers
//{
//    public class AddNewPlacesControllertests
//    {
//        private readonly IFixture _fixture;

//        private readonly Mock<addNewPlaceContext> _serviceMock;

//        private readonly addNewPlacesController _test;

//        public AddNewPlacesControllertests()

//        {

//            _fixture = new Fixture();

//            _serviceMock = _fixture.Freeze<Mock<addNewPlaceContext>>();

//            _test = new addNewPlacesController(_serviceMock.Object);

//        }

//        [Fact]

//        public async Task GetPlaceDetails_ShouldReturnOkResponse_WhenDataFound()

//        {

//            //Arrange

//            var placeDetailsMock = _fixture.Create<IEnumerable<addNewPlace>>();

//            _serviceMock.Setup(x => x.PlaceDetails()).ReturnsAsync(placeDetailsMock);

//            //Act

//            var result = await _test.GetPlaceDetails().ConfigureAwait(false);

//            //Assert

//            //Assert.NotNull(result);

//            result.Should().NotBeNull();

//            result.Should().BeAssignableTo<ActionResult<IEnumerable<addNewPlace>>>();

//            result.Result.Should().BeAssignableTo<OkObjectResult>();

//            result.Result.As<OkObjectResult>().Value

//                  .Should()

//                  .NotBeNull()

//                  .And.BeOfType(placeDetailsMock.GetType());

//            _serviceMock.Verify(x => x.PlaceDetails(), Times.Once());

//        }

//        [Fact]

//        public async Task GetPlaceDetails_ShouldReturnNotFound_WhenDataNotFound()

//        {

//            //Arrange

//            List<addNewPlace> response = null;

//            _serviceMock.Setup(x => x.PlaceDetails()).ReturnsAsync(response);

//            //Act

//            var result = await _test.GetPlaceDetails().ConfigureAwait(false);

//            //Assert

//            //Assert.NotNull(result);

//            result.Should().NotBeNull();

//            result.Result.Should().BeAssignableTo<NotFoundResult>();

//            _serviceMock.Verify(x => x.PlaceDetails(), Times.Once());

//        }

//        [Fact]

//        public async Task GetaddNewPlace_ShouldReturnOkResponse_WhenValidInput()

//        {

//            //Arrange

//            var placeDetailsMock = _fixture.Create<IEnumerable<addNewPlace>>();

//            var id = _fixture.Create<int>();

//            _serviceMock.Setup(x => x.PlaceDetails().FindAsync(id)).ReturnsAsync(placeDetailsMock);

//            //Act

//            var result = await _test.GetaddNewPlace(id); //check this line

//            //Assert

//            //Assert.NotNull(result);

//            result.Should().NotBeNull();

//            result.Should().BeAssignableTo<ActionResult<addNewPlace>>();

//            result.Result.Should().BeAssignableTo<OkObjectResult>();

//            result.Result.As<OkObjectResult>().Value

//                  .Should()

//                  .NotBeNull()

//                  .And.BeOfType(placeDetailsMock.GetType());

//            _serviceMock.Verify(x => x.GetaddNewPlace(id), Times.Once());

//        }

//        [Fact]

//        public async Task GetaddNewPlace_ShouldReturnNotFound_WhenNoDataFound()

//        {

//            //Arrange

//            addNewPlace response = null;

//            var id = _fixture.Create<int>();

//            _serviceMock.Setup(x => x.PlaceDetails().FindAsync(id)).ReturnsAsync(response);

//            //Act

//            var result = await _test.GetaddNewPlace(id); //check this line

//            //Assert

//            //Assert.NotNull(result);

//            result.Should().NotBeNull();

//            result.Result.Should().BeAssignableTo<NotFoundResult>();

//            _serviceMock.Verify(x => x.GetaddNewPlace(id), Times.Once());

//        }

//        [Fact]

//        public async Task PostaddNewPlace_ShouldReturnOkResponse_WhenValidRequest()

//        {

//            //Arrange

//            var request = _fixture.Create<addNewPlace>();

//            var response = _fixture.Create<addNewPlace>();

//            _serviceMock.Setup(x => x.PlaceDetails.Add(request)).ReturnsAsync(response);

//            //Act

//            var result = await _test.PostaddNewPlace(request); //check this line

//            //Assert

//            result.Should().NotBeNull();

//            result.Should().BeAssignableTo<ActionResult<addNewPlace>>();

//            result.Result.Should().BeAssignableTo<CreatedAtActionResult>(); //check this

//            _serviceMock.Verify(x => x.PostaddNewPlace(response), Times.Never());

//        }

//        [Fact]

//        public async Task DeleteaddNewPlace_ShouldReturnNoContent_WhenRecordDeleted()

//        {

//            //Arrange

//            var id = _fixture.Create<int>();

//            _serviceMock.Setup(x => x.PlaceDetails().Remove(x.PlaceDetails().FindAsync(id))).ReturnsAsync(true);

//            //Act

//            var result = await _test.DeleteaddNewPlace(id); //check this line

//            //Assert

//            result.Should().NotBeNull();

//            result.Result.Should().BeAssignableTo<NoContentResult>(); //check this

//        }

//        [Fact]

//        public async Task PutaddNewPlace_ShouldReturnBadResponse_WhenInvalidInput()

//        {

//            //Arrange

//            int id = 0;

//            var request = _fixture.Create<addNewPlace>();

//            var response = _fixture.Create<addNewPlace>();

//            _serviceMock.Setup(x => x.Entry(request)).ReturnsAsync(false); // check this

//            //Act

//            var result = await _test.PutaddNewPlace(id, request); //check this line

//            //Assert

//            result.Should().NotBeNull();

//            result.Result.Should().BeAssignableTo<BadRequestResult>(); //check this

//            _serviceMock.Verify(x => x.PutaddNewPlace(id, request), Times.Never());

//        }
//    }
//    }
//}
