using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static System.Net.Mime.MediaTypeNames;

namespace EnglishToolTip
{
    internal class EnglishToolTipGlobalItem : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            string text = $"English: {(item.ModItem != null ? item.ModItem.Name : EnglishToolTip.ItemMap[item.netID])}";
            TooltipLine line = new(Mod, Mod.Name, text);
            line.OverrideColor = Colors.CoinSilver;
            tooltips.Add(line);
        }
    }
}
