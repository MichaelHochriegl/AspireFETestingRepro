using FastEndpoints;

namespace WebApi.Features.Dummy;

public class GetDummy : EndpointWithoutRequest<GetDummyResponse>
{
    public override void Configure()
    {
        Get("/dummy");
        AllowAnonymous();
    }

    public override Task HandleAsync(CancellationToken ct)
    {
        return SendOkAsync(new GetDummyResponse(Guid.NewGuid()), ct);
    }
}

public record GetDummyResponse(Guid Id);