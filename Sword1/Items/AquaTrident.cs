using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;

namespace Sword1.Items
{
	public class AquaTrident : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Aqua Trident");
		   Tooltip.SetDefault("Cool!");
		}

		public override void SetDefaults() 
		{
			item.CloneDefaults(ItemID.Spear);
			item.damage = 50;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.knockBack = 7;
			item.value = 10000;
			item.rare = 8;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("AquaTrident");
		}

		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[mod.ProjectileType("AquaTrident")] < 1;
		}
	}
}