using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;
using System;

namespace Sword1.Items
{
	public class RunicBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Runic Bow");
			Tooltip.SetDefault("It thrums with ancient magic.");
		}

		public override void SetDefaults()
		{
			item.damage = 40;
			item.ranged = true;
			item.width = 50;
			item.height = 50;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 5;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 1f;
			item.shootSpeed = 5f;
			item.useAmmo = AmmoID.Arrow;
		}


		int hits = 0;
		
		

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
			
			hits += 1;
			if (hits == 1)
            {
				item.knockBack = 5;
				item.damage = 85;
            }

			if (hits == 3)
            {
				item.damage = 170;
				player.HealEffect(damage, true);
				int dust1 = Dust.NewDust(new Vector2(target.position.X + 10, target.position.Y + 10), 50, 50, mod.DustType("AncientRune"), 0f, 0f, 0, Color.Red, 1f);
				int dust2 = Dust.NewDust(new Vector2(target.position.X + 10, target.position.Y - 10), 50, 50, mod.DustType("AncientRune"), 0f, 0f, 0, Color.Red, 1f);
				int dust3 = Dust.NewDust(new Vector2(target.position.X - 10, target.position.Y + 10), 50, 50, mod.DustType("AncientRune"), 0f, 0f, 0, Color.Red, 1f);
				int dust4 = Dust.NewDust(new Vector2(target.position.X - 10, target.position.Y - 10), 50, 50, mod.DustType("AncientRune"), 0f, 0f, 0, Color.Red, 1f);
			}
			if (hits == 6)
            {
				item.damage = 170;
				target.AddBuff(BuffID.Slow, 5);
				int dust1 = Dust.NewDust(new Vector2(target.position.X + 10, target.position.Y + 10), 50, 50, mod.DustType("AncientRuneBlue"), 0f, 0f, 0, Color.Blue, 1f);
				int dust2 = Dust.NewDust(new Vector2(target.position.X + 10, target.position.Y - 10), 50, 50, mod.DustType("AncientRuneBlue"), 0f, 0f, 0, Color.Blue, 1f);
				int dust3 = Dust.NewDust(new Vector2(target.position.X - 10, target.position.Y + 10), 50, 50, mod.DustType("AncientRuneBlue"), 0f, 0f, 0, Color.Blue, 1f);
				int dust4 = Dust.NewDust(new Vector2(target.position.X - 10, target.position.Y - 10), 50, 50, mod.DustType("AncientRuneBlue"), 0f, 0f, 0, Color.Blue, 1f);
			}
			if (hits == 9)
            {
				item.damage = 170;
				item.knockBack = 15;
				int dust1 = Dust.NewDust(new Vector2(target.position.X + 10, target.position.Y + 10), 50, 50, mod.DustType("AncientRunePurple"), 0f, 0f, 0, Color.MediumPurple, 1f);
				int dust2 = Dust.NewDust(new Vector2(target.position.X + 10, target.position.Y - 10), 50, 50, mod.DustType("AncientRunePurple"), 0f, 0f, 0, Color.MediumPurple, 1f);
				int dust3 = Dust.NewDust(new Vector2(target.position.X - 10, target.position.Y + 10), 50, 50, mod.DustType("AncientRunePurple"), 0f, 0f, 0, Color.MediumPurple, 1f);
				int dust4 = Dust.NewDust(new Vector2(target.position.X - 10, target.position.Y - 10), 50, 50, mod.DustType("AncientRunePurple"), 0f, 0f, 0, Color.MediumPurple, 1f);
				hits = 0;
            }
		}

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	//Teleport Code:
	//		ableToTP += 1;
	//	if (ableToTP == 3)
	//		{
	//
		//		Vector2 teleportPos = (player.position - target.position);
//
	//target.position = (target.position - teleportPos);
	//		ableToTP = 0;
		//	}
}