using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using Microsoft.Xna.Framework.Graphics;

namespace Sword1.Projectiles
{
	public class GravityOrb : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Gravity Orb"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			projectile.magic = true;
			projectile.width = 18;
			projectile.height = 18;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.penetrate = 1;
			projectile.timeLeft = 600;
			projectile.light = 0.5f;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
		}
		
		public override void AI()
        {
			int dust = Dust.NewDust(projectile.Center, 1, 1, DustID.SandstormInABottle, 0f, 0f, 0, Color.Black, 1f);
			Main.dust[dust].velocity *= 0.2f;
			Main.dust[dust].scale = (float)Main.rand.Next(80, 115) * 0.013f;
			Main.dust[dust].noGravity = true;
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
		}
		public override void Kill(int timeLeft)
		{
			Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height); //makes dust based on tile
			Main.PlaySound(SoundID.Item10, projectile.position); //plays impact sound
		
			
		
		}
	}
}