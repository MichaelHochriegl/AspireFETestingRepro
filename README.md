# AspireFETestingRepro
This is a small reproduction repository to showcase the exception 
`System.Collections.Generic.KeyNotFoundException: The given key 'WebApi.Features.Dummy.GetDummy' was not present in the dictionary.`
when using FastEndpoints with Aspire.

The problem arises as the `HttpClient` extensions shipped by FastEndpoints are filling the appropriate
`TestUrlCache`, but for some strange reason when the test wants to get the endpoint from that dictionary
it is empty.