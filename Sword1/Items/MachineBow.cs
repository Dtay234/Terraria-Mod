using Terraria.ID;
using Terraria.ModLoader;

namespace Sword1.Items
{
	public class MachineBow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Machine Bow");
			Tooltip.SetDefault("Amory's choice of bow.");
		}

		public override void SetDefaults() 
		{
			item.damage = 52;
			item.ranged = true;
			item.width = 30;
			item.height = 40;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = 5;
			item.knockBack = 3;
			item.value = 100000;
			item.rare = 8;
			item.UseSound = SoundID.Item114;
			item.autoReuse = true;
			item.shoot = ProjectileID.LaserMachinegun;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 25f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 20);
			recipe.AddIngredient(ItemID.IllegalGunParts, 1);
			recipe.AddIngredient(mod.ItemType("GraftCore"), 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}