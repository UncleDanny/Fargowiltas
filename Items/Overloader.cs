<<<<<<< HEAD
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;

namespace Fargowiltas.Items
{
	public class Overloader : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Overloader");
			Tooltip.SetDefault("Used to craft swarm summons\n" + 
								"When used, all summons in the stack will be consumed\n" + 
								"The more consumed, the more bosses spawned");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 4));
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.rare = 1;

		}
	}
=======
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;

namespace Fargowiltas.Items
{
	public class Overloader : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Overloader");
			Tooltip.SetDefault("Used to craft swarm summons\n" + 
								"When used, all summons in the stack will be consumed\n" + 
								"The more consumed, the more bosses spawned");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 4));
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.rare = 1;

		}
	}
>>>>>>> 66ed39caf4938fca8e7009752b635e42f8a8a58f
}