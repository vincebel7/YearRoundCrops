using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace YearRoundCrops
{
    public class ModEntry : Mod, IAssetLoader {
        public bool CanLoad<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals("Data/Crops"))
            {
                return true;
            }

            return false;
        }

        public override void Entry(IModHelper helper)
        {
        }

        public T Load<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals("Data/Crops"))
            {
                return this.Helper.Content.Load<T>("assets/Crops.json", ContentSource.ModFolder);
            }

            throw new NotImplementedException($"Unexpected asset '{asset.AssetName}`.");
        }
    }
}