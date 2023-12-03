using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sword1.Accessories
{
	public class BrknCrystalHeart : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Broken Crystal Heart"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("You deal more damage when at low health.");
		}

		public override void SetDefaults() 
		{
			item.accessory = true;
			item.width = 20;
			item.height = 20;
			item.rare = 8;
			item.value = 10000;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			if (player.statLife < (player.statLifeMax / 5)) player.allDamageMult += 2f;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LifeCrystal, 1);
			recipe.AddIngredient(ItemID.BandofRegeneration, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}