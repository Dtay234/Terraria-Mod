using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Sword1.Items
{
	public class GravityStaff : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Gravity Staff");
			Tooltip.SetDefault("Flips the gravity of enemies.");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults() 
		{
			item.damage = 100;
			item.mana = 30;
			item.magic = true;
			item.width = 30;
			item.height = 30;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 5; 
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 8;
			item.UseSound = SoundID.Item117;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("GravityOrb");
			item.shootSpeed = 4f;
			item.noMelee = true;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			Vector2 offset = new Vector2(speedX * 6, speedY * 6);
			position += offset;
			return true;
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
			target.AddBuff(BuffID.Gravitation, 180);
        }
    }
}