using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Sword1.Projectiles
{
	public class BnW : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Helix of Duality");
			Main.projFrames[projectile.type] = Main.projFrames[8];
		}

		public override void SetDefaults() 
		{
			projectile.melee = true;
			projectile.width = 10;
			projectile.height = 20;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.penetrate = 2;
			projectile.timeLeft = 1000;
			projectile.light = 1f;
			projectile.ignoreWater = false;
			projectile.tileCollide = true;

		}
	//	public override void FindFrame(int frameHeight)
	//	{
	//		projectile.frameCounter++;
	//		if (projectile.frameCounter >= 8)
	//		{
	//			projectile.frameCounter = 0;
	//		}
	//		projectile.frame.Y = (int)projectile.frameCounter / 10 * frameHeight;
	//	}
	}
}