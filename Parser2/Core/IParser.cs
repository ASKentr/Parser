using AngleSharp.Html.Dom;

namespace Parser2.Core;

public interface IParser<T> where T : class
{
  T Parse(IHtmlDocument document);
}