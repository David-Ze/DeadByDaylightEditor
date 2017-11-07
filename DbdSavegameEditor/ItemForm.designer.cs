namespace DbdSavegameEditor {
    partial class ItemForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.save_btn = new System.Windows.Forms.Button();
            this.input_fld = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_control_create_items = new System.Windows.Forms.TabControl();
            this.tab_manual = new System.Windows.Forms.TabPage();
            this.tab_items = new System.Windows.Forms.TabPage();
            this.list_box_items_survivor = new System.Windows.Forms.ListBox();
            this.tab_survivor_addons = new System.Windows.Forms.TabPage();
            this.list_box_addons_survivor = new System.Windows.Forms.ListBox();
            this.tab_killer_addons = new System.Windows.Forms.TabPage();
            this.list_box_addons_killer = new System.Windows.Forms.ListBox();
            this.tab_survivor_perks = new System.Windows.Forms.TabPage();
            this.list_box_perks_survivor = new System.Windows.Forms.ListBox();
            this.tab_killer_perks = new System.Windows.Forms.TabPage();
            this.list_box_perks_killer = new System.Windows.Forms.ListBox();
            this.tab_offerings = new System.Windows.Forms.TabPage();
            this.list_box_offerings = new System.Windows.Forms.ListBox();
            this.tab_control_create_items.SuspendLayout();
            this.tab_manual.SuspendLayout();
            this.tab_items.SuspendLayout();
            this.tab_survivor_addons.SuspendLayout();
            this.tab_killer_addons.SuspendLayout();
            this.tab_survivor_perks.SuspendLayout();
            this.tab_killer_perks.SuspendLayout();
            this.tab_offerings.SuspendLayout();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save_btn.Location = new System.Drawing.Point(12, 360);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(193, 31);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // input_fld
            // 
            this.input_fld.AutoCompleteCustomSource.AddRange(new string[] {
            "ADDON_Bell_AllseeingSpirit",
            "ADDON_Bell_AllseeingWhite",
            "ADDON_Bell_BlindBlood",
            "ADDON_Bell_BlindSpirit",
            "ADDON_Bell_BlindWhite",
            "ADDON_Bell_CoxcombedClapper",
            "ADDON_Bell_SwiftMud",
            "ADDON_Bell_WindstormBlood",
            "ADDON_Chainsaw_CarburatorGuide",
            "ADDON_Chainsaw_DeathEngravings",
            "ADDON_Chainsaw_DoomEngravings",
            "ADDON_Chainsaw_HomemadeMuffler",
            "ADDON_Chainsaw_LightChassis",
            "ADDON_Chainsaw_ThompsonMix",
            "ADDON_Chainsaw_ThompsonMoonshine",
            "ADDON_LFChainsaw_AwardWinningChili",
            "ADDON_LFChainsaw_BeastsMarks",
            "ADDON_LFChainsaw_BegrimedChain",
            "ADDON_LFChainsaw_CarburatorGuide",
            "ADDON_LFChainsaw_ChainsawFile",
            "ADDON_LFChainsaw_Chili",
            "ADDON_LFChainsaw_DepthGaugeRake",
            "ADDON_LFChainsaw_GrislyChains",
            "ADDON_LFChainsaw_HomemadeMuffler",
            "ADDON_LFChainsaw_KnifeScratches",
            "ADDON_LFChainsaw_LightChassis",
            "ADDON_LFChainsaw_LongGuideBar",
            "ADDON_LFChainsaw_PrimerBulb",
            "ADDON_LFChainsaw_RustedChain",
            "ADDON_LFChainsaw_ShopLubricant",
            "ADDON_LFChainsaw_SparkPlug",
            "ADDON_LFChainsaw_SpeedLimiter",
            "ADDON_LFChainsaw_TheGrease",
            "ADDON_LFChainsaw_VegetableOil",
            "ADDON_Lastbreath_AtaxicRespiration",
            "ADDON_Lastbreath_BadManLastBreath",
            "ADDON_Lastbreath_DullBracelet",
            "ADDON_Lastbreath_HeavyPanting",
            "ADDON_Lastbreath_JennerLastBreath",
            "ADDON_Lastbreath_KavanaghLastBreath",
            "ADDON_Lastbreath_Matchbox",
            "ADDON_Lastbreath_SpasmodicBreath",
            "ADDON_flashlight_highendsapphire",
            "ADDON_flashlight_intensehalogen",
            "ADDON_flashlight_lonflifebattery",
            "ADDON_flashlight_oddbulb",
            "ADDON_flashlight_rubbergrip",
            "ADDON_medkit_abdominaldressing",
            "ADDON_medkit_gauzeroll",
            "ADDON_medkit_needleandthread",
            "ADDON_medkit_selfadherentwrap",
            "ADDON_medkit_surgicalsuture",
            "ADDON_toolbox_cuttingwire",
            "ADDON_toolbox_socketswivels",
            "ADDON_toolbox_springclamp",
            "ADDON_trap_BloodyCoil",
            "ADDON_trap_DiamondStone",
            "ADDON_trap_OilyCoil",
            "ADDON_trap_RustedJaw",
            "ADDON_trap_StitchedBag",
            "ADDON_trap_TrapSetters",
            "Addon_Beartrap_001",
            "Addon_Beartrap_002",
            "Addon_Beartrap_003",
            "Addon_Beartrap_004",
            "Addon_Beartrap_005",
            "Addon_Beartrap_006",
            "Addon_Beartrap_007",
            "Addon_Beartrap_008",
            "Addon_Beartrap_009",
            "Addon_Beartrap_010",
            "Addon_Beartrap_011",
            "Addon_Beartrap_012",
            "Addon_Bell_001",
            "Addon_Bell_002",
            "Addon_Bell_003",
            "Addon_Bell_004",
            "Addon_Bell_005",
            "Addon_Bell_006",
            "Addon_Bell_007",
            "Addon_Bell_008",
            "Addon_Bell_009",
            "Addon_Bell_010",
            "Addon_Bell_011",
            "Addon_Bell_012",
            "Addon_Blinker_001",
            "Addon_Blinker_002",
            "Addon_Blinker_003",
            "Addon_Blinker_004",
            "Addon_Blinker_005",
            "Addon_Blinker_006",
            "Addon_Blinker_007",
            "Addon_Blinker_008",
            "Addon_Blinker_009",
            "Addon_Blinker_010",
            "Addon_Blinker_011",
            "Addon_Blinker_012",
            "Addon_Chainsaw_001",
            "Addon_Chainsaw_002",
            "Addon_Chainsaw_003",
            "Addon_Chainsaw_004",
            "Addon_Chainsaw_005",
            "Addon_Chainsaw_006",
            "Addon_Chainsaw_007",
            "Addon_Chainsaw_008",
            "Addon_Chainsaw_009",
            "Addon_Chainsaw_010",
            "Addon_Chainsaw_011",
            "Addon_Chainsaw_012",
            "Addon_Firecracker_BlackPowder",
            "Addon_Firecracker_BuckShot",
            "Addon_Firecracker_FlashPowder",
            "Addon_Firecracker_GunPowder",
            "Addon_Firecracker_LargePack",
            "Addon_Firecracker_LongFuse",
            "Addon_Firecracker_MagnesiumPowder",
            "Addon_Firecracker_MediumFuse",
            "Addon_Flashlight_001",
            "Addon_Flashlight_002",
            "Addon_Flashlight_003",
            "Addon_Flashlight_004",
            "Addon_Flashlight_005",
            "Addon_Flashlight_006",
            "Addon_Flashlight_007",
            "Addon_Flashlight_008",
            "Addon_Hatchet_AmanitaToxin",
            "Addon_Hatchet_BandagedHaft",
            "Addon_Hatchet_BegrimedHead",
            "Addon_Hatchet_BerusToxin",
            "Addon_Hatchet_CoarseStone",
            "Addon_Hatchet_DeerskinGloves",
            "Addon_Hatchet_FineStone",
            "Addon_Hatchet_FlowerBabushka",
            "Addon_Hatchet_GlowingConcoction",
            "Addon_Hatchet_InfantryBelt",
            "Addon_Hatchet_IridescentHead",
            "Addon_Hatchet_LeatherLoop",
            "Addon_Hatchet_MannaGrassBraid",
            "Addon_Hatchet_OakHaft",
            "Addon_Hatchet_PungentFiale",
            "Addon_Hatchet_RustyHead",
            "Addon_Hatchet_ShinyPin",
            "Addon_Hatchet_VenomousConcoction",
            "Addon_Hatchet_YewSeedBrew",
            "Addon_Hatchet_YewSeedConcoction",
            "Addon_Key_001",
            "Addon_Key_002",
            "Addon_Key_003",
            "Addon_Key_004",
            "Addon_Key_005",
            "Addon_Key_006",
            "Addon_Key_007",
            "Addon_Key_008",
            "Addon_Map_001",
            "Addon_Map_002",
            "Addon_Map_003",
            "Addon_Map_004",
            "Addon_Map_005",
            "Addon_Map_006",
            "Addon_Map_007",
            "Addon_Map_008",
            "Addon_Map_009",
            "Addon_Medkit_001",
            "Addon_Medkit_002",
            "Addon_Medkit_003",
            "Addon_Medkit_004",
            "Addon_Medkit_005",
            "Addon_Medkit_006",
            "Addon_Medkit_007",
            "Addon_Medkit_008",
            "Addon_PhantomTrap_BloodiedMud",
            "Addon_PhantomTrap_BloodiedWater",
            "Addon_PhantomTrap_BogWater",
            "Addon_PhantomTrap_CrackedTurtleEgg",
            "Addon_PhantomTrap_CypressNecklet",
            "Addon_PhantomTrap_DeadFlyMud",
            "Addon_PhantomTrap_DisfiguredEar",
            "Addon_PhantomTrap_DragonflyWings",
            "Addon_PhantomTrap_DriedCicada",
            "Addon_PhantomTrap_GranmasHeart",
            "Addon_PhantomTrap_HalfEggshell",
            "Addon_PhantomTrap_MintRag",
            "Addon_PhantomTrap_PowderedEggshell",
            "Addon_PhantomTrap_PussyWillowCatkins",
            "Addon_PhantomTrap_RopeNecklet",
            "Addon_PhantomTrap_RustyShackles",
            "Addon_PhantomTrap_ScarredHand",
            "Addon_PhantomTrap_SwampOrchidNecklet",
            "Addon_PhantomTrap_WaterloggedShoe",
            "Addon_PhantomTrap_WillowWreath",
            "Addon_Spark_CalmClassI",
            "Addon_Spark_CalmClassII",
            "Addon_Spark_CalmMuYisNotes",
            "Addon_Spark_DisciplineClassII",
            "Addon_Spark_DisciplineClassIII",
            "Addon_Spark_DisciplineMuYisNotes",
            "Addon_Spark_HighStimulusElectrode",
            "Addon_Spark_IridescentGeneral",
            "Addon_Spark_JadeCharm",
            "Addon_Spark_MoldyElectrode",
            "Addon_Spark_NanmuCatapult",
            "Addon_Spark_Obedience_MuYisNotes",
            "Addon_Spark_OrderClassI",
            "Addon_Spark_OrderClassII",
            "Addon_Spark_OrderMuYisNotes",
            "Addon_Spark_PolishedElectrode",
            "Addon_Spark_RestraintClassII",
            "Addon_Spark_RestraintClassIII",
            "Addon_Spark_RestraintMuYisNotes",
            "Addon_Spark_TigerFangCharm",
            "Addon_Stalker_BlondHair",
            "Addon_Stalker_BoyfriendsMemo",
            "Addon_Stalker_DeadRabbit",
            "Addon_Stalker_FragrantTuftOfHair",
            "Addon_Stalker_GlassFragment",
            "Addon_Stalker_HairBow",
            "Addon_Stalker_HairBrush",
            "Addon_Stalker_JMyersMemorial",
            "Addon_Stalker_Jewelry",
            "Addon_Stalker_JewelryBox",
            "Addon_Stalker_JudithsJournal",
            "Addon_Stalker_JudithsTombstone",
            "Addon_Stalker_LockOfHair",
            "Addon_Stalker_MemorialFlower",
            "Addon_Stalker_MirrorShard",
            "Addon_Stalker_ReflectiveFragment",
            "Addon_Stalker_ScratchedMirror",
            "Addon_Stalker_TackyEarrings",
            "Addon_Stalker_TombstonePiece",
            "Addon_Stalker_VanityMirror",
            "Addon_Toolbox_001",
            "Addon_Toolbox_002",
            "Addon_Toolbox_003",
            "Addon_Toolbox_004",
            "Addon_Toolbox_005",
            "Addon_Toolbox_006",
            "Addon_Toolbox_007",
            "Addon_Toolbox_008",
            "Item_Camper_AlexsToolbox",
            "Item_Camper_BeigeMap",
            "Item_Camper_BrokenKey",
            "Item_Camper_CommodiousToolbox",
            "Item_Camper_DullKey",
            "Item_Camper_EngineerToolbox",
            "Item_Camper_Firecracker_Chinese",
            "Item_Camper_Flashlight",
            "Item_Camper_Flashlight02",
            "Item_Camper_Flashlight03",
            "Item_Camper_Key",
            "Item_Camper_MechanicsToolbox",
            "Item_Camper_MedKit",
            "Item_Camper_MedKit02",
            "Item_Camper_MedKit03",
            "Item_Camper_MedKit04",
            "Item_Camper_RainbowMap",
            "Item_Camper_Toolbox",
            "Item_Camper_WornoutToolbox",
            "ArdentRavenWreath",
            "ArdentShrikeWreath",
            "ArdentSpottedowlWreath",
            "ArdentTanagerWreath",
            "AzarovKey",
            "BlackSaltStatuette",
            "BlackSplinter",
            "BlackWard",
            "BloodyPartyStreamers",
            "BogLaurelSachet",
            "BoneSplinter",
            "BoundEnvelope",
            "Cannibal",
            "CattleTag28",
            "ChalkPouch",
            "CharredWeddingPhotograph",
            "ChildrensBook",
            "ClearReagent",
            "ColdwindCattleTag81",
            "CreamChalkPouch",
            "CrescentMoonBouquet",
            "CrispleafAmaranthSachet",
            "CutCoin",
            "CypressMementoMori",
            "DecrepitClapboard",
            "DevoutRavenWreath",
            "DevoutShrikeWreath",
            "DevoutSpottedowlWreath",
            "DevoutTanagerWreath",
            "EbonyMementoMori",
            "EmergencyCertificate",
            "EscapeCake",
            "FaintReagent",
            "FragrantBogLaurel",
            "FragrantCrispleafAmaranth",
            "FragrantPrimroseBlossom",
            "FragrantSweetWilliam",
            "FreshBogLaurel",
            "FreshCrispleafAmaranth",
            "FreshPrimroseBlossom",
            "FreshSweetWilliam",
            "FullMoonBouquet",
            "FumingCordage",
            "FumingWelcomeSign",
            "GranmasCookbook",
            "HarvestFestivalLeaflet",
            "HazyReagent",
            "HeartLocket",
            "HollowShell",
            "IvoryChalkPouch",
            "IvoryMementoMori",
            "LunacyTicket",
            "MacMillanPhalanxBone",
            "MacmillanLedgerPage",
            "MoldyOak",
            "MuddySplinter",
            "MurkyReagent",
            "NewMoonBouquet",
            "PElliotLunacyTicket",
            "PaintedRiverRock",
            "PetrifiedOak",
            "PrimroseBlossomSachet",
            "PsychiatricAssessmentReport",
            "PutridOak",
            "QuarterMoonBouquet",
            "RavenWreath",
            "RottenOak",
            "SaltPouch",
            "ScratchedCoin",
            "SealedEnvelope",
            "ShatteredGlasses",
            "ShinyCoin",
            "ShockSplinter",
            "ShreddedPlate",
            "ShrikeWreath",
            "ShroudofBinding",
            "ShroudofSeparation",
            "ShroudofUnion",
            "SignedLedgerPage",
            "SpottedOwlWreath",
            "StrodeRealtyKey",
            "SurvivorPudding",
            "SweetWilliamSachet",
            "TanagerWreath",
            "TarnishedCoin",
            "TheLastMask",
            "VigosJarOfSaltyLips",
            "VigosShroud",
            "VirginiaPlate",
            "WhiteWard",
            "Ace_In_The_Hole",
            "Adrenaline",
            "Agitation",
            "Alert",
            "BBQAndChilli",
            "Balanced_Landing",
            "BeastOfPrey",
            "Bitter_Murmur",
            "Bloodhound",
            "Bond",
            "BorrowedTime",
            "Botany_Knowledge",
            "Brutal_Strength",
            "Calm_Spirit",
            "Dark_Sense",
            "DeadHard",
            "DecisiveStrike",
            "Deerstalker",
            "Deja_Vu",
            "Distressing",
            "Dying_Light",
            "Empathy",
            "Enduring",
            "FranklinsLoss",
            "GeneratorOvercharge",
            "Hex_Devour_Hope",
            "Hex_HuntressLullaby",
            "Hex_Ruin",
            "Hex_The_Third_Seal",
            "Hex_Thrill_Of_The_Hunt",
            "Hope",
            "Insidious",
            "Iron_Grasp",
            "Iron_Will",
            "Kindred",
            "Last_Standing",
            "Leader",
            "LeftBehind",
            "Lightborn",
            "Lightweight",
            "Lithe",
            "MonitorAndAbuse",
            "Monstrous_Shrine",
            "NoMither",
            "No_One_Escapes_Death",
            "No_One_Left_Behind",
            "NurseCalling",
            "ObjectOfObsession",
            "Open_Handed",
            "OverwhelmingPresence",
            "Play_With_Your_Food",
            "Plunderers_Instinct",
            "Predator",
            "Premonition",
            "Prove_Thyself",
            "QuickQuiet",
            "Resilience",
            "Saboteur",
            "Save_The_Best_For_Last",
            "SelfSufficient",
            "Self_Care",
            "Shadowborn",
            "Slippery_Meat",
            "Sloppy_Butcher",
            "Small_Game",
            "SoleSurvivor",
            "Spies_From_The_Shadows",
            "Spine_Chill",
            "Sprint_Burst",
            "Streetwise",
            "Stridor",
            "Technician",
            "TerritorialImperative",
            "Thanatophobia",
            "This_Is_Not_Happening",
            "Tinkerer",
            "Unnerving_Presence",
            "Unrelenting",
            "Up_The_Ante",
            "Urban_Evasion",
            "WellMakeIt",
            "WereGonnaLiveForever",
            "Whispers",
            "Ace_In_The_Hole_TEACH_",
            "Adrenaline_TEACH_",
            "Agitation_TEACH_",
            "Alert_TEACH_",
            "BBQAndChilli_TEACH_",
            "Balanced_Landing_TEACH_",
            "BeastOfPrey_TEACH_",
            "Bitter_Murmur_TEACH_",
            "Bloodhound_TEACH_",
            "Bond_TEACH_",
            "BorrowedTime_TEACH_",
            "Botany_Knowledge_TEACH_",
            "Brutal_Strength_TEACH_",
            "Calm_Spirit_TEACH_",
            "Dark_Sense_TEACH_",
            "DeadHard_TEACH_",
            "DecisiveStrike_TEACH_",
            "Deerstalker_TEACH_",
            "Deja_Vu_TEACH_",
            "Distressing_TEACH_",
            "Dying_Light_TEACH_",
            "Empathy_TEACH_",
            "Enduring_TEACH_",
            "FranklinsLoss_TEACH_",
            "GeneratorOvercharge_TEACH_",
            "Hex_Devour_Hope_TEACH_",
            "Hex_HuntressLullaby_TEACH_",
            "Hex_Ruin_TEACH_",
            "Hex_The_Third_Seal_TEACH_",
            "Hex_Thrill_Of_The_Hunt_TEACH_",
            "Hope_TEACH_",
            "Insidious_TEACH_",
            "Iron_Grasp_TEACH_",
            "Iron_Will_TEACH_",
            "Kindred_TEACH_",
            "Last_Standing_TEACH_",
            "Leader_TEACH_",
            "LeftBehind_TEACH_",
            "Lightborn_TEACH_",
            "Lightweight_TEACH_",
            "Lithe_TEACH_",
            "MonitorAndAbuse_TEACH_",
            "Monstrous_Shrine_TEACH_",
            "NoMither_TEACH_",
            "No_One_Escapes_Death_TEACH_",
            "No_One_Left_Behind_TEACH_",
            "NurseCalling_TEACH_",
            "ObjectOfObsession_TEACH_",
            "Open_Handed_TEACH_",
            "OverwhelmingPresence_TEACH_",
            "Play_With_Your_Food_TEACH_",
            "Plunderers_Instinct_TEACH_",
            "Predator_TEACH_",
            "Premonition_TEACH_",
            "Prove_Thyself_TEACH_",
            "QuickQuiet_TEACH_",
            "Resilience_TEACH_",
            "Saboteur_TEACH_",
            "Save_The_Best_For_Last_TEACH_",
            "SelfSufficient_TEACH_",
            "Self_Care_TEACH_",
            "Shadowborn_TEACH_",
            "Slippery_Meat_TEACH_",
            "Sloppy_Butcher_TEACH_",
            "Small_Game_TEACH_",
            "SoleSurvivor_TEACH_",
            "Spies_From_The_Shadows_TEACH_",
            "Spine_Chill_TEACH_",
            "Sprint_Burst_TEACH_",
            "Streetwise_TEACH_",
            "Stridor_TEACH_",
            "Technician_TEACH_",
            "TerritorialImperative_TEACH_",
            "Thanatophobia_TEACH_",
            "This_Is_Not_Happening_TEACH_",
            "Tinkerer_TEACH_",
            "Unnerving_Presence_TEACH_",
            "Unrelenting_TEACH_",
            "Up_The_Ante_TEACH_",
            "Urban_Evasion_TEACH_",
            "WellMakeIt_TEACH_",
            "WereGonnaLiveForever_TEACH_",
            "Whispers_TEACH_",
            "BloodWarden",
            "FireUp",
            "RememberMe",
            "BloodWarden_TEACH_",
            "FireUp_TEACH_",
            "RememberMe_TEACH_",
            "Addon_DreamInducer_BlackBox",
            "Addon_DreamInducer_BlueDress",
            "Addon_DreamInducer_CatBlock",
            "Addon_DreamInducer_ClassPhoto",
            "Addon_DreamInducer_GardenRake",
            "Addon_DreamInducer_GreenDress",
            "Addon_DreamInducer_JumpRope",
            "Addon_DreamInducer_KidsDrawing",
            "Addon_DreamInducer_NancysMasterpiece",
            "Addon_DreamInducer_NancysSketch",
            "Addon_DreamInducer_PillBottle",
            "Addon_DreamInducer_PrototypeClaws",
            "Addon_DreamInducer_RedPaintBrush",
            "Addon_DreamInducer_Rope",
            "Addon_DreamInducer_SheepBlock",
            "Addon_DreamInducer_SwingChains",
            "Addon_DreamInducer_UnicornBlock",
            "Addon_DreamInducer_WoolShirt",
            "Addon_DreamInducer_ZBlock",
            "Addon_DreamInducer_PaintThinner",
            "Pharmacy",
            "Vigil",
            "WakeUp",
            "Vigil_TEACH_",
            "Pharmacy_TEACH_",
            "WakeUp_TEACH_",
            "ThePiedPiper"});
            this.input_fld.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.input_fld.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.input_fld.Location = new System.Drawing.Point(53, 143);
            this.input_fld.Name = "input_fld";
            this.input_fld.Size = new System.Drawing.Size(401, 20);
            this.input_fld.TabIndex = 1;
            this.input_fld.Text = "default";
            // 
            // cancel_btn
            // 
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Location = new System.Drawing.Point(402, 360);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(193, 31);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter the item name:";
            // 
            // tab_control_create_items
            // 
            this.tab_control_create_items.Controls.Add(this.tab_manual);
            this.tab_control_create_items.Controls.Add(this.tab_items);
            this.tab_control_create_items.Controls.Add(this.tab_survivor_addons);
            this.tab_control_create_items.Controls.Add(this.tab_killer_addons);
            this.tab_control_create_items.Controls.Add(this.tab_survivor_perks);
            this.tab_control_create_items.Controls.Add(this.tab_killer_perks);
            this.tab_control_create_items.Controls.Add(this.tab_offerings);
            this.tab_control_create_items.Location = new System.Drawing.Point(12, 12);
            this.tab_control_create_items.Name = "tab_control_create_items";
            this.tab_control_create_items.SelectedIndex = 0;
            this.tab_control_create_items.Size = new System.Drawing.Size(583, 332);
            this.tab_control_create_items.TabIndex = 4;
            // 
            // tab_manual
            // 
            this.tab_manual.Controls.Add(this.label1);
            this.tab_manual.Controls.Add(this.input_fld);
            this.tab_manual.Location = new System.Drawing.Point(4, 22);
            this.tab_manual.Name = "tab_manual";
            this.tab_manual.Padding = new System.Windows.Forms.Padding(3);
            this.tab_manual.Size = new System.Drawing.Size(575, 306);
            this.tab_manual.TabIndex = 0;
            this.tab_manual.Text = "Manual";
            this.tab_manual.UseVisualStyleBackColor = true;
            // 
            // tab_items
            // 
            this.tab_items.Controls.Add(this.list_box_items_survivor);
            this.tab_items.Location = new System.Drawing.Point(4, 22);
            this.tab_items.Name = "tab_items";
            this.tab_items.Padding = new System.Windows.Forms.Padding(3);
            this.tab_items.Size = new System.Drawing.Size(575, 306);
            this.tab_items.TabIndex = 1;
            this.tab_items.Text = "Items Survivor";
            this.tab_items.UseVisualStyleBackColor = true;
            // 
            // list_box_items_survivor
            // 
            this.list_box_items_survivor.FormattingEnabled = true;
            this.list_box_items_survivor.Items.AddRange(new object[] {
            "Item_Camper_AlexsToolbox",
            "Item_Camper_BeigeMap",
            "Item_Camper_BrokenKey",
            "Item_Camper_CommodiousToolbox",
            "Item_Camper_DullKey",
            "Item_Camper_EngineerToolbox",
            "Item_Camper_Firecracker_Chinese",
            "Item_Camper_Flashlight (Yellow)",
            "Item_Camper_Flashlight02 (Green)",
            "Item_Camper_Flashlight03 (Purple)",
            "Item_Camper_Key",
            "Item_Camper_MechanicsToolbox",
            "Item_Camper_MedKit (Camping Aid Kit)",
            "Item_Camper_MedKit02 (First Aid Kit)",
            "Item_Camper_MedKit03 (Emergency Med-Kit)",
            "Item_Camper_MedKit04 (Ranger Med-Kit)",
            "Item_Camper_RainbowMap",
            "Item_Camper_Toolbox",
            "Item_Camper_WornoutToolbox"});
            this.list_box_items_survivor.Location = new System.Drawing.Point(2, 2);
            this.list_box_items_survivor.Name = "list_box_items_survivor";
            this.list_box_items_survivor.Size = new System.Drawing.Size(569, 303);
            this.list_box_items_survivor.TabIndex = 5;
            this.list_box_items_survivor.SelectedIndexChanged += new System.EventHandler(this.select_item);
            // 
            // tab_survivor_addons
            // 
            this.tab_survivor_addons.Controls.Add(this.list_box_addons_survivor);
            this.tab_survivor_addons.Location = new System.Drawing.Point(4, 22);
            this.tab_survivor_addons.Name = "tab_survivor_addons";
            this.tab_survivor_addons.Size = new System.Drawing.Size(575, 306);
            this.tab_survivor_addons.TabIndex = 2;
            this.tab_survivor_addons.Text = "Addons Survivor";
            this.tab_survivor_addons.UseVisualStyleBackColor = true;
            // 
            // list_box_addons_survivor
            // 
            this.list_box_addons_survivor.FormattingEnabled = true;
            this.list_box_addons_survivor.Items.AddRange(new object[] {
            "ADDON_flashlight_highendsapphire",
            "ADDON_flashlight_intensehalogen",
            "ADDON_flashlight_lonflifebattery",
            "ADDON_flashlight_oddbulb",
            "ADDON_flashlight_rubbergrip",
            "ADDON_medkit_abdominaldressing",
            "ADDON_medkit_gauzeroll",
            "ADDON_medkit_needleandthread",
            "ADDON_medkit_selfadherentwrap",
            "ADDON_medkit_surgicalsuture",
            "ADDON_toolbox_cuttingwire",
            "ADDON_toolbox_socketswivels",
            "ADDON_toolbox_springclamp",
            "Addon_Firecracker_BlackPowder",
            "Addon_Firecracker_BuckShot",
            "Addon_Firecracker_FlashPowder",
            "Addon_Firecracker_GunPowder",
            "Addon_Firecracker_LargePack",
            "Addon_Firecracker_LongFuse",
            "Addon_Firecracker_MagnesiumPowder",
            "Addon_Firecracker_MediumFuse",
            "Addon_Flashlight_001 (Battery)",
            "Addon_Flashlight_002 (Heavy Duty Battery)",
            "Addon_Flashlight_003 (Focus Lens)",
            "Addon_Flashlight_004 (Wide Lens)",
            "Addon_Flashlight_005 (Power Bulb)",
            "Addon_Flashlight_006 (Tir Optic)",
            "Addon_Flashlight_007 (Low Amp Filament)",
            "Addon_Flashlight_008 (Leather Grip)",
            "Addon_Key_001 (Prayer Rope)",
            "Addon_Key_002 (Prayer Beads)",
            "Addon_Key_003 (Eroded Token)",
            "Addon_Key_004 (Gold Token)",
            "Addon_Key_005 (Blood Amber)",
            "Addon_Key_006 (Milky Glass)",
            "Addon_Key_007 (Weaved Ring)",
            "Addon_Key_008 (Scratched Pearl)",
            "Addon_Map_001 (Map Addendum)",
            "Addon_Map_002 (Retardent Jelly)",
            "Addon_Map_003 (Glass Bead)",
            "Addon_Map_004 (Crystal Bead)",
            "Addon_Map_005 (Odd Stamp)",
            "Addon_Map_006 (Unusual Stamp)",
            "Addon_Map_007 (Black Silk Cord)",
            "Addon_Map_008 (Red Twine)",
            "Addon_Map_009 (Yellow Wire)",
            "Addon_Medkit_001 (Bandages)",
            "Addon_Medkit_002 (Gel Dressings)",
            "Addon_Medkit_003 (Medical Scissors)",
            "Addon_Medkit_004 (Butterfly Tape)",
            "Addon_Medkit_005 (Sponge)",
            "Addon_Medkit_006 (Rubber Gloves)",
            "Addon_Medkit_007 (Styptic Agent)",
            "Addon_Medkit_008 (Anti Hemorrhagic Syringe)",
            "Addon_Toolbox_001 (Scraps)",
            "Addon_Toolbox_002 (Wire Spool)",
            "Addon_Toolbox_003 (Clean Rag)",
            "Addon_Toolbox_004 (Grip Wrench)",
            "Addon_Toolbox_005 (Hacksaw)",
            "Addon_Toolbox_006 (Protective Gloves)",
            "Addon_Toolbox_007 (Brand New Part)",
            "Addon_Toolbox_008 (Instructions)"});
            this.list_box_addons_survivor.Location = new System.Drawing.Point(2, 2);
            this.list_box_addons_survivor.Name = "list_box_addons_survivor";
            this.list_box_addons_survivor.Size = new System.Drawing.Size(569, 303);
            this.list_box_addons_survivor.TabIndex = 5;
            this.list_box_addons_survivor.SelectedIndexChanged += new System.EventHandler(this.select_item);
            // 
            // tab_killer_addons
            // 
            this.tab_killer_addons.Controls.Add(this.list_box_addons_killer);
            this.tab_killer_addons.Location = new System.Drawing.Point(4, 22);
            this.tab_killer_addons.Name = "tab_killer_addons";
            this.tab_killer_addons.Size = new System.Drawing.Size(575, 306);
            this.tab_killer_addons.TabIndex = 3;
            this.tab_killer_addons.Text = "Addons Killer";
            this.tab_killer_addons.UseVisualStyleBackColor = true;
            // 
            // list_box_addons_killer
            // 
            this.list_box_addons_killer.FormattingEnabled = true;
            this.list_box_addons_killer.Items.AddRange(new object[] {
            "ADDON_Bell_AllseeingSpirit",
            "ADDON_Bell_AllseeingWhite",
            "ADDON_Bell_BlindBlood",
            "ADDON_Bell_BlindSpirit",
            "ADDON_Bell_BlindWhite",
            "ADDON_Bell_CoxcombedClapper",
            "ADDON_Bell_SwiftMud",
            "ADDON_Bell_WindstormBlood",
            "ADDON_Chainsaw_CarburatorGuide",
            "ADDON_Chainsaw_DeathEngravings",
            "ADDON_Chainsaw_DoomEngravings",
            "ADDON_Chainsaw_HomemadeMuffler",
            "ADDON_Chainsaw_LightChassis",
            "ADDON_Chainsaw_ThompsonMix",
            "ADDON_Chainsaw_ThompsonMoonshine",
            "Addon_DreamInducer_BlackBox",
            "Addon_DreamInducer_BlueDress",
            "Addon_DreamInducer_CatBlock",
            "Addon_DreamInducer_ClassPhoto",
            "Addon_DreamInducer_GardenRake",
            "Addon_DreamInducer_GreenDress",
            "Addon_DreamInducer_JumpRope",
            "Addon_DreamInducer_KidsDrawing",
            "Addon_DreamInducer_NancysMasterpiece",
            "Addon_DreamInducer_NancysSketch",
            "Addon_DreamInducer_PillBottle",
            "Addon_DreamInducer_PrototypeClaws",
            "Addon_DreamInducer_RedPaintBrush",
            "Addon_DreamInducer_Rope",
            "Addon_DreamInducer_SheepBlock",
            "Addon_DreamInducer_SwingChains",
            "Addon_DreamInducer_UnicornBlock",
            "Addon_DreamInducer_WoolShirt",
            "Addon_DreamInducer_ZBlock",
            "Addon_DreamInducer_PaintThinner",
            "ADDON_LFChainsaw_AwardWinningChili",
            "ADDON_LFChainsaw_BeastsMarks",
            "ADDON_LFChainsaw_BegrimedChain",
            "ADDON_LFChainsaw_CarburatorGuide",
            "ADDON_LFChainsaw_ChainsawFile",
            "ADDON_LFChainsaw_Chili",
            "ADDON_LFChainsaw_DepthGaugeRake",
            "ADDON_LFChainsaw_GrislyChains",
            "ADDON_LFChainsaw_HomemadeMuffler",
            "ADDON_LFChainsaw_KnifeScratches",
            "ADDON_LFChainsaw_LightChassis",
            "ADDON_LFChainsaw_LongGuideBar",
            "ADDON_LFChainsaw_PrimerBulb",
            "ADDON_LFChainsaw_RustedChain",
            "ADDON_LFChainsaw_ShopLubricant",
            "ADDON_LFChainsaw_SparkPlug",
            "ADDON_LFChainsaw_SpeedLimiter",
            "ADDON_LFChainsaw_TheGrease",
            "ADDON_LFChainsaw_VegetableOil",
            "ADDON_Lastbreath_AtaxicRespiration",
            "ADDON_Lastbreath_BadManLastBreath",
            "ADDON_Lastbreath_DullBracelet",
            "ADDON_Lastbreath_HeavyPanting",
            "ADDON_Lastbreath_JennerLastBreath",
            "ADDON_Lastbreath_KavanaghLastBreath",
            "ADDON_Lastbreath_Matchbox",
            "ADDON_Lastbreath_SpasmodicBreath",
            "ADDON_trap_BloodyCoil",
            "ADDON_trap_DiamondStone",
            "ADDON_trap_OilyCoil",
            "ADDON_trap_RustedJaw",
            "ADDON_trap_StitchedBag",
            "ADDON_trap_TrapSetters",
            "Addon_Beartrap_001 (Honing Stone)",
            "Addon_Beartrap_002 (Serrated Jaws)",
            "Addon_Beartrap_003 (Trapper Bag)",
            "Addon_Beartrap_004 (Wax Brick)",
            "Addon_Beartrap_005 (Logwood Dye)",
            "Addon_Beartrap_006 (Tar Bottle)",
            "Addon_Beartrap_007 (Strong Coil-Spring)",
            "Addon_Beartrap_008 (4-Coil Spring Kit)",
            "Addon_Beartrap_009 (Setting Tools)",
            "Addon_Beartrap_010 (Trapper Gloves)",
            "Addon_Beartrap_011 (Secondary Coil)",
            "Addon_Beartrap_012 (Fastening Tools)",
            "Addon_Bell_001 (Bone Clapper)",
            "Addon_Bell_002 (The Ghost - Soot)",
            "Addon_Bell_003 (Blind Warrior - Soot)",
            "Addon_Bell_004 (Blind Warrior - Mud)",
            "Addon_Bell_005 (Swift Hunt - Soot)",
            "Addon_Bell_006 (Swift Hunt - White)",
            "Addon_Bell_007 (All Seeing - Mud)",
            "Addon_Bell_008 (All Seeing - Blood)",
            "Addon_Bell_009 (Windstorm - Soot)",
            "Addon_Bell_010 (Windstorm - Mud)",
            "Addon_Bell_011 (Blink - Soot)",
            "Addon_Bell_012 (Blink - Mud)",
            "Addon_Blinker_001 (Plaid Flannel)",
            "Addon_Blinker_002 (White Nit Comb)",
            "Addon_Blinker_003 (Pocket Watch)",
            "Addon_Blinker_004 (Anxious Gasp)",
            "Addon_Blinker_005 (Torn Bookmark)",
            "Addon_Blinker_006 (Dark Cincture)",
            "Addon_Blinker_007 (Fragile Wheeze)",
            "Addon_Blinker_008 (Campbells Last Breath)",
            "Addon_Blinker_009 (Metal Spoon)",
            "Addon_Blinker_010 (Bad Man Keepsake)",
            "Addon_Blinker_011 (Wooden Horse)",
            "Addon_Blinker_012 (Catatonic Boys Treasure)",
            "Addon_Chainsaw_001 (Spiked Boots)",
            "Addon_Chainsaw_002 (Long Guide Bar)",
            "Addon_Chainsaw_003 (Spark Plug)",
            "Addon_Chainsaw_004 (Primer Bulb)",
            "Addon_Chainsaw_005 (Vegetable Oil)",
            "Addon_Chainsaw_006 (Shop Lubricant)",
            "Addon_Chainsaw_007 (Depth Gauge Rake)",
            "Addon_Chainsaw_008 (Grisly Chain)",
            "Addon_Chainsaw_009 (Begrimed Chain)",
            "Addon_Chainsaw_010 (Rusted Chain)",
            "Addon_Chainsaw_011 (Speed Limiter)",
            "Addon_Chainsaw_012 (Chainsaw File)",
            "Addon_Hatchet_AmanitaToxin",
            "Addon_Hatchet_BandagedHaft",
            "Addon_Hatchet_BegrimedHead",
            "Addon_Hatchet_BerusToxin",
            "Addon_Hatchet_CoarseStone",
            "Addon_Hatchet_DeerskinGloves",
            "Addon_Hatchet_FineStone",
            "Addon_Hatchet_FlowerBabushka",
            "Addon_Hatchet_GlowingConcoction",
            "Addon_Hatchet_InfantryBelt",
            "Addon_Hatchet_IridescentHead",
            "Addon_Hatchet_LeatherLoop",
            "Addon_Hatchet_MannaGrassBraid",
            "Addon_Hatchet_OakHaft",
            "Addon_Hatchet_PungentFiale",
            "Addon_Hatchet_RustyHead",
            "Addon_Hatchet_ShinyPin",
            "Addon_Hatchet_VenomousConcoction",
            "Addon_Hatchet_YewSeedBrew",
            "Addon_Hatchet_YewSeedConcoction",
            "Addon_PhantomTrap_BloodiedMud",
            "Addon_PhantomTrap_BloodiedWater",
            "Addon_PhantomTrap_BogWater",
            "Addon_PhantomTrap_CrackedTurtleEgg",
            "Addon_PhantomTrap_CypressNecklet",
            "Addon_PhantomTrap_DeadFlyMud",
            "Addon_PhantomTrap_DisfiguredEar",
            "Addon_PhantomTrap_DragonflyWings",
            "Addon_PhantomTrap_DriedCicada",
            "Addon_PhantomTrap_GranmasHeart",
            "Addon_PhantomTrap_HalfEggshell",
            "Addon_PhantomTrap_MintRag",
            "Addon_PhantomTrap_PowderedEggshell",
            "Addon_PhantomTrap_PussyWillowCatkins",
            "Addon_PhantomTrap_RopeNecklet",
            "Addon_PhantomTrap_RustyShackles",
            "Addon_PhantomTrap_ScarredHand",
            "Addon_PhantomTrap_SwampOrchidNecklet",
            "Addon_PhantomTrap_WaterloggedShoe",
            "Addon_PhantomTrap_WillowWreath",
            "Addon_Spark_CalmClassI",
            "Addon_Spark_CalmClassII",
            "Addon_Spark_CalmMuYisNotes",
            "Addon_Spark_DisciplineClassII",
            "Addon_Spark_DisciplineClassIII",
            "Addon_Spark_DisciplineMuYisNotes",
            "Addon_Spark_HighStimulusElectrode",
            "Addon_Spark_IridescentGeneral",
            "Addon_Spark_JadeCharm",
            "Addon_Spark_MoldyElectrode",
            "Addon_Spark_NanmuCatapult",
            "Addon_Spark_Obedience_MuYisNotes",
            "Addon_Spark_OrderClassI",
            "Addon_Spark_OrderClassII",
            "Addon_Spark_OrderMuYisNotes",
            "Addon_Spark_PolishedElectrode",
            "Addon_Spark_RestraintClassII",
            "Addon_Spark_RestraintClassIII",
            "Addon_Spark_RestraintMuYisNotes",
            "Addon_Spark_TigerFangCharm",
            "Addon_Stalker_BlondHair",
            "Addon_Stalker_BoyfriendsMemo",
            "Addon_Stalker_DeadRabbit",
            "Addon_Stalker_FragrantTuftOfHair",
            "Addon_Stalker_GlassFragment",
            "Addon_Stalker_HairBow",
            "Addon_Stalker_HairBrush",
            "Addon_Stalker_JMyersMemorial",
            "Addon_Stalker_Jewelry",
            "Addon_Stalker_JewelryBox",
            "Addon_Stalker_JudithsJournal",
            "Addon_Stalker_JudithsTombstone",
            "Addon_Stalker_LockOfHair",
            "Addon_Stalker_MemorialFlower",
            "Addon_Stalker_MirrorShard",
            "Addon_Stalker_ReflectiveFragment",
            "Addon_Stalker_ScratchedMirror",
            "Addon_Stalker_TackyEarrings",
            "Addon_Stalker_TombstonePiece",
            "Addon_Stalker_VanityMirror"});
            this.list_box_addons_killer.Location = new System.Drawing.Point(2, 2);
            this.list_box_addons_killer.Name = "list_box_addons_killer";
            this.list_box_addons_killer.Size = new System.Drawing.Size(569, 303);
            this.list_box_addons_killer.TabIndex = 5;
            this.list_box_addons_killer.SelectedIndexChanged += new System.EventHandler(this.select_item);
            // 
            // tab_survivor_perks
            // 
            this.tab_survivor_perks.Controls.Add(this.list_box_perks_survivor);
            this.tab_survivor_perks.Location = new System.Drawing.Point(4, 22);
            this.tab_survivor_perks.Name = "tab_survivor_perks";
            this.tab_survivor_perks.Size = new System.Drawing.Size(575, 306);
            this.tab_survivor_perks.TabIndex = 4;
            this.tab_survivor_perks.Text = "Perks Survivor";
            this.tab_survivor_perks.UseVisualStyleBackColor = true;
            // 
            // list_box_perks_survivor
            // 
            this.list_box_perks_survivor.FormattingEnabled = true;
            this.list_box_perks_survivor.Items.AddRange(new object[] {
            "Ace_In_The_Hole",
            "Ace_In_The_Hole_TEACH_",
            "Adrenaline",
            "Adrenaline_TEACH_",
            "Alert",
            "Alert_TEACH_",
            "Balanced_Landing",
            "Balanced_Landing_TEACH_",
            "Bond",
            "Bond_TEACH_",
            "BorrowedTime",
            "BorrowedTime_TEACH_",
            "Botany_Knowledge",
            "Botany_Knowledge_TEACH_",
            "Calm_Spirit",
            "Calm_Spirit_TEACH_",
            "Dark_Sense",
            "Dark_Sense_TEACH_",
            "DeadHard",
            "DeadHard_TEACH_",
            "DecisiveStrike",
            "DecisiveStrike_TEACH_",
            "Deja_Vu",
            "Deja_Vu_TEACH_",
            "Empathy",
            "Empathy_TEACH_",
            "Hope",
            "Hope_TEACH_",
            "Iron_Will",
            "Iron_Will_TEACH_",
            "Kindred",
            "Kindred_TEACH_",
            "Last_Standing",
            "Last_Standing_TEACH_",
            "Leader",
            "Leader_TEACH_",
            "LeftBehind",
            "LeftBehind_TEACH_",
            "Lightweight",
            "Lightweight_TEACH_",
            "Lithe",
            "Lithe_TEACH_",
            "NoMither",
            "NoMither_TEACH_",
            "No_One_Left_Behind",
            "No_One_Left_Behind_TEACH_",
            "ObjectOfObsession",
            "ObjectOfObsession_TEACH_",
            "Open_Handed",
            "Open_Handed_TEACH_",
            "Pharmacy",
            "Pharmacy_TEACH_",
            "Plunderers_Instinct",
            "Plunderers_Instinct_TEACH_",
            "Premonition",
            "Premonition_TEACH_",
            "Prove_Thyself",
            "Prove_Thyself_TEACH_",
            "QuickQuiet",
            "QuickQuiet_TEACH_",
            "Resilience",
            "Resilience_TEACH_",
            "Saboteur",
            "Saboteur_TEACH_",
            "SelfSufficient",
            "SelfSufficient_TEACH_",
            "Self_Care",
            "Self_Care_TEACH_",
            "Slippery_Meat",
            "Slippery_Meat_TEACH_",
            "Small_Game",
            "Small_Game_TEACH_",
            "SoleSurvivor",
            "SoleSurvivor_TEACH_",
            "Spine_Chill",
            "Spine_Chill_TEACH_",
            "Sprint_Burst",
            "Sprint_Burst_TEACH_",
            "Streetwise",
            "Streetwise_TEACH_",
            "Technician",
            "Technician_TEACH_",
            "This_Is_Not_Happening",
            "This_Is_Not_Happening_TEACH_",
            "Up_The_Ante",
            "Up_The_Ante_TEACH_",
            "Urban_Evasion",
            "Urban_Evasion_TEACH_",
            "Vigil",
            "Vigil_TEACH_",
            "WakeUp",
            "WakeUp_TEACH_",
            "WellMakeIt",
            "WellMakeIt_TEACH_",
            "WereGonnaLiveForever",
            "WereGonnaLiveForever_TEACH_"});
            this.list_box_perks_survivor.Location = new System.Drawing.Point(2, 2);
            this.list_box_perks_survivor.Name = "list_box_perks_survivor";
            this.list_box_perks_survivor.Size = new System.Drawing.Size(569, 303);
            this.list_box_perks_survivor.TabIndex = 5;
            this.list_box_perks_survivor.SelectedIndexChanged += new System.EventHandler(this.select_item);
            // 
            // tab_killer_perks
            // 
            this.tab_killer_perks.Controls.Add(this.list_box_perks_killer);
            this.tab_killer_perks.Location = new System.Drawing.Point(4, 22);
            this.tab_killer_perks.Name = "tab_killer_perks";
            this.tab_killer_perks.Size = new System.Drawing.Size(575, 306);
            this.tab_killer_perks.TabIndex = 5;
            this.tab_killer_perks.Text = "Perks Killer";
            this.tab_killer_perks.UseVisualStyleBackColor = true;
            // 
            // list_box_perks_killer
            // 
            this.list_box_perks_killer.FormattingEnabled = true;
            this.list_box_perks_killer.Items.AddRange(new object[] {
            "Agitation",
            "Agitation_TEACH_",
            "BBQAndChilli",
            "BBQAndChilli_TEACH_",
            "BeastOfPrey",
            "BeastOfPrey_TEACH_",
            "Bitter_Murmur",
            "Bitter_Murmur_TEACH_",
            "Bloodhound",
            "Bloodhound_TEACH_",
            "BloodWarden",
            "BloodWarden_TEACH_",
            "Brutal_Strength",
            "Brutal_Strength_TEACH_",
            "Deerstalker",
            "Deerstalker_TEACH_",
            "Distressing",
            "Distressing_TEACH_",
            "Dying_Light",
            "Dying_Light_TEACH_",
            "Enduring",
            "Enduring_TEACH_",
            "FireUp",
            "FireUp_TEACH_",
            "FranklinsLoss",
            "FranklinsLoss_TEACH_",
            "GeneratorOvercharge",
            "GeneratorOvercharge_TEACH_",
            "Hex_Devour_Hope",
            "Hex_Devour_Hope_TEACH_",
            "Hex_HuntressLullaby",
            "Hex_HuntressLullaby_TEACH_",
            "Hex_Ruin",
            "Hex_Ruin_TEACH_",
            "Hex_The_Third_Seal",
            "Hex_The_Third_Seal_TEACH_",
            "Hex_Thrill_Of_The_Hunt",
            "Hex_Thrill_Of_The_Hunt_TEACH_",
            "Insidious",
            "Insidious_TEACH_",
            "InTheDark (Knock Out)",
            "InTheDark_TEACH_ (Knock Out)",
            "Iron_Grasp",
            "Iron_Grasp_TEACH_",
            "Lightborn",
            "Lightborn_TEACH_",
            "MonitorAndAbuse",
            "MonitorAndAbuse_TEACH_",
            "Monstrous_Shrine",
            "Monstrous_Shrine_TEACH_",
            "No_One_Escapes_Death",
            "No_One_Escapes_Death_TEACH_",
            "NurseCalling",
            "NurseCalling_TEACH_",
            "OverwhelmingPresence",
            "OverwhelmingPresence_TEACH_",
            "Play_With_Your_Food",
            "Play_With_Your_Food_TEACH_",
            "Predator",
            "Predator_TEACH_",
            "RememberMe",
            "RememberMe_TEACH_",
            "Save_The_Best_For_Last",
            "Save_The_Best_For_Last_TEACH_",
            "Shadowborn",
            "Shadowborn_TEACH_",
            "Sloppy_Butcher",
            "Sloppy_Butcher_TEACH_",
            "Spies_From_The_Shadows",
            "Spies_From_The_Shadows_TEACH_",
            "Stridor",
            "Stridor_TEACH_",
            "TerritorialImperative",
            "TerritorialImperative_TEACH_",
            "Thanatophobia",
            "Thanatophobia_TEACH_",
            "Tinkerer",
            "Tinkerer_TEACH_",
            "Unnerving_Presence",
            "Unnerving_Presence_TEACH_",
            "Unrelenting",
            "Unrelenting_TEACH_",
            "Whispers",
            "Whispers_TEACH_"});
            this.list_box_perks_killer.Location = new System.Drawing.Point(2, 2);
            this.list_box_perks_killer.Name = "list_box_perks_killer";
            this.list_box_perks_killer.Size = new System.Drawing.Size(569, 303);
            this.list_box_perks_killer.TabIndex = 5;
            this.list_box_perks_killer.SelectedIndexChanged += new System.EventHandler(this.select_item);
            // 
            // tab_offerings
            // 
            this.tab_offerings.Controls.Add(this.list_box_offerings);
            this.tab_offerings.Location = new System.Drawing.Point(4, 22);
            this.tab_offerings.Name = "tab_offerings";
            this.tab_offerings.Size = new System.Drawing.Size(575, 306);
            this.tab_offerings.TabIndex = 6;
            this.tab_offerings.Text = "Offerings";
            this.tab_offerings.UseVisualStyleBackColor = true;
            // 
            // list_box_offerings
            // 
            this.list_box_offerings.FormattingEnabled = true;
            this.list_box_offerings.Items.AddRange(new object[] {
            "ArdentRavenWreath",
            "ArdentShrikeWreath",
            "ArdentSpottedowlWreath",
            "ArdentTanagerWreath",
            "AzarovKey",
            "BlackSaltStatuette",
            "BlackSplinter",
            "BlackWard",
            "BloodyPartyStreamers",
            "BogLaurelSachet",
            "BoneSplinter",
            "BoundEnvelope",
            "Cannibal",
            "CattleTag28",
            "ChalkPouch",
            "CharredWeddingPhotograph",
            "ChildrensBook",
            "ClearReagent",
            "ColdwindCattleTag81",
            "CreamChalkPouch",
            "CrescentMoonBouquet",
            "CrispleafAmaranthSachet",
            "CutCoin",
            "CypressMementoMori",
            "DecrepitClapboard",
            "DevoutRavenWreath",
            "DevoutShrikeWreath",
            "DevoutSpottedowlWreath",
            "DevoutTanagerWreath",
            "EbonyMementoMori",
            "EmergencyCertificate",
            "EscapeCake",
            "FaintReagent",
            "FragrantBogLaurel",
            "FragrantCrispleafAmaranth",
            "FragrantPrimroseBlossom",
            "FragrantSweetWilliam",
            "FreshBogLaurel",
            "FreshCrispleafAmaranth",
            "FreshPrimroseBlossom",
            "FreshSweetWilliam",
            "FullMoonBouquet",
            "FumingCordage",
            "FumingWelcomeSign",
            "GranmasCookbook",
            "HarvestFestivalLeaflet",
            "HazyReagent",
            "HeartLocket",
            "HollowShell",
            "IvoryChalkPouch",
            "IvoryMementoMori",
            "LunacyTicket",
            "MacMillanPhalanxBone",
            "MacmillanLedgerPage",
            "MoldyOak",
            "MuddySplinter",
            "MurkyReagent",
            "NewMoonBouquet",
            "PElliotLunacyTicket",
            "PaintedRiverRock",
            "PetrifiedOak",
            "PrimroseBlossomSachet",
            "PsychiatricAssessmentReport",
            "PutridOak",
            "QuarterMoonBouquet",
            "RavenWreath",
            "RottenOak",
            "SaltPouch",
            "ScratchedCoin",
            "SealedEnvelope",
            "ShatteredGlasses",
            "ShinyCoin",
            "ShockSplinter",
            "ShreddedPlate",
            "ShrikeWreath",
            "ShroudofBinding",
            "ShroudofSeparation",
            "ShroudofUnion",
            "SignedLedgerPage",
            "SpottedOwlWreath",
            "StrodeRealtyKey",
            "SurvivorPudding",
            "SweetWilliamSachet",
            "TanagerWreath",
            "TarnishedCoin",
            "TheLastMask",
            "ThePiedPiper",
            "VigosJarOfSaltyLips",
            "VigosShroud",
            "VirginiaPlate",
            "WhiteWard"});
            this.list_box_offerings.Location = new System.Drawing.Point(2, 2);
            this.list_box_offerings.Name = "list_box_offerings";
            this.list_box_offerings.Size = new System.Drawing.Size(569, 303);
            this.list_box_offerings.TabIndex = 0;
            // 
            // ItemForm
            // 
            this.AcceptButton = this.save_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(607, 403);
            this.Controls.Add(this.tab_control_create_items);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Item";
            this.tab_control_create_items.ResumeLayout(false);
            this.tab_manual.ResumeLayout(false);
            this.tab_manual.PerformLayout();
            this.tab_items.ResumeLayout(false);
            this.tab_survivor_addons.ResumeLayout(false);
            this.tab_killer_addons.ResumeLayout(false);
            this.tab_survivor_perks.ResumeLayout(false);
            this.tab_killer_perks.ResumeLayout(false);
            this.tab_offerings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox input_fld;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab_control_create_items;
        private System.Windows.Forms.TabPage tab_manual;
        private System.Windows.Forms.TabPage tab_items;
        private System.Windows.Forms.TabPage tab_survivor_addons;
        private System.Windows.Forms.TabPage tab_killer_addons;
        private System.Windows.Forms.TabPage tab_survivor_perks;
        private System.Windows.Forms.TabPage tab_killer_perks;
        private System.Windows.Forms.TabPage tab_offerings;
        private System.Windows.Forms.ListBox list_box_items_survivor;
        private System.Windows.Forms.ListBox list_box_addons_survivor;
        private System.Windows.Forms.ListBox list_box_addons_killer;
        private System.Windows.Forms.ListBox list_box_perks_survivor;
        private System.Windows.Forms.ListBox list_box_perks_killer;
        private System.Windows.Forms.ListBox list_box_offerings;
    }
}