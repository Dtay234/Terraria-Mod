using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Sword1.Items
{
	public class InfernalPistol : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Infernal Pistol"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Explody bullets.");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.ranged = true;
			item.width = 30;
			item.height = 40;
			item.useTime = 35;
			item.useAnimation = 35;
			item.useStyle = 5; 
			item.knockBack = 1;
			item.value = 100000;
			item.rare = 8;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("InfernalBullet");
			item.useAmmo = AmmoID.Bullet;
			item.shootSpeed = 6.5f;
			item.noMelee = true;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			Vector2 offset = new Vector2(speedX * 3, speedY * 3);
			position += offset;
			return true;
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