using System;
using Microsoft.Build.Utilities;
using Microsoft.Build.CPPTasks;

namespace Daffodil.CPPTasks.Win32.v71
{
  public class CLA : Microsoft.Build.CPPTasks.CL
  {
    protected override void PostProcessSwitchList()
    {
      if (!IsSetToTrue("BufferSecurityCheck"))
      {
        base.ActiveToolSwitches.Remove("BufferSecurityCheck");
      }
      if (!IsSetToTrue("TreatWChar_tAsBuiltInType"))
      {
        base.ActiveToolSwitches.Remove("TreatWChar_tAsBuiltInType");
      }
      if (!IsSetToTrue("ForceConformanceInForLoopScope"))
      {
        base.ActiveToolSwitches.Remove("ForceConformanceInForLoopScope");
      }
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
  public class LinkA : Microsoft.Build.CPPTasks.Link
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
  public class LIBA : Microsoft.Build.CPPTasks.LIB
  {
    protected override void PostProcessSwitchList()
    {
      base.ActiveToolSwitches.Remove("UseUnicodeResponseFiles");
      base.PostProcessSwitchList();
    }
    public override bool UseUnicodeResponseFiles
    {
      get
      {
        return false;
      }
      set
      {
      }
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
