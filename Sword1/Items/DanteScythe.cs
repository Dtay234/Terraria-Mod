using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;

namespace Sword1.Items
{
	public class DanteScythe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Dante's Scythe");
		   Tooltip.SetDefault("My first item!");
		}

		public override void SetDefaults() 
		{
			item.damage = 100;
			item.melee = true;
			item.width = 30;
			item.height = 40;
			item.useTime = 2;
			item.useAnimation = 2;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}