using System.Net.NetworkInformation;
using System.Threading;
using System.IO;
using DynamicPatcher;
using Extension.Utilities;
using PatcherYRpp;
using PatcherYRpp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extension.Ext
{


    public partial class TechnoExt
    {
        public OverrideWeaponState OverrideWeaponState => AttachEffectManager.OverrideWeaponState;

    }


}