using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BlazorTutorial_1.Classes
{
    public class HelpBoxInfo
    {
        public string helpBoxText { get; set; }
        public bool toggle { get; set; }
        public string mouseContext { get; set; }
        public string boxColor { get; set; }

        public event Action OnChange;
        public HelpBoxInfo(string mouseContext, string helpBoxText, bool toggle, string boxColor)
        {
            this.mouseContext = mouseContext;
            this.helpBoxText = helpBoxText;
            this.toggle = toggle;
            this.boxColor = boxColor;
        }
        public void SetInfo(string MouseContext, string helpBoxText, bool toggle, string boxColor)
        {
            this.mouseContext = mouseContext;
            this.helpBoxText = helpBoxText;
            this.toggle = toggle;
            this.boxColor = boxColor;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}