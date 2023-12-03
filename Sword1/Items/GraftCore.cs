using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;

namespace Sword1.Items
{
	public class GraftCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Graft Core");
		   Tooltip.SetDefault("");
		}

		public override void SetDefaults() 
		{
			item.material = true;
			item.maxStack = 99;
		}
	}
}