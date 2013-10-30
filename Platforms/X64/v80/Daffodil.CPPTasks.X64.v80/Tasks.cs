using System;
using Microsoft.Build.Utilities;
using Microsoft.Build.CPPTasks;

namespace Daffodil.CPPTasks.x64.v80
{
  public class BSCMakeA : Microsoft.Build.CPPTasks.BSCMake
  {
    protected override void PostProcessSwitchList()
    {
      base.PostProcessSwitchList();
    }
    protected override System.Text.Encoding ResponseFileEncoding
    {
      get
      {
        return System.Text.Encoding.ASCII;
      }
    }
  }
}
