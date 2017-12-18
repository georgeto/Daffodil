using System;
using Microsoft.Build.Utilities;
using Microsoft.Build.CPPTasks;

namespace Daffodil.CPPTasks.Win32.v80
{
    public class CLA : Microsoft.Build.CPPTasks.CL
    {
        protected override void PostProcessSwitchList()
        {
            base.PostProcessSwitchList();
        }
        public virtual bool DefaultCharIsUnsigned
        {
            get
            {
                return (base.IsPropertySet("DefaultCharIsUnsigned") && base.ActiveToolSwitches["DefaultCharIsUnsigned"].BooleanValue);
            }
            set
            {
                base.ActiveToolSwitches.Remove("DefaultCharIsUnsigned");
                ToolSwitch switch2 = new ToolSwitch(ToolSwitchType.Boolean);
                switch2.DisplayName = "Default Char Unsigned";
                switch2.Description = "Sets the default char type to unsigned.     (/J)";
                switch2.ArgumentRelationList = new System.Collections.ArrayList();
                switch2.SwitchValue = "/J";
                switch2.ReverseSwitchValue = "";
                switch2.Name = "DefaultCharIsUnsigned";
                switch2.BooleanValue = value;
                base.ActiveToolSwitches.Add("DefaultCharIsUnsigned", switch2);
                base.AddActiveSwitchToolValue(switch2);
            }
        }
        public virtual bool Detect64BitPortabilityProblems
        {
            get
            {
                return (base.IsPropertySet("Detect64BitPortabilityProblems") && base.ActiveToolSwitches["Detect64BitPortabilityProblems"].BooleanValue);
            }
            set
            {
                base.ActiveToolSwitches.Remove("Detect64BitPortabilityProblems");
                ToolSwitch switch2 = new ToolSwitch(ToolSwitchType.Boolean);
                switch2.DisplayName = "Detect 64-bit Portability Issues";
                switch2.Description = "Tells the compiler to check for 64-bit portability issues.     (/Wp64)";
                switch2.ArgumentRelationList = new System.Collections.ArrayList();
                switch2.SwitchValue = "/Wp64";
                switch2.ReverseSwitchValue = "";
                switch2.Name = "Detect64BitPortabilityProblems";
                switch2.BooleanValue = value;
                base.ActiveToolSwitches.Add("Detect64BitPortabilityProblems", switch2);
                base.AddActiveSwitchToolValue(switch2);
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
