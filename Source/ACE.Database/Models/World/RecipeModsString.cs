using System;
using System.Collections.Generic;

namespace ACE.Database.Models.World;

/// <summary>
/// Recipe String Mods
/// </summary>
public partial class RecipeModsString
{
    /// <summary>
    /// Unique Id of this Recipe Mod instance
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// Unique Id of Recipe Mod
    /// </summary>
    public uint RecipeModId { get; set; }

    public sbyte Index { get; set; }

    public int Stat { get; set; }

    public string Value { get; set; }

    public int Enum { get; set; }

    public int Source { get; set; }

    public virtual RecipeMod RecipeMod { get; set; }
}
