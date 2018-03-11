<<<<<<< HEAD
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Fargowiltas.Items.Enchantments
{
	public class CrimsonEnchant : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crimson Enchantment");
			Tooltip.SetDefault("'The blood of your enemy is your rebirth' \n" +
								"Greatly increases life regen \n" +
								"Enemies drop hearts more often \n" +
								"Attacks have a chance to inflict ichor\n" +
								"Summons a Baby Face Monster and a Crimson Heart");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			ItemID.Sets.ItemNoGravity[item.type] = true;
			item.rare = 1; 
			item.value = 20000; 
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
        {	
			FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>(mod);
			modPlayer.crimsonEnchant = true;
			player.crimsonRegen = true;
			
			if (player.whoAmI == Main.myPlayer)
            {
				if(soulcheck.facePet)
				{
					modPlayer.crimsonPet = true;
					
					if(player.FindBuffIndex(154) == -1)
					{
						if (player.ownedProjectileCounts[ProjectileID.BabyFaceMonster] < 1)
						{
							Projectile.NewProjectile(player.Center.X, player.Center.Y, 0f, -1f, ProjectileID.BabyFaceMonster, 0, 2f, Main.myPlayer, 0f, 0f);
						}
					}
				}
				else
				{
					modPlayer.crimsonPet = false;
				}
				
				//if(soulcheck.eaterPet)
				//{
					modPlayer.crimsonPet2 = true;
					
					if(player.FindBuffIndex(155) == -1)
					{
						if (player.ownedProjectileCounts[ProjectileID.CrimsonHeart] < 1)
						{
							Projectile.NewProjectile(player.Center.X, player.Center.Y, 0f, -1f, ProjectileID.CrimsonHeart, 0, 2f, Main.myPlayer, 0f, 0f);
						}
					}
				//}
				//else
				//{
				//		modPlayer.crimsonPet2 = false;
				//}
            }
        }
		
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimsonHelmet);
			recipe.AddIngredient(ItemID.CrimsonScalemail);
			recipe.AddIngredient(ItemID.CrimsonGreaves);
			recipe.AddIngredient(ItemID.DeadlandComesAlive);
			recipe.AddIngredient(ItemID.BoneRattle);
			recipe.AddIngredient(ItemID.CrimsonHeart);
			
			recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}
		
	





=======
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Fargowiltas.Items.Enchantments
{
	public class CrimsonEnchant : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crimson Enchantment");
			Tooltip.SetDefault("'The blood of your enemy is your rebirth' \n5% increase to all damage \nGreatly increases life regen \nEnemies drop hearts more often \nSummons a Baby Face Monster, turn vanity off to despawn it");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			ItemID.Sets.ItemNoGravity[item.type] = true;
			item.rare = 1; 
			item.value = 20000; 
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
        {	
			FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>(mod);
			modPlayer.crimsonEnchant = true;
			player.crimsonRegen = true;
			
			player.magicDamage+= .05f;
			player.meleeDamage+= .05f;
			player.rangedDamage+= .05f;
			player.minionDamage+= .05f;
			player.thrownDamage+= .05f;
			
			if (player.whoAmI == Main.myPlayer)
            {
				if(!hideVisual)
				{
					modPlayer.crimsonPet = true;
					
					if(player.FindBuffIndex(154) == -1)
					{
						if (player.ownedProjectileCounts[ProjectileID.BabyFaceMonster] < 1)
						{
							Projectile.NewProjectile(player.Center.X, player.Center.Y, 0f, -1f, ProjectileID.BabyFaceMonster, 0, 2f, Main.myPlayer, 0f, 0f);
						}
					}
				}
				else
				{
						modPlayer.crimsonPet = false;
				}
            }
        }
		
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimsonHelmet);
			recipe.AddIngredient(ItemID.CrimsonScalemail);
			recipe.AddIngredient(ItemID.CrimsonGreaves);
			recipe.AddIngredient(ItemID.DeadlandComesAlive);
			recipe.AddIngredient(ItemID.BoneRattle);
			
			recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}
		
	





>>>>>>> 66ed39caf4938fca8e7009752b635e42f8a8a58f
