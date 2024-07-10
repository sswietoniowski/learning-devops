using System.Net;
using FluentAssertions;

namespace DockerCourseApi.Tests;

public class ApiTests
{
    [Fact]
    public async Task GivenGetRequestToPodcastsEndpoint_ShouldReturnOkay()
    {
        var httpClient = new CustomWebApplicationFactory().CreateClient();
        var response = await httpClient.GetAsync("/podcasts");
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}