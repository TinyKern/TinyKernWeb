using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Markdig;

namespace TinyKernel
{
  public static class Markdown
  {
    public static string Parse(string markdown)
    {
      if (string.IsNullOrEmpty(markdown))
        return "";

      var pipeline = new MarkdownPipelineBuilder()
        .UseAdvancedExtensions()
        .Build();

      return Markdig.Markdown.ToHtml(markdown, pipeline);
    }
  }
}
