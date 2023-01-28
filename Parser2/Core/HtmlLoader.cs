namespace Parser2.Core;

public class HtmlLoader
{
  private readonly HttpClient client;
  private readonly string url;

  public HtmlLoader(IParserSettings settings)
  {
    client = new HttpClient();
    url = $"{settings.BaseUrl}{settings.Prefix}/";
  }

  public async Task<string> GetSourseByPageId(int id)
  {
    var currentUrl = url.Replace("{CurrentId}", id.ToString());
    var response = await client.GetAsync(currentUrl);
    string source = null;

    if (response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
    {
      source = await response.Content.ReadAsStringAsync();
    }

    return source;
  }
}