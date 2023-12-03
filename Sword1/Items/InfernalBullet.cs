using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sword1.Items
{
	public class InfernalBullet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Infernal Bullet");
		   Tooltip.SetDefault("Inflicts flames");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
			item.width = 30;
			item.height = 40;
			item.knockBack = 2;
			item.value = 100;
			item.rare = 8;
			item.consumable = true;
			item.shoot = mod.ProjectileType("InfernalBullet");
			item.ammo = AmmoID.Bullet;
			item.maxStack = 999;
			item.shootSpeed = 7f;
		}
        

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.AddIngredient(ItemID.LivingFireBlock, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}