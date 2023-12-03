using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace Sword1.Projectiles
{
	public class LaserBeam : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Prism Beam"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			projectile.magic = true;
			projectile.width = 5;
			projectile.height = 5;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.penetrate = -1;
			projectile.timeLeft = 180;
			projectile.light = 2f;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.extraUpdates = 5;
			 

		}
		public override void AI()
		{
			//Projectile appears at 4 ticks
			if (projectile.ai[0] > 4f)
			{
				for (int i = 0; i < 4; i++)
				{
					int DustID = Dust.NewDust(projectile.position, projectile.width + 2, projectile.height + 2, 6, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 100, default(Color), 1f);
					Main.dust[DustID].noGravity = true;
					Main.dust[DustID].scale *= 1.75f;
				}
			}
			projectile.ai[0] += 1f;
		}

	}
}