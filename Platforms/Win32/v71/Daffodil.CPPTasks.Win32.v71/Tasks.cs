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
    public virtual bool OptimizeWin98
    {
        get
        {
            return (base.IsPropertySet("OptimizeWin98") && base.ActiveToolSwitches["OptimizeWin98"].BooleanValue);
        }
        set
        {
            base.ActiveToolSwitches.Remove("OptimizeWin98");
            ToolSwitch switch2 = new ToolSwitch(ToolSwitchType.Boolean);
            switch2.DisplayName = "Optimize for Windows 98";
            switch2.Description = "Align code on 4K boundaries. This improves performance on Windows 98 systems. (/OPT:WIN98, /OPT:NOWIN98) ";
            switch2.ArgumentRelationList = new System.Collections.ArrayList();
            switch2.SwitchValue = "/OPT:WIN98";
            switch2.ReverseSwitchValue = "/OPT:NOWIN98";
            switch2.Name = "OptimizeWin98";
            switch2.BooleanValue = value;
            base.ActiveToolSwitches.Add("OptimizeWin98", switch2);
            base.AddActiveSwitchToolValue(switch2);
        }
    }
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
