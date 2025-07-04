﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._RMC14.Chemistry.Master;

[GenerateTypedNameReferences]
public sealed partial class RMCChemMasterWindow : DefaultWindow
{
    public RMCChemMasterWindow()
    {
        RobustXamlLoader.Load(this);
    }
}
