[Function("HttpExample")]
public static HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req,
    FunctionContext executionContext)