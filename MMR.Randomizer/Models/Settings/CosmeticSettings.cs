﻿using MMR.Randomizer.Asm;
using MMR.Randomizer.GameObjects;
using MMR.Randomizer.Models.Colors;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;

namespace MMR.Randomizer.Models.Settings
{

    public class CosmeticSettings
    {
        /// <summary>
        /// Options for the Asm <see cref="Patcher"/>.
        /// </summary>
        [JsonIgnore]
        public AsmOptionsCosmetic AsmOptions { get; set; } = new AsmOptionsCosmetic();

        /// <summary>
        /// Hearts color selection used for HUD color override.
        /// </summary>
        public string HeartsSelection { get; set; } = ColorSelectionManager.Hearts.GetItems()[0].Name;

        /// <summary>
        /// Magic color selection used for HUD color override.
        /// </summary>
        public string MagicSelection { get; set; } = ColorSelectionManager.MagicMeter.GetItems()[0].Name;

        /// <summary>
        /// Randomize sound effects
        /// </summary>
        public bool RandomizeSounds { get; set; }

        /// <summary>
        /// Replaces Tatl's colors
        /// </summary>
        public TatlColorSchema TatlColorSchema { get; set; }

        /// <summary>
        /// Randomize background music (includes bgm from other video games)
        /// </summary>
        public Music Music { get; set; }

        /// <summary>
        /// Default Z-Targeting style to Hold
        /// </summary>
        public bool EnableHoldZTargeting { get; set; }

        /// <summary>
        /// Enables playing BGM at night for scenes that switch to night sfx
        /// </summary>
        public bool EnableNightBGM { get; set; }

        public CombatMusic DisableCombatMusic { get; set; }

        public Dictionary<TransformationForm, bool> UseTunicColors { get; set; } = new Dictionary<TransformationForm, bool>();

        public Dictionary<TransformationForm, Color> TunicColors { get; set; } = new Dictionary<TransformationForm, Color>();

        public Dictionary<TransformationForm, FreePlayInstrument> FreePlayInstruments { get; set; } = new Dictionary<TransformationForm, FreePlayInstrument>();

        public Dictionary<TransformationForm, PlaybackInstrument> PlaybackInstruments { get; set; } = new Dictionary<TransformationForm, PlaybackInstrument>();

        #region Asm Getters / Setters

        /// <summary>
        /// D-Pad configuration.
        /// </summary>
        public DPadConfig DPad {
            get { return this.AsmOptions.DPadConfig; }
            set { this.AsmOptions.DPadConfig = value; }
        }

        /// <summary>
        /// HUD colors.
        /// </summary>
        public HudColors HudColors {
            get { return this.AsmOptions.HudColorsConfig.Colors; }
            set { this.AsmOptions.HudColorsConfig.Colors = value; }
        }

        #endregion
    }
}
