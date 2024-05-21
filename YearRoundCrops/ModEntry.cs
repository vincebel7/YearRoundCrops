using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StardewModdingAPI;
using StardewModdingAPI.Events;

namespace YearRoundCrops
{
    public class ModEntry : Mod
    {
        /// <inheritdoc />
        public override void Entry(IModHelper helper)
        {
            this.Helper.Events.Content.AssetRequested += this.OnAssetRequested;
        }


        /// <inheritdoc cref="IContentEvents.AssetRequested" />
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OnAssetRequested(object sender, AssetRequestedEventArgs e)
        {
            if (e.NameWithoutLocale.IsEquivalentTo("Data/Crops"))
            {
                e.LoadFromModFile<Dictionary<string, StardewValley.GameData.Crops.CropData>>("assets/Crops.json", AssetLoadPriority.Medium);
            }
        }
    }
}