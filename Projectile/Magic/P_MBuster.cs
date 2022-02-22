using Terraria;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace TerrariaMan.Projectile.Magic
{

    public class P_MBuster : ModProjectile
    {


        public override void SetDefaults()
        {

            projectile.CloneDefaults(ProjectileID.GreenLaser);
            aiType = ProjectileID.GreenLaser;
        }
    }


   
}
