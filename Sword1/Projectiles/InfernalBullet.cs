using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sword1.Projectiles
{
	public class InfernalBullet : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Infernal Bullet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.ChlorophyteBullet);
	//		projectile.ranged = true;
		//	projectile.width = 4;
	//		projectile.height = 20;
	//		projectile.aiStyle = 1;
	//		projectile.friendly = true;
	//		projectile.hostile = false;
	//		projectile.penetrate = 1;
	//		projectile.timeLeft = 400;
	//		projectile.light = 0f;
	//		projectile.ignoreWater = false;
	//		projectile.tileCollide = true;
	//		projectile.scale = 1f;
	//		projectile.extraUpdates = 1;

		}
		
		
		public override void Kill(int timeLeft)
        {
			Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 21, 0.8f, 0.8f);
			for (var i = 0; i < 6; i++);
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
				}
        }

        
    
                
	//	public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
	//	{
	//		target.AddBuff(BuffID.OnFire, 180);
	//	}
	//	public override void RangedEffects(Player player, Rectangle hitbox)
	//	{
	//		int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Fire, 0f, 0f, 0, default(Color), 1f);
	//		Main.dust[dust].noGravity = true;
	//		Main.dust[dust].velocity *= 0;
	//	}
		//     public override bool nTileCollide(Vector2 oldVelocity)
		//      {
		//         return base.OnTileCollide(oldVelocity);
		//      }
		//      {

		//     }
		//	public override bool 

	}
}