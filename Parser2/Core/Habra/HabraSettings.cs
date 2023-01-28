using Parser2.Core;

namespace Parser2.Habra;

public class HabraSettings : IParserSettings
{
    public HabraSettings(int start, int end)
    {
        StartPoint = start;
        EndPoint = end;
    }
  public string BaseUrl { get; set; } = "https://habr.com/ru/all/";
  public string Prefix { get; set; } = "page{CurrentId}";
  public int StartPoint { get; set; }
  public int EndPoint { get; set; }
}