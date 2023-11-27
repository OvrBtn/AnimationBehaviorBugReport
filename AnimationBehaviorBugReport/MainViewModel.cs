using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimationBehaviorBugReport
{
    public class MainViewModel
    {
        public Command TestCommand { get; set; }

        public MainViewModel()
        {
            TestCommand = new Command(() => { });
        }

    }
}
