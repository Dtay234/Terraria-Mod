using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Sword1.Items
{
	public class PrismStaff : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Prism Staff");
			Tooltip.SetDefault("Amory's choice of staff.");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
			item.mana = 1;
			item.magic = true;
			item.width = 30;
			item.height = 30;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5; 
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 10;
			item.UseSound = SoundID.Item8;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("LaserBeam");	
			item.shootSpeed = 5f;
			item.noMelee = true;
			item.scale = 1.5f;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			Vector2 offset = new Vector2(speedX * 30, speedY * 30);
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