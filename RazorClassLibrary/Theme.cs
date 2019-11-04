using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary
{
  public class Theme
  {
    public string DefaultButtonCssClass { get; set; } = "btn-success";


    public async Task ChangeThemeAsync()
    {
      await Task.Yield();
      this.DefaultButtonCssClass = this.DefaultButtonCssClass.Contains("success") ? "btn-primary" : "btn-success";
    }
  }
}
