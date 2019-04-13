/* Ultimate True Random Map
** Made by Hagrit and DaCoda
** 
** DaCoda: Have fun reading this
** 
*/

string GetNormalWalkableTerrainType()
{
	int TerrainType = rmRandInt(0,49);
	switch (TerrainType)
	{		
		case 0: return ("CityTileA");
		case 1: return ("CityTileAtlantis");
		case 2: return ("CityTileAtlantiscoral");
		case 3: return ("CliffGreekB");
		case 4: return ("CliffEgyptianB");
		case 5: return ("CliffNorseB");
		case 6: return ("DirtA");
		case 7: return ("EgyptianRoadA");
		case 8: return ("GrassA");
		case 9: return ("GrassB");
		case 10: return ("GrassDirt25");
		case 11: return ("GrassDirt50");
		case 12: return ("GrassDirt75");
		case 13: return ("GreekRoad_BurntA");
		case 14: return ("GreekRoad_BurntB");
		case 15: return ("GreekRoadA");
		case 16: return ("Hadesbuildable1");
		case 17: return ("Hadesbuildable2");
		case 18: return ("MarshA");
		case 19: return ("MarshB");
		case 20: return ("MarshC");
		case 21: return ("MarshD");
		case 22: return ("MarshE");
		case 23: return ("NorseRoadA");
		case 24: return ("OlympusA");
		case 25: return ("OlympusB");
		case 26: return ("OlympusC");  //case 27: return ("OlympusTile");  Feck you @Nilla -Hagrit
		case 27: return ("SandA");
		case 28: return ("SandB");
		case 29: return ("SandC");
		case 30: return ("SandD");
		case 31: return ("SandDirt50");
		case 32: return ("SandDirt50b");
		case 33: return ("SavannahA");
		case 34: return ("SavannahB");
		case 35: return ("SavannahC");
		case 36: return ("SavannahD");
		case 37: return ("SnowA");
		case 38: return ("SnowB");
		case 39: return ("SnowGrass25");
		case 40: return ("SnowGrass50");
		case 41: return ("SnowGrass75");
		case 42: return ("SnowSand25");
		case 43: return ("SnowSand50");
		case 44: return ("SnowSand75");
		case 45: return ("TundraGrassA");
		case 46: return ("TundraGrassB");
		case 47: return ("TundraRockA");
		case 48: return ("TundraRockB");
	}
}

string GetInsaneWalkableTerrainType()
{
	int TerrainType = rmRandInt(0,76);
	switch (TerrainType)
	{
		case 1: return ("CityTileWaterPool");
		case 2: return ("CityTileWaterEdgeA");
		case 3: return ("CityTileWaterEdgeB");
		case 4: return ("CityTileWaterEdgeEndA");
		case 5: return ("CityTileWaterEdgeEndB");
		case 6: return ("CityTileWaterEdgeEndC");
		case 7: return ("CityTileWaterEdgeEndD");
		case 8: return ("CityTileWaterCornerA");
		case 9: return ("CityTileWaterCornerB");
		case 10: return ("CityTileWaterCornerC");
		case 11: return ("CityTileWaterCornerD");
		case 12: return ("coralA");
		case 13: return ("coralB");
		case 14: return ("coralC");
		case 15: return ("coralD");
		case 16: return ("coralE");
		case 17: return ("coralF");
		case 18: return ("ForestfloorDeadPine");
		case 19: return ("ForestfloorOak");
		case 20: return ("ForestfloorGaia");
		case 21: return ("ForestfloorMarsh");
		case 22: return ("ForestfloorPalm");
		case 23: return ("ForestfloorPine");
		case 24: return ("ForestfloorPineSnow");
		case 25: return ("ForestfloorSavannah");
		case 26: return ("ForestfloorTundra");
		case 27: return ("GaiaCreepA");
		case 28: return ("GaiaCreepASand");
		case 29: return ("GaiaCreepASnow");
		case 30: return ("GaiaCreepB");
		case 31: return ("GaiaCreepBorder");
		case 32: return ("GaiaCreepBorderSand");
		case 33: return ("GaiaCreepBorderSnow");
		case 34: return ("MarshF");
		case 35: return ("RiverSandyB");
		case 36: return ("RiverSandyC");
		case 37: return ("RiverSandyShallowA");
		case 38: return ("RiverGrassyA");
		case 39: return ("RiverGrassyB");
		case 40: return ("RiverGrassyC");
		case 41: return ("RiverIcyA");
		case 42: return ("RiverIcyB");
		case 43: return ("RiverIcyC");
		case 44: return ("RiverMarshA");
		case 45: return ("RiverMarshB");
		case 46: return ("RiverMarshC");
		case 47: return ("ShorelineAegeanA");
		case 48: return ("ShorelineAegeanB");
		case 49: return ("ShorelineAegeanC");
		case 50: return ("ShorelineAtlanticA");
		case 51: return ("ShorelineAtlanticB");
		case 52: return ("ShorelineAtlanticC");
		case 53: return ("ShorelineMediterraneanA");
		case 54: return ("ShorelineMediterraneanB");
		case 55: return ("ShorelineMediterraneanC");
		case 56: return ("ShorelineMediterraneanD");
		case 57: return ("ShorelineNorwegianA");
		case 58: return ("ShorelineNorwegianB");
		case 59: return ("ShorelineNorwegianC");
		case 60: return ("ShorelineRedSeaB");
		case 61: return ("ShorelineRedSeaA");
		case 62: return ("ShorelineRedSeaC");
		case 63: return ("ShorelineSandA");
		case 64: return ("ShorelineTundraA");
		case 65: return ("ShorelineTundraB");
		case 66: return ("ShorelineTundraC");
		case 67: return ("ShorelineTundraD");
		case 68: return ("UnderwaterIceA");
		case 69: return ("UnderwaterIceB");
		case 70: return ("UnderwaterIceC");
		case 71: return ("UnderwaterRockA");
		case 72: return ("UnderwaterRockB");
		case 73: return ("UnderwaterRockC");
		case 74: return ("UnderwaterRockD");
		case 75: return ("UnderwaterRockE");
		case 76: return ("UnderwaterRockF");	
	}
}

string GetWalkNotBuildableTerrain()
{
	int NotBuildable = rmRandInt(0,7);
	switch (NotBuildable)
	{
		case 0: return ("Hades1");
		case 1: return ("Hades2");
		case 2: return ("Hades8");
		case 3: return ("Hades9");
		case 4: return ("IceA");
		case 5: return ("IceB");
		case 6: return ("IceC");
		case 7: return ("MiningGround");
	}
}

string GetCliffType()
{
	int CliffType = rmRandInt(0,2);
	switch (CliffType)
	{
		case 0: return ("Greek");
		case 1: return ("Norse");
		case 2: return ("Egyptian");
		
		/// Hades cliff terrain tex isn't buildable
		/// which fucks around with Player Craters
		/// - DaCoda
		//case 4: return ("Hades"); 
	}
}



string GetRiverType()
{
	int RiverType = rmRandInt(0,6);
	switch (RiverType)
	{
		case 0: return ("Greek River");
		case 1: return ("Norse River");
		case 2: return ("Egyptian Nile");
		case 3: return ("Egyptian Nile Shallow");
		case 4: return ("Savannah Water Hole");
		case 5: return ("Styx River");
		case 6: return ("Watering Hole");
		case 7: return ("Tundra Pool");
		case 8: return ("Tundra");
		case 9: return ("Marsh Pool");
	}
}

string GetOceanType()
{
	int OceanType = rmRandInt(0,4);
	switch(OceanType)
	{
		case 0: return ("Mediterranean Sea");
		case 1: return ("Aegean Sea");
		case 2: return ("Red Sea");
		case 3: return ("North Atlantic Ocean");
		case 4: return ("Norwegian Sea");
	}
}

string GetForestType()
{
	int ForestType = rmRandInt(0,9);
	switch(ForestType)
	{
		case 0: return ("Pine Forest");
		case 1: return ("Snow Pine Forest");
		case 2: return ("Autumn Oak Forest");
		case 3: return ("Mixed Oak Forest");
		case 4: return ("Hades Forest");
		case 5: return ("Mixed Palm Forest");
		case 6: return ("Mixed Pine Forest");
		case 7: return ("Savannah Forest");
		case 8: return ("Marsh Forest");
		case 9: return ("Tundra Forest");
	}
}

string GetRandomTree()
{
	int Tree = rmRandInt(0,9);
	switch(Tree)
	{
		case 0: return ("Gaia Forest Tree");
		case 1: return ("Marsh Tree");
		case 2: return ("Oak Tree");
		case 3: return ("Savannah Tree");
		case 4: return ("Tundra Tree");
		case 5: return ("Pine");
		case 6: return ("Pine Dead");
		case 7: return ("Pine Snow");
		case 8: return ("Palm");
		case 9: return ("Oak Autumn");
	}
}

string GetLandAnimal()
{
	int Animal = rmRandInt(0,26);
	switch(Animal)
	{
		case 0: return ("Deer");
		case 1: return ("Elk");
		case 2: return ("Caribou");
		case 3: return ("Gazelle");
		case 4: return ("Giraffe");
		case 5: return ("Zebra");
		case 6: return ("Crowned Crane");
		case 7: return ("Baboon");
		case 8: return ("Monkey");
		case 9: return ("Boar");
		case 10: return ("Aurochs");
		case 11: return ("Water Buffalo");
		case 12: return ("Rhinocerous");
		case 13: return ("Hippo");
		case 14: return ("Elephant");
		case 15: return ("Walrus");
		case 16: return ("Lion");
		case 17: return ("Hyena");
		case 18: return ("Crocodile");
		case 19: return ("Bear");
		case 20: return ("Polar Bear");
		case 21: return ("Wolf");
		case 22: return ("Wolf Arctic");
		case 23: return ("Wolf Arctic 2");
		case 24: return ("Shade of Hades");
		case 25: return ("Serpent");
		case 26: return ("Walking berry bush");
	}
}

string GetHuntable()
{
	int Huntable = rmRandInt(0,15);
	switch(Huntable)
	{
		case 0: return ("Deer");
		case 1: return ("Elk");
		case 2: return ("Caribou");
		case 3: return ("Gazelle");
		case 4: return ("Giraffe");
		case 5: return ("Zebra");
		case 6: return ("Crowned Crane");
		case 7: return ("Baboon");
		case 8: return ("Monkey");
		case 9: return ("Boar");
		case 10: return ("Aurochs");
		case 11: return ("Water Buffalo");
		case 12: return ("Rhinocerous");
		case 13: return ("Hippo");
		case 14: return ("Elephant");
		case 15: return ("Walrus");
	}
}

string GetWeakHuntable()
{
	int WeakHuntable = rmRandInt(0,8);
	switch(WeakHuntable)
	{
		case 0: return ("Deer");
		case 1: return ("Elk");
		case 2: return ("Caribou");
		case 3: return ("Gazelle");
		case 4: return ("Giraffe");
		case 5: return ("Zebra");
		case 6: return ("Crowned Crane");
		case 7: return ("Baboon");
		case 8: return ("Monkey");
	}
}

string GetHerdable()
{
	int Herdable = rmRandInt(0,2);
	switch (Herdable)
	{
		case 0: return ("Pig");
		case 1: return ("Goat");
		case 2: return ("Cow");
	}
}

string GetPredator()
{
	int Predator = rmRandInt(0,10);
	switch (Predator)
	{
		case 0: return ("Lion");
		case 1: return ("Hyena");
		case 2: return ("Crocodile");
		case 3: return ("Bear");
		case 4: return ("Polar Bear");
		case 5: return ("Wolf");
		case 6: return ("Wolf Arctic");
		case 7: return ("Wolf Arctic 2");
		case 8: return ("Shade of Hades");
		case 9: return ("Serpent");
		case 10: return ("Walking berry bush");
	}
}

string GetOtherFood()
{
	if (rmRandInt(0,1) == 0)
		return ("Chicken");
	else return ("Berry bush");
}

string GetTowerType()
{
	int TowerType = rmRandInt(0,4);
	switch(TowerType)
	{
		case 0: return ("Tower");
		case 1: return ("Lighthouse");
		case 2: return ("Shrine");
		case 3: return ("Temple");
		case 4: return ("Tent");
	}
}

string GetFishType()
{
	int FishType = rmRandInt(0,2);
	switch(FishType)
	{
		case 0: return ("Fish - Mahi");
		case 1: return ("Fish - Perch");
		case 2: return ("Fish - Salmon");
	}
}

string GetLighting()
{
	int LightType = rmRandInt(0,9);
	switch(LightType)
	{
		case 0: return ("alfheim");
		case 1: return ("anatolia");
		case 2: return ("dawn");
		case 3: return ("default");
		case 4: return ("dusk");
		case 5: return ("eclipse");
		case 6: return ("erebus");
		case 7: return ("fimbulwinter");
		case 8: return ("ghost lake");
		case 9: return ("olympus");
	}
}

bool Chance(int Percentage = 0)
{
	return (rmRandInt(0,100) < Percentage);
}

void LandMap(void)
{	
	int PlayerTiles=rmRandInt(7000,8000);
	
	if(cMapSize == 1) {
		PlayerTiles = rmRandInt(9500,11500);
		rmEchoInfo("Large map");
	}
	
	int size=2.0*sqrt(cNumberNonGaiaPlayers*PlayerTiles);
	rmSetMapSize(size, size);
	/// INITIALIZE TERRAIN AS WATER
	rmTerrainInitialize(GetNormalWalkableTerrainType());
	rmSetLightingSet(GetLighting());
	/// Value that literally does nothing
	bool NothingAtAll = false;
	
	/// Info
	bool HasWater = false;
	
	/// WINDOWS CONTROL PANEL
	/// Land Kinds
	bool BuildCenterLake   	 = false;
	bool BuildCenterPlateau	 = false;
	bool BuildCliffMap		 = false;
	bool BuildPlayerCraters	 = false;
	bool BuildExtremeForests = false;
	bool BuildOasis			 = false;
	bool BuildSideWater		 = false;
	
	// Attribute Randomization
	bool BuildPlayerArea   		        = false;
    bool BuildPlayerCliffArea	        = false;
	bool BuildCliffs			        = Chance(20);
	bool GroundIsChaotic   		        = Chance(10);  //true;
	bool UseInsaneTextures 		        = Chance(5);
	bool MonsterRelics	   		        = Chance(5);
	bool BuildStartingSettlementCraters = false;
	bool BuildSettlementCraters         = Chance(5);
	bool ThirdSettlement				= Chance(5);
	bool StartingGoldIsLarge			= Chance(15);
	bool StartingGoldIsSmall			= Chance(5);
	bool Hesperides    					= Chance(5);
	bool ExtremeForests					= Chance(5);
	
	// Beautifucation Randomization 
	bool SpawnsBeautificationWaterPads = Chance(50);
	bool SpawnsBeautificationWaterWeed = Chance(50);
	bool SpawnsBeautificationLogs      = Chance(50);
	bool SpawnsBeautificationBush1     = Chance(50);
	bool SpawnsBeautificationBush2     = Chance(50);
	bool SpawnsBeautificationGrass     = Chance(50);
	bool SpawnsBeautificationRock      = Chance(50);
	bool SpawnsBeautificationRune      = Chance(50);
	bool SpawnsBeautificationFlowers   = Chance(50);
	bool SpawnsBeautificationDrift     = Chance(50);
	
	
	
	int LandKind = rmRandInt(0,7);
	switch (LandKind)
	{
		case 0: NothingAtAll 		= true;
		case 1: BuildCenterLake 	= true;
		case 2: BuildCenterPlateau  = true;
		case 3: BuildCliffMap 		= true;
		case 4: BuildPlayerCraters  = true;
		case 5: BuildExtremeForests = true;
		case 6: BuildOasis			= true;
		case 7: BuildSideWater		= true;
	}
	
	//
	int amountBeautyPatchesA = cNumberNonGaiaPlayers * 5;
	int amountElevPatchesA	 = cNumberNonGaiaPlayers * 3;
	int amountCliffsA		 = cNumberNonGaiaPlayers * rmRandInt(1,2);
	
	if (BuildCliffMap) {
		amountCliffsA		 = cNumberNonGaiaPlayers * rmRandInt(3,5);
	}
	
	float TowerChance = rmRandFloat(0,1);
	int forestCount = 0;
	
	if (GroundIsChaotic) {
		amountBeautyPatchesA = cNumberNonGaiaPlayers * rmRandInt(100,200);
		amountElevPatchesA 	 = cNumberNonGaiaPlayers * rmRandInt(10,20);
	}
	
	if (BuildCenterLake)
	{
		HasWater = true;
	}
	
	if (BuildCliffMap)
	{
	   int Cliffs = rmRandInt(0,2);
	   switch (Cliffs)
	   {
			case 0: BuildPlayerCliffArea = true;
			case 1: BuildCliffs = true;
			case 2: {
				BuildPlayerCliffArea = true;
				BuildCliffs = true;
			}
	   }
	   
	   // If we are going to build a
	   // Player cliff area we don't 
	   // want a normal player area
	   // to spawn in the map.
	   if (BuildPlayerCliffArea)
		   BuildPlayerArea = false;
	}
	
	if (BuildCenterLake || BuildCenterPlateau)
	{
		BuildPlayerArea = true;
	}
	
	if (BuildPlayerCraters) {
		BuildCliffs = Chance(10);
		BuildStartingSettlementCraters = Chance(80);
		BuildSettlementCraters = Chance(80);
	}
	
	if (BuildExtremeForests) {
		BuildCliffs = Chance(10);
		ExtremeForests = true;
	}
	
	if (NothingAtAll)
	{
		BuildPlayerArea = Chance(50);
	}
	
	if (BuildOasis)
	{
		BuildPlayerArea = Chance(50);
	}
	
	rmSetStatusText("",0.10);
	///CLASSES
	int classPlayer 	= rmDefineClass("player area");
	int classTower		= rmDefineClass("tower type");
	int classForest		= rmDefineClass("forest");
	int classSettlement	= rmDefineClass("starting settlement");
	int classCenter		= rmDefineClass("center core");
	int classPlateau	= rmDefineClass("center plateau");
	int classCliff		= rmDefineClass("cliff");
	int classCrater		= rmDefineClass("crater");
	int classPlayerCore	= rmDefineClass("player core");
	
	rmSetStatusText("",0.15);
	///CONSTRAINTS
	int AvoidEdgeLong	= rmCreateBoxConstraint	("CB0", rmXTilesToFraction(20), rmZTilesToFraction(20), 1.0-rmXTilesToFraction(20), 1.0-rmZTilesToFraction(20));
	int AvoidEdgeMed	= rmCreateBoxConstraint	("CB1", rmXTilesToFraction(4), rmZTilesToFraction(4), 1.0-rmXTilesToFraction(4), 1.0-rmZTilesToFraction(4));
	int AvoidEdgeShort	= rmCreateBoxConstraint	("CB2", rmXTilesToFraction(2), rmZTilesToFraction(2), 1.0-rmXTilesToFraction(2), 1.0-rmZTilesToFraction(2));

	int AvoidAll				= rmCreateTypeDistanceConstraint ("CT0", "all", 6.0);
	int AvoidFish				= rmCreateTypeDistanceConstraint ("CT1", "fish", 18.0);
	int AvoidFood				= rmCreateTypeDistanceConstraint ("CT2", "food", 15.0);
	int AvoidHunt				= rmCreateTypeDistanceConstraint ("CT3", "huntable", 20.0);
	int AvoidSettlementSlightly = rmCreateTypeDistanceConstraint ("CT4", "AbstractSettlement", 10.0);
	int AvoidSettlementAbit		= rmCreateTypeDistanceConstraint ("CT5", "AbstractSettlement", 20.0);
	int AvoidSettlementSomewhat = rmCreateTypeDistanceConstraint ("CT6", "AbstractSettlement", 32.0);
	int AvoidGold				= rmCreateTypeDistanceConstraint ("CT7", "gold", 25.0);
	int AvoidHerdable			= rmCreateTypeDistanceConstraint ("CT8", "herdable", 20.0);
	int AvoidPredator			= rmCreateTypeDistanceConstraint ("CT9", "animalPredator", 20.0);
	int AvoidRelic				= rmCreateTypeDistanceConstraint ("CT10", "relic", 50.0);
	int AvoidAllLong			= rmCreateTypeDistanceConstraint ("CT11", "all", 8.0);
	
	int AvoidPlayerShort		= rmCreateClassDistanceConstraint ("CC0", classPlayer, 1.0);
	int AvoidTower				= rmCreateClassDistanceConstraint ("CC1", classTower, 20.0);
	int AvoidForest				= rmCreateClassDistanceConstraint ("CC2", classForest, rmRandInt(15.0,25.0));
	int AvoidStartingSettle		= rmCreateClassDistanceConstraint ("CC3", classSettlement, rmRandInt(15.0,20.0));
	int AvoidStartingSettleMed	= rmCreateClassDistanceConstraint ("CC4", classSettlement, 40.0);
	int AvoidCenter				= rmCreateClassDistanceConstraint ("CC5", classCenter, 30.0);
	int AvoidPlateau			= rmCreateClassDistanceConstraint ("CC6", classPlateau, 10.0);
	int AvoidCliff				= rmCreateClassDistanceConstraint ("CC7", classCliff, 20.0);
	int AvoidPlayerMed			= rmCreateClassDistanceConstraint ("CC8", classPlayer, 5.0);
	int AvoidCrater				= rmCreateClassDistanceConstraint ("CC9", classCrater, 6.0);
	int AvoidForestShort		= rmCreateClassDistanceConstraint ("CC10", classForest, rmRandInt(12.0,18.0));
	int AvoidStartingSettleLong	= rmCreateClassDistanceConstraint ("CC11", classSettlement, 80.0);
	int AvoidPlayerCore			= rmCreateClassDistanceConstraint ("CC12", classPlayerCore, 20.0);
	
	int AvoidImpassableLand		= rmCreateTerrainDistanceConstraint("CTR1", "land", false, 8.0);
	int AvoidImpassableLandFar	= rmCreateTerrainDistanceConstraint("CTR2", "land", false, 15.0);
	int AvoidShore				= rmCreateTerrainDistanceConstraint("CTR3", "land", true, 9.0);
	
	int NearShore			= rmCreateTerrainMaxDistanceConstraint("CTM1", "land", true, 12.0);
	
	rmSetStatusText("",0.25);
	///OBJECT DEFINITION
	//Starting objects
	int IDStartingSettlement 	= rmCreateObjectDef("starting settlement");
	rmAddObjectDefItem			(IDStartingSettlement, "Settlement Level 1", 1, 0.0);
	rmSetObjectDefMinDistance	(IDStartingSettlement, 0.0);
	rmSetObjectDefMaxDistance	(IDStartingSettlement, 0.0);
	rmAddObjectDefToClass    	(IDStartingSettlement, classSettlement);
	
	int GoldDistance = rmRandInt(10,32);
	
	int IDStartingGold		 	= rmCreateObjectDef("starting gold");
	
	if (StartingGoldIsSmall) { 
		rmAddObjectDefItem		(IDStartingGold, "gold mine tiny", 1, 0.0);
	} else if (StartingGoldIsLarge) {
		rmAddObjectDefItem		(IDStartingGold, "gold mine", 1, 0.0);
	} else 
		rmAddObjectDefItem		(IDStartingGold, "gold mine small", 1, 0.0);
	
	rmSetObjectDefMinDistance	(IDStartingGold, GoldDistance);
	rmSetObjectDefMaxDistance	(IDStartingGold, GoldDistance);
	rmAddObjectDefConstraint	(IDStartingGold, AvoidAll);
	rmAddObjectDefConstraint	(IDStartingGold, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDStartingGold, AvoidImpassableLand);
	
	int IDStartingTower		 	= rmCreateObjectDef("starting tower");
	rmAddObjectDefItem       	(IDStartingTower, "Tower", 1, 0.0);
	rmSetObjectDefMinDistance	(IDStartingTower, 20.0);
	
	if (BuildPlayerCraters) {
		rmSetObjectDefMaxDistance	(IDStartingTower, 25.0);
	} else 
	rmSetObjectDefMaxDistance	(IDStartingTower, 30.0);
	
	rmAddObjectDefToClass    	(IDStartingTower, classTower);
	rmAddObjectDefConstraint	(IDStartingTower, AvoidTower);
	rmAddObjectDefConstraint	(IDStartingTower, AvoidAll);
	rmAddObjectDefConstraint	(IDStartingTower, AvoidEdgeShort);
	
	int IDStartingHunt		 	= rmCreateObjectDef("starting hunt");
	rmAddObjectDefItem       	(IDStartingHunt, GetHuntable(), rmRandInt(1,9), 4.0);
	rmSetObjectDefMinDistance	(IDStartingHunt, 20.0);
	rmSetObjectDefMaxDistance	(IDStartingHunt, 26.0);
	rmAddObjectDefConstraint	(IDStartingHunt, AvoidAll);
	rmAddObjectDefConstraint	(IDStartingHunt, AvoidEdgeShort);
	
	int IDStartingFood		 	= rmCreateObjectDef("starting food");
	rmAddObjectDefItem       	(IDStartingFood, GetOtherFood(), rmRandInt(1,12), 4.0);
	rmSetObjectDefMinDistance	(IDStartingFood, 20.0);
	rmSetObjectDefMaxDistance	(IDStartingFood, 26.0);
	rmAddObjectDefConstraint	(IDStartingFood, AvoidAll);
	rmAddObjectDefConstraint	(IDStartingFood, AvoidEdgeShort);
	
	int IDStartingAnimal	 	= rmCreateObjectDef("starting animal");
	rmAddObjectDefItem       	(IDStartingAnimal, GetLandAnimal(), rmRandInt(1,3), 4.0);
	rmSetObjectDefMinDistance	(IDStartingAnimal, 20.0);
	rmSetObjectDefMaxDistance	(IDStartingAnimal, 30.0);
	rmAddObjectDefConstraint	(IDStartingAnimal, AvoidAll); 
	rmAddObjectDefConstraint	(IDStartingAnimal, AvoidEdgeShort); 
	
	int IDStartingHerd		 	= rmCreateObjectDef("starting herd");
	rmAddObjectDefItem       	(IDStartingHerd, GetHerdable(), rmRandInt(1,6), 4.0);
	rmSetObjectDefMinDistance	(IDStartingHerd, 20.0);
	rmSetObjectDefMaxDistance	(IDStartingHerd, 30.0);
	rmAddObjectDefConstraint	(IDStartingHerd, AvoidAll); 
	rmAddObjectDefConstraint	(IDStartingHerd, AvoidEdgeShort); 
	
	int IDStartingTower2	 	= rmCreateObjectDef("starting tower 2");
	rmAddObjectDefItem       	(IDStartingTower2, GetTowerType(), 1, 0.0);
	rmSetObjectDefMinDistance	(IDStartingTower2, 20.0);
	
	if (BuildPlayerCraters) {
		rmSetObjectDefMaxDistance	(IDStartingTower2, 25.0);
	} else 
		rmSetObjectDefMaxDistance	(IDStartingTower2, 28.0);

	rmAddObjectDefToClass    	(IDStartingTower2, classTower);
	rmAddObjectDefConstraint	(IDStartingTower2, AvoidTower);
	rmAddObjectDefConstraint	(IDStartingTower2, AvoidAll);
	rmAddObjectDefConstraint	(IDStartingTower2, AvoidCenter);
	rmAddObjectDefConstraint	(IDStartingTower2, AvoidImpassableLand);
	rmAddObjectDefConstraint	(IDStartingTower2, AvoidEdgeShort);
	
	int IDStandardFish		 	= rmCreateObjectDef("fish");
	rmAddObjectDefItem       	(IDStandardFish, GetFishType(), 3, 8.0);
	rmSetObjectDefMinDistance	(IDStandardFish, 30.0);
	rmSetObjectDefMaxDistance	(IDStandardFish, 250.0);
	rmAddObjectDefConstraint	(IDStandardFish, AvoidFish);
	rmAddObjectDefConstraint	(IDStandardFish, AvoidShore);
	
	int IDStragglerTree			= rmCreateObjectDef("straggler trees");
	rmAddObjectDefItem			(IDStragglerTree, GetRandomTree(), 1, 0.0);
	rmSetObjectDefMinDistance	(IDStragglerTree, 10.0);
	rmSetObjectDefMaxDistance	(IDStragglerTree, 18.0);
	
	int IDRandomTree			= rmCreateObjectDef("random trees");
	rmAddObjectDefItem			(IDRandomTree, GetRandomTree(), 1, 0.0);
	rmSetObjectDefMinDistance	(IDRandomTree, 0.0);
	rmSetObjectDefMaxDistance	(IDRandomTree, rmXFractionToMeters(0.5));
	rmAddObjectDefConstraint	(IDRandomTree, AvoidAll);
	rmAddObjectDefConstraint	(IDRandomTree, AvoidPlateau);
	
	//medium objects
	int IDMediumHunt		 	= rmCreateObjectDef("medium hunt");
	rmAddObjectDefItem       	(IDMediumHunt, GetWeakHuntable(), rmRandInt(2,7), 4.0);
	rmSetObjectDefMinDistance	(IDMediumHunt, 50.0);
	rmSetObjectDefMaxDistance	(IDMediumHunt, 70.0);
	rmAddObjectDefConstraint	(IDMediumHunt, AvoidAll);
	rmAddObjectDefConstraint	(IDMediumHunt, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDMediumHunt, AvoidHunt);
	rmAddObjectDefConstraint	(IDMediumHunt, AvoidImpassableLand);
	rmAddObjectDefConstraint	(IDMediumHunt, AvoidPlateau);
	rmAddObjectDefConstraint	(IDMediumHunt, AvoidStartingSettleMed);
	
	int IDMediumGold		 	= rmCreateObjectDef("medium gold");
	rmAddObjectDefItem       	(IDMediumGold, "gold mine", 1, 0.0);
	rmSetObjectDefMinDistance	(IDMediumGold, 50.0);
	rmSetObjectDefMaxDistance	(IDMediumGold, 70.0);
	rmAddObjectDefConstraint	(IDMediumGold, AvoidAll);
	rmAddObjectDefConstraint	(IDMediumGold, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDMediumGold, AvoidGold);
	rmAddObjectDefConstraint	(IDMediumGold, AvoidImpassableLand);
	rmAddObjectDefConstraint	(IDMediumGold, AvoidPlateau);
	rmAddObjectDefConstraint	(IDMediumGold, AvoidCrater);
	
	int IDMediumHerd		 	= rmCreateObjectDef("medium herd");
	rmAddObjectDefItem       	(IDMediumHerd, GetHerdable(), rmRandInt(1,4), 3.0);
	rmSetObjectDefMinDistance	(IDMediumHerd, 50.0);
	rmSetObjectDefMaxDistance	(IDMediumHerd, 100.0);
	rmAddObjectDefConstraint	(IDMediumHerd, AvoidAll);
	rmAddObjectDefConstraint	(IDMediumHerd, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDMediumHerd, AvoidHerdable);
	rmAddObjectDefConstraint	(IDMediumHerd, AvoidImpassableLand);
	
	//far objects
	int IDFarGold			 	= rmCreateObjectDef("far gold");
	rmAddObjectDefItem       	(IDFarGold, "gold mine", 1, 0.0);
	rmSetObjectDefMinDistance	(IDFarGold, 70.0);
	rmSetObjectDefMaxDistance	(IDFarGold, 105.0);
	rmAddObjectDefConstraint	(IDFarGold, AvoidAll);
	rmAddObjectDefConstraint	(IDFarGold, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDFarGold, AvoidGold);
	rmAddObjectDefConstraint	(IDFarGold, AvoidPlateau);
	rmAddObjectDefConstraint	(IDFarGold, AvoidImpassableLand);
	rmAddObjectDefConstraint	(IDFarGold, AvoidCrater);
	rmAddObjectDefConstraint	(IDFarGold, AvoidStartingSettleMed);
	
	int IDFarHunt			 	= rmCreateObjectDef("far hunt");
	rmAddObjectDefItem       	(IDFarHunt, GetHuntable(), rmRandInt(1,12), 5.0);
	rmSetObjectDefMinDistance	(IDFarHunt, 75.0);
	rmSetObjectDefMaxDistance	(IDFarHunt, 100.0);
	rmAddObjectDefConstraint	(IDFarHunt, AvoidAll);
	rmAddObjectDefConstraint	(IDFarHunt, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDFarHunt, AvoidHunt);
	rmAddObjectDefConstraint	(IDFarHunt, AvoidImpassableLand);
	rmAddObjectDefConstraint	(IDFarHunt, AvoidPlateau);
	rmAddObjectDefConstraint	(IDFarHunt, AvoidStartingSettleMed);
	
	int IDFarAnimal			 	= rmCreateObjectDef("far animal");
	rmAddObjectDefItem       	(IDFarAnimal, GetLandAnimal(), rmRandInt(1,6), 5.0);
	rmSetObjectDefMinDistance	(IDFarAnimal, 60.0);
	rmSetObjectDefMaxDistance	(IDFarAnimal, 100.0);
	rmAddObjectDefConstraint	(IDFarAnimal, AvoidAll);
	rmAddObjectDefConstraint	(IDFarAnimal, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDFarAnimal, AvoidFood);
	rmAddObjectDefConstraint	(IDFarAnimal, AvoidImpassableLand);
	rmAddObjectDefConstraint	(IDFarAnimal, AvoidPlateau);
	
	int IDFarPredator		 	= rmCreateObjectDef("far pred");
	rmAddObjectDefItem       	(IDFarPredator, GetPredator(), rmRandInt(1,4), 5.0);
	rmSetObjectDefMinDistance	(IDFarPredator, 60.0);
	rmSetObjectDefMaxDistance	(IDFarPredator, 120.0);
	rmAddObjectDefConstraint	(IDFarPredator, AvoidAll);
	rmAddObjectDefConstraint	(IDFarPredator, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDFarPredator, AvoidPredator);
	rmAddObjectDefConstraint	(IDFarPredator, AvoidImpassableLand);
	
	//other
	int IDRelic				 	= rmCreateObjectDef("relic");
	rmAddObjectDefItem       	(IDRelic, "relic", 1, 0.0);
	rmSetObjectDefMinDistance	(IDRelic, 0.0);
	rmSetObjectDefMaxDistance	(IDRelic, 150.0);
	rmAddObjectDefConstraint	(IDRelic, AvoidAll);
	rmAddObjectDefConstraint	(IDRelic, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDRelic, AvoidStartingSettleMed);
	rmAddObjectDefConstraint	(IDRelic, AvoidImpassableLand);
	rmAddObjectDefConstraint	(IDRelic, AvoidRelic);
	
	int IDHesperides		 	= rmCreateObjectDef("hesperides");
	rmAddObjectDefItem       	(IDHesperides, "hesperides tree", 1, 0.0);
	rmSetObjectDefMinDistance	(IDHesperides, 0.0);
	rmSetObjectDefMaxDistance	(IDHesperides, 0.0);
	rmAddObjectDefConstraint	(IDHesperides, AvoidAll);
	rmAddObjectDefConstraint	(IDHesperides, AvoidEdgeLong);
	rmAddObjectDefConstraint	(IDHesperides, AvoidStartingSettleLong);
	rmAddObjectDefConstraint	(IDHesperides, AvoidImpassableLand);

	rmSetStatusText("",0.40);
	///DEFINE PLAYER LOCATIONS
	if (BuildPlayerCraters) {
		rmPlacePlayersCircular(0.30, 0.35, rmDegreesToRadians(0.0));
	} else 
	rmPlacePlayersCircular(0.30, 0.43, rmDegreesToRadians(5.0));
	
	
	rmSetStatusText("",0.45);
	///AREA DEFINITION
	int IDCenterCore		= rmCreateArea("center core");
	rmSetAreaSize			(IDCenterCore, 0.001, 0.001);
	rmSetAreaLocation		(IDCenterCore, 0.5, 0.5);
	rmAddAreaToClass		(IDCenterCore, classCenter);
	rmBuildArea				(IDCenterCore); 
	
	for(i=1; <cNumberPlayers)
		{
			int AreaPlayerCore		 = rmCreateArea("PlayerCore"+i);
	
			rmSetPlayerArea			(i, AreaPlayerCore);
			rmSetAreaSize			(AreaPlayerCore, 0.001, 0.001);
			rmAddAreaToClass		(AreaPlayerCore, classPlayer);
			rmSetAreaLocPlayer		(AreaPlayerCore, i);
			rmAddAreaToClass		(AreaPlayerCore, classPlayerCore);
		}
		rmBuildAllAreas();
	
	float playerFraction=rmAreaTilesToFraction(1250);
	
	if (BuildPlayerArea)
	{
		for(i=1; <cNumberPlayers)
		{
			int AreaPlayer 			= rmCreateArea("Player"+i);
	
			rmSetPlayerArea			(i, AreaPlayer);
			rmSetAreaSize			(AreaPlayer, playerFraction*0.5, playerFraction*1.5);
			rmAddAreaToClass		(AreaPlayer, classPlayer);
			rmSetAreaCoherence		(AreaPlayer, 0.0);
			rmSetAreaSmoothDistance (AreaPlayer, 10);
			rmSetAreaHeightBlend	(AreaPlayer, 2);
			rmSetAreaLocPlayer		(AreaPlayer, i);
			
			if (UseInsaneTextures)
				 rmSetAreaTerrainType	(AreaPlayer, GetInsaneWalkableTerrainType());
			else rmSetAreaTerrainType	(AreaPlayer, GetNormalWalkableTerrainType());
		}
		rmBuildAllAreas();
	}
	
	if (BuildPlayerCliffArea)
	{
		for(i=1; <cNumberPlayers)
		{
			AreaPlayer 				= rmCreateArea("Player"+i);
	
			rmSetPlayerArea			(i, AreaPlayer);
			rmSetAreaSize			(AreaPlayer, playerFraction*1.25, playerFraction*1.75);
			rmAddAreaToClass		(AreaPlayer, classPlayer);
			rmAddAreaToClass		(AreaPlayer, classCliff);
			rmSetAreaCoherence		(AreaPlayer, 0.5);
			rmSetAreaSmoothDistance (AreaPlayer, 20);
			rmSetAreaHeightBlend	(AreaPlayer, 2);
			rmSetAreaLocPlayer		(AreaPlayer, i);
			rmSetAreaCliffType		(AreaPlayer, GetCliffType());
			rmSetAreaCliffEdge		(AreaPlayer, 2, 0.40, 0.2, 1.0, 1);
			rmSetAreaCliffPainting	(AreaPlayer, false, true, true, 1.5, false);
	  
			if (UseInsaneTextures)
				 rmSetAreaTerrainType	(AreaPlayer, GetInsaneWalkableTerrainType());
			else rmSetAreaTerrainType	(AreaPlayer, GetNormalWalkableTerrainType());
		}
		rmBuildAllAreas();
	}
	
	if (BuildPlayerCraters)
	{
		for(i=1; <cNumberPlayers)
		{
			AreaPlayer =rmCreateArea("Player"+i);
	
			rmSetPlayerArea			(i, AreaPlayer);
			rmSetAreaSize			(AreaPlayer, playerFraction*1.5, playerFraction*1.75);
			rmAddAreaToClass		(AreaPlayer, classPlayer);
			rmAddAreaToClass		(AreaPlayer, classCrater);
			rmSetAreaCoherence		(AreaPlayer, 1.0);
			rmSetAreaSmoothDistance (AreaPlayer, 30);
			rmSetAreaHeightBlend	(AreaPlayer, 2);
			rmSetAreaLocPlayer		(AreaPlayer, i);
			rmSetAreaCliffType	 	(AreaPlayer, GetCliffType());
			rmSetAreaCliffEdge		(AreaPlayer, 2, 0.0, 0.0, 1.0, 1);
			rmSetAreaCliffHeight	(AreaPlayer, -5, 0.0, 1);
	  
			if (UseInsaneTextures)
				 rmSetAreaTerrainType	(AreaPlayer, GetInsaneWalkableTerrainType());
			else rmSetAreaTerrainType	(AreaPlayer, GetNormalWalkableTerrainType());
		}
		rmBuildAllAreas();
	}
	
	if (BuildCenterLake)
	{
		int IDCenterLake		=rmCreateArea("lake center");
		rmSetAreaSize			(IDCenterLake, 0.08, 0.25);
		rmSetAreaLocation		(IDCenterLake, 0.5, 0.5);
		rmSetAreaWaterType		(IDCenterLake, GetOceanType());
		rmAddAreaConstraint		(IDCenterLake, AvoidEdgeLong);
		rmAddAreaConstraint		(IDCenterLake, AvoidPlayerShort);
		rmSetAreaBaseHeight		(IDCenterLake, rmRandFloat(0,2));
		rmSetAreaSmoothDistance	(IDCenterLake, 20);
		rmSetAreaCoherence		(IDCenterLake, 0.5);
		
		rmBuildArea(IDCenterLake);
	}
	
	if (BuildCenterPlateau)
	{
		int IDCenterPlateau		= rmCreateArea("plateau center");
		rmSetAreaSize			(IDCenterPlateau, 0.07, 0.20);
		rmSetAreaLocation		(IDCenterPlateau, 0.5, 0.5);
		rmSetAreaTerrainType	(IDCenterPlateau, GetWalkNotBuildableTerrain());
		rmAddAreaConstraint		(IDCenterPlateau, AvoidEdgeLong);
		rmAddAreaConstraint		(IDCenterPlateau, AvoidPlayerMed);
		rmAddAreaToClass		(IDCenterPlateau, classPlateau);
		rmSetAreaBaseHeight		(IDCenterPlateau, rmRandFloat(0,2));
		rmSetAreaSmoothDistance	(IDCenterPlateau, 20);
		rmSetAreaCoherence		(IDCenterPlateau, 0.5);
		rmSetAreaMinBlobs		(IDCenterPlateau, 1);
		rmSetAreaMaxBlobs		(IDCenterPlateau, 5);
		rmSetAreaMinBlobDistance(IDCenterPlateau, 16.0);
		rmSetAreaMaxBlobDistance(IDCenterPlateau, 40.0);
		
		rmBuildArea(IDCenterPlateau);
	}
	
	
	for(i=0; < amountBeautyPatchesA)
	{
		int AreaPatch			= rmCreateArea("patch A"+i);
		rmSetAreaSize			(AreaPatch, rmAreaTilesToFraction(10), rmAreaTilesToFraction(150));
		
		if (UseInsaneTextures)
			 rmSetAreaTerrainType	(AreaPatch, GetInsaneWalkableTerrainType());
		else rmSetAreaTerrainType	(AreaPatch, GetNormalWalkableTerrainType());
		
		rmSetAreaMinBlobs		(AreaPatch, 1);
		rmSetAreaMaxBlobs		(AreaPatch, 5);
		rmSetAreaMinBlobDistance(AreaPatch, 16.0);
		rmSetAreaMaxBlobDistance(AreaPatch, 40.0);
		rmSetAreaCoherence		(AreaPatch, 0.0);
		rmAddAreaConstraint		(AreaPatch, AvoidPlayerShort);
		rmAddAreaConstraint		(AreaPatch, AvoidPlateau);
		
		rmBuildArea(AreaPatch);
	}
	
	for(i=0; < amountElevPatchesA)
	{
		int AreaElev			= rmCreateArea("Elev A"+i);
		rmSetAreaSize			(AreaElev, rmAreaTilesToFraction(30), rmAreaTilesToFraction(150));
		rmSetAreaMinBlobs		(AreaElev, 1);
		rmSetAreaMaxBlobs		(AreaElev, 5);
		rmSetAreaMinBlobDistance(AreaElev, 16.0);
		rmSetAreaMaxBlobDistance(AreaElev, 40.0);
		rmSetAreaCoherence		(AreaElev, 0.0);
		rmSetAreaBaseHeight		(AreaElev, rmRandInt(2,7));
		rmSetAreaHeightBlend	(AreaElev, 2);
		rmAddAreaConstraint		(AreaElev, AvoidPlateau);
		rmAddAreaConstraint		(AreaElev, AvoidCrater);
		rmAddAreaConstraint		(AreaElev, AvoidImpassableLand);
		
		rmBuildArea(AreaElev);
	}
	
	if (BuildOasis) {
		
		int OasisChance = rmRandFloat(0,1);
			if (OasisChance < 0.5)
			{
				int AreaForest1			= rmCreateArea("ForestA A"+i);
				rmSetAreaSize			(AreaForest1, 0.03, 0.06);
				rmSetAreaLocation		(AreaForest1, 0.5,0.5);
				rmSetAreaCoherence		(AreaForest1, 0.3);
				rmSetAreaSmoothDistance	(AreaForest1, 3.0);
				rmSetAreaHeightBlend	(AreaForest1, 2);
				rmSetAreaForestType		(AreaForest1, GetForestType());
				rmAddAreaToClass		(AreaForest1, classForest);
				rmAddAreaConstraint		(AreaForest1, AvoidPlayerCore);
				
				rmBuildArea(AreaForest1);
			} 
			else 
			{
				int AreaForest2			= rmCreateArea("ForestB A"+i);
				rmSetAreaSize			(AreaForest2, 0.02, 0.03);
				rmSetAreaLocation		(AreaForest2, 0.39,0.39);
				rmSetAreaCoherence		(AreaForest2, 0.3);
				rmSetAreaSmoothDistance	(AreaForest2, 3.0);
				rmSetAreaHeightBlend	(AreaForest2, 2);
				rmSetAreaForestType		(AreaForest2, GetForestType());
				rmAddAreaToClass		(AreaForest2, classForest);
				rmAddAreaConstraint		(AreaForest2, AvoidPlayerCore);
				
				rmBuildArea(AreaForest2);
				
				int AreaForest3			= rmCreateArea("ForestC A"+i);
				rmSetAreaSize			(AreaForest3, 0.02, 0.03);
				rmSetAreaLocation		(AreaForest3, 0.61,0.61);
				rmSetAreaCoherence		(AreaForest3, 0.3);
				rmSetAreaSmoothDistance	(AreaForest3, 3.0);
				rmSetAreaHeightBlend	(AreaForest3, 2);
				rmSetAreaForestType		(AreaForest3, GetForestType());
				rmAddAreaToClass		(AreaForest3, classForest);
				rmAddAreaConstraint		(AreaForest3, AvoidPlayerCore);
				
				rmBuildArea(AreaForest3);
		}
	}
	
	rmSetStatusText("",0.55);
	///SETTLEMENTS
	rmPlaceObjectDefPerPlayer (IDStartingSettlement, true);
	
	if (BuildSettlementCraters) {
		int AreaSettle=rmAddFairLoc("Settlement", false, false,  70, 100, 30, 35);
		rmAddFairLocConstraint(AreaSettle, AvoidImpassableLand);
		
		AreaSettle=rmAddFairLoc("Settlement", true, false,  65, 105, 75, 16);
		rmAddFairLocConstraint(AreaSettle, AvoidImpassableLand);
	} else {
		AreaSettle=rmAddFairLoc("Settlement", false, true,  45, 80, 40, 15);
		rmAddFairLocConstraint(AreaSettle, AvoidImpassableLand);
		
		AreaSettle=rmAddFairLoc("Settlement", true, false,  50, 105, 60, 16);
		rmAddFairLocConstraint(AreaSettle, AvoidImpassableLand);
	}
	
	rmAddFairLocConstraint(AreaSettle, AvoidForestShort);
	
	if (BuildSettlementCraters) {
		rmAddFairLocConstraint(AreaSettle, AvoidImpassableLandFar);
	}
	
	if (ThirdSettlement) {
		AreaSettle=rmAddFairLoc("Settlement", true, false,  80, 140, 60, 20);
		rmAddFairLocConstraint(AreaSettle, AvoidImpassableLand);
	}
	
	// Crater Settlements
	
	if (BuildSettlementCraters)
	{
		bool FairLocCreationSuccess = rmPlaceFairLocs();
		if (FairLocCreationSuccess)
		{
			int NumArea = 0;
			for (i = 1; < cNumberPlayers)
			{	
				for (j = 0; < rmGetNumberFairLocs(i))
				{
					// Get Settlement Positions In Fraction
					float XPosFraction    	= rmFairLocXFraction(i, j);
					float ZPosFraction    	= rmFairLocZFraction(i, j);
					
					// Define an Area on those positions.
					int AreaSettlement    	= rmCreateArea("Settlement" + NumArea);
					rmSetAreaLocation    	(AreaSettlement, XPosFraction, ZPosFraction);
					rmSetAreaCoherence		(AreaSettlement, 1.0);
					rmSetAreaCliffType		(AreaSettlement, GetCliffType());
					rmSetAreaBaseHeight		(AreaSettlement, 1.0);
					rmSetAreaCliffEdge		(AreaSettlement, 2, 0.0, 0.0, 1.0, 1);
					rmSetAreaCliffHeight	(AreaSettlement, -5, 0.0, 1);
					rmSetAreaSmoothDistance	(AreaSettlement, 20);
					rmAddAreaToClass		(AreaSettlement, classCrater);
					
					rmSetAreaSize			(AreaSettlement, playerFraction*0.6, playerFraction*0.7);
					
					if (UseInsaneTextures)
						rmSetAreaTerrainType	(AreaSettlement, GetInsaneWalkableTerrainType());
					else rmSetAreaTerrainType	(AreaSettlement, GetNormalWalkableTerrainType());
					
					// Build it..
					rmBuildArea(AreaSettlement);
					NumArea = NumArea + 1; // Increment Settlement Area
				}
			}
	
			// Place the settlements after building the settlement areas
			AreaSettle=rmCreateObjectDef("far settlement2");
			rmAddObjectDefItem(AreaSettle, "Settlement", 1, 0.0);
			for(i=1; <cNumberPlayers)
			{
				for(j=0; <rmGetNumberFairLocs(i))
				{
					rmPlaceObjectDefAtLoc(AreaSettle, i, rmFairLocXFraction(i, j), rmFairLocZFraction(i, j), 1);
				}
			}
		}
	} 
	else
	{
		if(rmPlaceFairLocs())
		{
			AreaSettle=rmCreateObjectDef("far settlement2");
			rmAddObjectDefItem(AreaSettle, "Settlement", 1, 0.0);
			for(i=1; <cNumberPlayers)
			{
				for(j=0; <rmGetNumberFairLocs(i))
					rmPlaceObjectDefAtLoc(AreaSettle, i, rmFairLocXFraction(i, j), rmFairLocZFraction(i, j), 1);
			}
		}
	}

	rmSetStatusText("",0.65);
	///CLIFFS
	if (BuildCliffs)
	{
		for(i=0; < amountCliffsA)
		{
			int IDCliff					= rmCreateArea("CliffA"+i);
			rmSetAreaWarnFailure		(IDCliff, false);
			rmSetAreaSize				(IDCliff, rmAreaTilesToFraction(100), rmAreaTilesToFraction(500));
			rmSetAreaCliffType			(IDCliff, GetCliffType());
			rmAddAreaConstraint			(IDCliff, AvoidCliff);
			rmAddAreaConstraint			(IDCliff, AvoidStartingSettleMed);
			rmAddAreaConstraint			(IDCliff, AvoidImpassableLand);
			rmAddAreaConstraint			(IDCliff, AvoidPlateau);
			rmAddAreaConstraint			(IDCliff, AvoidAll);
			rmAddAreaConstraint			(IDCliff, AvoidCrater);
			rmAddAreaToClass			(IDCliff, classCliff);
			rmSetAreaMinBlobs			(IDCliff, 0);
			rmSetAreaMaxBlobs			(IDCliff, 10);
			int edgeRand=rmRandInt(0,100);
			if(edgeRand<11)
			{
				rmSetAreaCliffEdge		(IDCliff, 1, 1.0, 0.0, 1.0, 0);
				rmSetAreaCliffPainting	(IDCliff, true, true, true, 1.5, false);
				rmSetAreaTerrainType	(IDCliff, GetNormalWalkableTerrainType());
				rmSetAreaSize			(IDCliff, rmAreaTilesToFraction(50), rmAreaTilesToFraction(300));
			} else {
				rmSetAreaCliffEdge		(IDCliff, 1, 0.6, 0.1, 1.0, 0);
				rmSetAreaCliffPainting	(IDCliff, false, true, true, 1.5, true);
			}
			rmSetAreaCliffHeight		(IDCliff, rmRandInt(4,12), 1.0, 1.0);
			rmSetAreaMinBlobDistance	(IDCliff, 10.0);
			rmSetAreaMaxBlobDistance	(IDCliff, 20.0);
			rmSetAreaCoherence			(IDCliff, 0.0);
			rmSetAreaSmoothDistance		(IDCliff, 10);
			rmSetAreaHeightBlend		(IDCliff, 2); 
			rmBuildArea					(IDCliff);
		}
	}
	
	rmSetStatusText("",0.70);
	///PLACE OBJECTS	
	rmPlaceObjectDefPerPlayer (IDStartingGold, false, 1);
	rmPlaceObjectDefPerPlayer (IDStartingHunt, false, rmRandInt(0,2));
	rmPlaceObjectDefPerPlayer (IDStartingFood, false, rmRandInt(1,2));
	rmPlaceObjectDefPerPlayer (IDStartingHerd, true, rmRandInt(0,2));
	rmPlaceObjectDefPerPlayer (IDStragglerTree, false, rmRandInt(1,12));
	
	if (Hesperides) {
		rmPlaceObjectDefAtLoc (IDHesperides, 0, 0.5, 0.5, 1);
	}
	
	if (rmRandFloat(0,1) < 0.1) {
		rmPlaceObjectDefPerPlayer (IDStartingAnimal, false, 1);
	}
	
	if (TowerChance < 0.10) {
		rmPlaceObjectDefPerPlayer (IDStartingTower2, true, 4);
	} else if (TowerChance < 0.4) {
		rmPlaceObjectDefPerPlayer (IDStartingTower, true, 4);
	} else {
		rmPlaceObjectDefPerPlayer (IDStartingTower, true, 3);
		rmPlaceObjectDefPerPlayer (IDStartingTower2, true, 1);
	}
	
	rmPlaceObjectDefPerPlayer (IDMediumHunt, false, rmRandInt(0,1));
	rmPlaceObjectDefPerPlayer (IDMediumGold, false, 1);
	rmPlaceObjectDefPerPlayer (IDMediumHerd, false, rmRandInt(0,4));
	
	rmPlaceObjectDefPerPlayer (IDFarGold, false, rmRandInt(1,4));
	rmPlaceObjectDefPerPlayer (IDFarHunt, false, rmRandInt(0,2));
	rmPlaceObjectDefPerPlayer (IDFarAnimal, false, rmRandInt(0,1));
	rmPlaceObjectDefPerPlayer (IDFarPredator, false, rmRandInt(1,2));
	
	if (MonsterRelics) {
		rmPlaceObjectDefPerPlayer (IDRelic, false, rmRandInt(2,8));
	} else 
	rmPlaceObjectDefPerPlayer (IDRelic, false, rmRandInt(1,2));
	rmPlaceObjectDefPerPlayer (IDStandardFish, false, rmRandInt(4,9));

	rmSetStatusText("",0.75);
	///FORESTS
	int NumForestTypes = (rmRandInt(0,1));
	int failCount = 0;
	
	if (ExtremeForests) {
		forestCount = rmRandInt(6,10)*cNumberNonGaiaPlayers;
		failCount=0;
		
		for(i=0; <forestCount)
		{
			int IDForest3			= rmCreateArea("forestC"+i);
			rmSetAreaSize			(IDForest3, rmAreaTilesToFraction(200), rmAreaTilesToFraction(400));
			rmSetAreaWarnFailure	(IDForest3, false);
			rmSetAreaForestType 	(IDForest3, GetForestType());
			rmAddAreaConstraint 	(IDForest3, AvoidSettlementSlightly);
			rmAddAreaConstraint 	(IDForest3, AvoidAllLong);
			rmAddAreaConstraint 	(IDForest3, AvoidForestShort);
			rmAddAreaConstraint 	(IDForest3, AvoidImpassableLand);
			rmAddAreaConstraint 	(IDForest3, AvoidStartingSettle);
			rmAddAreaConstraint 	(IDForest3, AvoidPlateau);
			rmAddAreaToClass		(IDForest3, classForest);
			
			rmSetAreaMinBlobs		(IDForest3, 0);
			rmSetAreaMaxBlobs		(IDForest3, 2);
			rmSetAreaMinBlobDistance(IDForest3, 16.0);
			rmSetAreaMaxBlobDistance(IDForest3, 30.0);
			rmSetAreaCoherence		(IDForest3, 0.1);
	
			if (BuildSettlementCraters || BuildStartingSettlementCraters) {
				rmAddAreaConstraint 	(IDForest3, AvoidCrater);	
			}
		
			if(rmBuildArea(IDForest3)==false)
			{
				// Stop trying once we fail 3 times in a row.
				failCount++;
				if(failCount==4)
					break;
			}
			else
				failCount=0;
		}
	}
	else if (NothingAtAll) 
	{
		failCount=0;
		forestCount = rmRandInt(9,14)*cNumberNonGaiaPlayers;
		for(i=0; <forestCount)
		{
			int IDForest4			= rmCreateArea("forestD"+i);
			rmSetAreaSize			(IDForest4, rmAreaTilesToFraction(50), rmAreaTilesToFraction(180));
			rmSetAreaWarnFailure	(IDForest4, false);
			rmSetAreaForestType 	(IDForest4, GetForestType());
			rmAddAreaConstraint 	(IDForest4, AvoidSettlementSlightly);
			rmAddAreaConstraint 	(IDForest4, AvoidAllLong);
			rmAddAreaConstraint 	(IDForest4, AvoidForest);
			rmAddAreaConstraint 	(IDForest4, AvoidImpassableLand);
			rmAddAreaConstraint 	(IDForest4, AvoidStartingSettle);
			rmAddAreaConstraint 	(IDForest4, AvoidPlateau);
			rmAddAreaToClass		(IDForest4, classForest);
			
			rmSetAreaMinBlobs		(IDForest4, 0);
			rmSetAreaMaxBlobs		(IDForest4, 2);
			rmSetAreaMinBlobDistance(IDForest4, 16.0);
			rmSetAreaMaxBlobDistance(IDForest4, 22.0);
			rmSetAreaCoherence		(IDForest4, 0.1);
	
			if (BuildSettlementCraters || BuildStartingSettlementCraters) {
				rmAddAreaConstraint 	(IDForest4, AvoidCrater);	
			}
			
			if(rmBuildArea(IDForest4)==false)
			{
				// Stop trying once we fail 3 times in a row.
				failCount++;
				if(failCount==4)
					break;
			}
			else
				failCount=0;
		}
	} 
	else if (NumForestTypes == 0) 
	{
		forestCount = rmRandInt(10,12)*cNumberNonGaiaPlayers;
		failCount=0;
		
		for(i=0; <forestCount)
		{
			int IDForest			= rmCreateArea("forest"+i);
			rmSetAreaSize			(IDForest, rmAreaTilesToFraction(40), rmAreaTilesToFraction(200));
			rmSetAreaWarnFailure	(IDForest, false);
			rmSetAreaForestType 	(IDForest, GetForestType());
			rmAddAreaConstraint 	(IDForest, AvoidSettlementSlightly);
			rmAddAreaConstraint 	(IDForest, AvoidAllLong);
			rmAddAreaConstraint 	(IDForest, AvoidForest);
			rmAddAreaConstraint 	(IDForest, AvoidImpassableLand);
			rmAddAreaConstraint 	(IDForest, AvoidStartingSettle);
			rmAddAreaConstraint 	(IDForest, AvoidPlateau);
			rmAddAreaToClass		(IDForest, classForest);
			
			if (BuildSettlementCraters || BuildStartingSettlementCraters) {
				rmAddAreaConstraint 	(IDForest, AvoidCrater);	
			}
			
			rmSetAreaMinBlobs		(IDForest, 0);
			rmSetAreaMaxBlobs		(IDForest, 2);
			rmSetAreaMinBlobDistance(IDForest, 16.0);
			rmSetAreaMaxBlobDistance(IDForest, 22.0);
			rmSetAreaCoherence		(IDForest, 0.1);
	
			if(rmBuildArea(IDForest)==false)
			{
				// Stop trying once we fail 3 times in a row.
				failCount++;
				if(failCount==4)
					break;
			}
			else
				failCount=0;
		}
	} 
	else if (NumForestTypes == 1) 
	{
		forestCount = rmRandInt(8,10)*cNumberNonGaiaPlayers;
		failCount=0;
		
		for(i=0; <forestCount)
		{
			int IDForest2			= rmCreateArea("forestB"+i);
			rmSetAreaSize			(IDForest2, rmAreaTilesToFraction(65), rmAreaTilesToFraction(220));
			rmSetAreaWarnFailure	(IDForest2, false);
			rmSetAreaForestType 	(IDForest2, GetForestType());
			rmAddAreaConstraint 	(IDForest2, AvoidSettlementSlightly);
			rmAddAreaConstraint 	(IDForest2, AvoidAllLong);
			rmAddAreaConstraint 	(IDForest2, AvoidForest);
			rmAddAreaConstraint 	(IDForest2, AvoidImpassableLand);
			rmAddAreaConstraint 	(IDForest2, AvoidStartingSettle);
			rmAddAreaConstraint 	(IDForest2, AvoidPlateau);
			rmAddAreaToClass		(IDForest2, classForest);
			
			if (BuildSettlementCraters || BuildStartingSettlementCraters) {
				rmAddAreaConstraint 	(IDForest2, AvoidCrater);	
			}
			
			rmSetAreaMinBlobs		(IDForest2, 1);
			rmSetAreaMaxBlobs		(IDForest2, 5);
			rmSetAreaMinBlobDistance(IDForest2, 10.0);
			rmSetAreaMaxBlobDistance(IDForest2, 30.0);
			rmSetAreaCoherence		(IDForest2, 0.0);
	
			if(rmBuildArea(IDForest2)==false)
			{
				// Stop trying once we fail 3 times in a row.
				failCount++;
				if(failCount==4)
					break;
			}
			else
				failCount=0;
		}
	}
	
	rmPlaceObjectDefAtLoc (IDRandomTree, 0, 0.5, 0.5, rmRandFloat(10,25)*cNumberNonGaiaPlayers);
	
	rmSetStatusText("",0.85);
	///BEAUTIFICATION
	//water beautification
	
	if (HasWater)
	{
		if (SpawnsBeautificationWaterPads)
		{
			int IDLily					= rmCreateObjectDef("pads");
			rmAddObjectDefItem			(IDLily, "water lilly", rmRandInt(3,5), 4.0);
			rmSetObjectDefMinDistance	(IDLily, 0.0);
			rmSetObjectDefMaxDistance	(IDLily, rmXFractionToMeters(0.5));
			rmAddObjectDefConstraint	(IDLily, AvoidAll);
			rmPlaceObjectDefAtLoc		(IDLily, 0, 0.5, 0.5, rmRandFloat(1,5)*cNumberNonGaiaPlayers);
		}

		
		if (SpawnsBeautificationWaterWeed)
		{
			int IDSeaweed				= rmCreateObjectDef("seaweed");
			rmAddObjectDefItem			(IDSeaweed, "seaweed", rmRandFloat(1,5), 3.0);
			rmSetObjectDefMinDistance	(IDSeaweed, 0.0);
			rmSetObjectDefMaxDistance	(IDSeaweed, rmXFractionToMeters(0.5));
			rmAddObjectDefConstraint	(IDSeaweed, AvoidAll);
			rmAddObjectDefConstraint	(IDSeaweed, NearShore);
			rmAddObjectDefConstraint	(IDSeaweed, AvoidShore);
			rmPlaceObjectDefAtLoc		(IDSeaweed, 0, 0.5, 0.5, rmRandFloat(1,6)*cNumberNonGaiaPlayers);
		}
	}

	//land beautification
	if (SpawnsBeautificationLogs)
	{
		int IDLogs					= rmCreateObjectDef("logs");
		rmAddObjectDefItem			(IDLogs, "rotting log", 1, 0.0);
		rmSetObjectDefMinDistance	(IDLogs, 0.0);
		rmSetObjectDefMaxDistance	(IDLogs, rmXFractionToMeters(0.5));
		rmAddObjectDefConstraint	(IDLogs, AvoidAll);
		rmAddObjectDefConstraint	(IDLogs, AvoidPlateau);
		rmPlaceObjectDefAtLoc		(IDLogs, 0, 0.5, 0.5, 5*cNumberNonGaiaPlayers);
	}
	
	if (SpawnsBeautificationBush1)
	{
		int IDGeorgeBush			= rmCreateObjectDef("big bush patch");
		rmAddObjectDefItem			(IDGeorgeBush, "bush", 4, 4.0);
		rmSetObjectDefMinDistance	(IDGeorgeBush, 0.0);
		rmSetObjectDefMaxDistance	(IDGeorgeBush, rmXFractionToMeters(0.5));
		rmAddObjectDefConstraint	(IDGeorgeBush, AvoidAll);
		rmAddObjectDefConstraint	(IDGeorgeBush, AvoidImpassableLand);
		rmAddObjectDefConstraint	(IDGeorgeBush, AvoidPlateau);
		rmPlaceObjectDefAtLoc		(IDGeorgeBush, 0, 0.5, 0.5, 10*cNumberNonGaiaPlayers);
	}

	if (SpawnsBeautificationBush2)
	{
		int IDGeorgeBushthe2nd		=rmCreateObjectDef("small bush patch");
		rmAddObjectDefItem			(IDGeorgeBushthe2nd, "bush", rmRandInt(1.0, 3.0), 4.0);
		rmAddObjectDefItem			(IDGeorgeBushthe2nd, "rock limestone sprite", 1, 4.0);
		rmSetObjectDefMinDistance	(IDGeorgeBushthe2nd, 0.0);
		rmSetObjectDefMaxDistance	(IDGeorgeBushthe2nd, rmXFractionToMeters(0.5));
		rmAddObjectDefConstraint	(IDGeorgeBushthe2nd, AvoidAll);
		rmAddObjectDefConstraint	(IDGeorgeBushthe2nd, AvoidImpassableLand);
		rmAddObjectDefConstraint	(IDGeorgeBushthe2nd, AvoidPlateau);
		rmPlaceObjectDefAtLoc		(IDGeorgeBushthe2nd, 0, 0.5, 0.5, 15*cNumberNonGaiaPlayers);
	}
	
	if (SpawnsBeautificationGrass)
	{
		int IDGrass					=rmCreateObjectDef("grass");
		rmAddObjectDefItem			(IDGrass, "grass", 1, 0.0);
		rmSetObjectDefMinDistance	(IDGrass, 0.0);
		rmSetObjectDefMaxDistance	(IDGrass, rmXFractionToMeters(0.5));
		rmAddObjectDefConstraint	(IDGrass, AvoidAll);
		rmAddObjectDefConstraint	(IDGrass, AvoidImpassableLand);
		rmAddObjectDefConstraint	(IDGrass, AvoidPlateau);
		rmPlaceObjectDefAtLoc		(IDGrass, 0, 0.5, 0.5, 30*cNumberNonGaiaPlayers);
	}

	if (SpawnsBeautificationRock)
	{
		int IDRock				 	 = rmCreateObjectDef("rock");
		rmAddObjectDefItem		 	 (IDRock, "rock granite sprite", 1, 0.0);
		rmSetObjectDefMinDistance	 (IDRock, 0.0);
		rmSetObjectDefMaxDistance	 (IDRock, rmXFractionToMeters(0.5));
		rmAddObjectDefConstraint 	 (IDRock, AvoidAll);
		rmAddObjectDefConstraint 	 (IDRock, AvoidPlateau);
		rmPlaceObjectDefAtLoc	 	 (IDRock, 0, 0.5, 0.5, 20*cNumberNonGaiaPlayers);
	}

	if (SpawnsBeautificationRune)
	{
		int IDRune				 	 = rmCreateObjectDef("runestone");
		rmAddObjectDefItem		 	 (IDRune, "runestone", 1, 0.0);
		rmSetObjectDefMinDistance	 (IDRune, 0.0);
		rmSetObjectDefMaxDistance	 (IDRune, rmXFractionToMeters(0.5));
		rmAddObjectDefConstraint 	 (IDRune, AvoidAll);
		rmAddObjectDefConstraint 	 (IDRune, AvoidSettlementSlightly);
		rmAddObjectDefConstraint 	 (IDRune, AvoidPlateau);
		rmAddObjectDefConstraint 	 (IDRune, rmCreateTypeDistanceConstraint("Rune vs Rune", "runestone", 70.0));
		rmPlaceObjectDefAtLoc	 	 (IDRune, 0, 0.5, 0.5, 2*cNumberNonGaiaPlayers);
	}

	if (SpawnsBeautificationFlowers)
	{
		int IDFlowers				= rmCreateObjectDef("flowers");
		rmAddObjectDefItem			(IDFlowers, "flowers", rmRandInt(1.0, 3.0), 4.0);
		rmSetObjectDefMinDistance	(IDFlowers, 0.0);
		rmSetObjectDefMaxDistance	(IDFlowers, rmXFractionToMeters(0.5));
		rmAddObjectDefConstraint	(IDFlowers, AvoidAll);
		rmAddObjectDefConstraint	(IDFlowers, AvoidImpassableLand);
		rmAddObjectDefConstraint	(IDFlowers, AvoidPlateau);
		rmPlaceObjectDefAtLoc		(IDFlowers, 0, 0.5, 0.5, 5*cNumberNonGaiaPlayers);
	}
	
	if (SpawnsBeautificationDrift)
	{
		int IDSandDrift				= rmCreateObjectDef("blowing sand");
		rmAddObjectDefItem			(IDSandDrift, "sand drift patch", 1, 0.0);
		rmSetObjectDefMinDistance	(IDSandDrift, 0.0);
		rmSetObjectDefMaxDistance	(IDSandDrift, rmXFractionToMeters(0.5));
		rmAddObjectDefConstraint	(IDSandDrift, AvoidAll);
		rmAddObjectDefConstraint	(IDSandDrift, AvoidEdgeMed);
		rmAddObjectDefConstraint	(IDSandDrift, AvoidStartingSettleMed);
		rmAddObjectDefConstraint	(IDSandDrift, AvoidPlateau);
		rmPlaceObjectDefAtLoc		(IDSandDrift, 0, 0.5, 0.5, rmRandFloat(1,5)*cNumberNonGaiaPlayers);
	}
	rmSetStatusText("",0.95);

}

void WaterMap(void)
{
	int PlayerTiles=rmRandInt(12000,13500);
	
	if(cMapSize == 1) {
		PlayerTiles = rmRandInt(13500,15500);
		rmEchoInfo("Large map");
	}
	
	// Init world as water
	bool IsRiverMap = false;
	bool UseInsaneTextures 			= Chance(10);
	bool StartingGoldIsLarge		= Chance(15);
	bool StartingGoldIsSmall		= Chance(5);
	bool BuildPlayerAreaRiver		= false;
	bool BuildPlayerAreaIsland		= false;
	bool MonsterRelics				= Chance(5);
	bool ThirdSettlement			= Chance(5);
	bool BuildBonusIslands			= false;
	bool ClusterConnection			= false;
	bool BuildPlayerAreaIslandChain	= false;
	bool FishChance					= true;
	bool GroundIsChaotic			= Chance(10);
	
	//Connection stuff
	bool ConnectionAddPlayer = true;
	bool ConnectionAddBonus  = true;
	bool BuildConnections    = true;
	
	/// Map variations
	bool BuildIslands		= false;
	bool BuildRiver			= false;
	bool BuildLine			= false;
	bool BuildChainLands	= false;
	bool BuildCenterLand	= false;
	
	// Beautifucation Randomization 
	bool SpawnsBeautificationWaterPads = true;
	bool SpawnsBeautificationWaterWeed = true;
	bool SpawnsBeautificationLogs      = Chance(50);
	bool SpawnsBeautificationBush1     = Chance(50);
	bool SpawnsBeautificationBush2     = Chance(50);
	bool SpawnsBeautificationGrass     = Chance(50);
	bool SpawnsBeautificationRock      = Chance(50);
	bool SpawnsBeautificationRune      = Chance(50);
	bool SpawnsBeautificationFlowers   = Chance(50);
	bool SpawnsBeautificationDrift     = Chance(50);
	
	///Tower variations
	float TowerChance = rmRandFloat(0,1);
	
	int amountBeautyPatchesA = cNumberNonGaiaPlayers * 5;
	int amountElevPatchesA	 = cNumberNonGaiaPlayers * 3;
	
	if (GroundIsChaotic) {
		amountBeautyPatchesA = cNumberNonGaiaPlayers * rmRandInt(100,200);
		amountElevPatchesA 	 = cNumberNonGaiaPlayers * rmRandInt(20,40);
	}
	
	int BonusNum 	  = rmRandInt(0,1)*cNumberNonGaiaPlayers;
	
	
	
	int WaterKind = rmRandInt(0,4);
	
	// Hacky way to exclude variations
	// that only work with 1v1
	if (cNumberNonGaiaPlayers > 2)
	{
		while (WaterKind == 2)
		{
			WaterKind = rmRandInt(0,4);
		}
	}
	
	switch (WaterKind)
	{
		case 0: BuildIslands	= true;
		case 1: BuildRiver		= true;
		case 2: BuildLine		= true;
		case 3: BuildChainLands	= true;
		case 4: BuildCenterLand	= true;
	}
	
	if (BuildIslands)
	{
		BuildBonusIslands		= true;
		BuildPlayerAreaIsland	= true;
		BonusNum = rmRandInt(2,3) * cNumberNonGaiaPlayers;
		IsRiverMap = false;
		ClusterConnection = Chance(25);
	}
	
	if (BuildRiver) {
		IsRiverMap = true;
		
		
		PlayerTiles=rmRandInt(7000,8000);
	
		if(cMapSize == 1) {
			PlayerTiles = rmRandInt(8500,10500);
			rmEchoInfo("Large map");
		}
	}
	
	if (BuildChainLands) {
		IsRiverMap = true;
		BuildPlayerAreaIslandChain = true;
		FishChance = Chance(50);
		PlayerTiles=rmRandInt(8000,9000);
	
		if(cMapSize == 1) {
			PlayerTiles = rmRandInt(10500,11500);
			rmEchoInfo("Large map");
		}
	}
	
	if (BuildCenterLand) {
		PlayerTiles=rmRandInt(9500,11000);
	
		if(cMapSize == 1) {
			PlayerTiles = rmRandInt(11500,13500);
			rmEchoInfo("Large map");
		}
	}
	
	if (IsRiverMap)
	{
		rmSetSeaType(GetRiverType());
	} 
	else 
	{
		rmSetSeaType(GetOceanType());
	}
	
	
	/// =================================================================== INIT MAP
	int size=2.0*sqrt(cNumberNonGaiaPlayers*PlayerTiles);
	rmSetMapSize(size, size);
	rmTerrainInitialize("water");

	rmSetStatusText("",0.10);
	///CLASSES
	int classPlayer 	= rmDefineClass("player area");
	int classTower		= rmDefineClass("tower type");
	int classForest		= rmDefineClass("forest");
	int classSettlement	= rmDefineClass("starting settlement");
	int classCenter		= rmDefineClass("center core");
	int classBonusIsland= rmDefineClass("bonus island");
	int classCliff		= rmDefineClass("cliff");
	int classIsland		= rmDefineClass("island");
	int classPlayerCore	= rmDefineClass("player core");
	int classPassage	= rmDefineClass("passage");
	int classChain		= rmDefineClass("chain island");
	
	rmSetStatusText("",0.15);
	///CONSTRAINTS
	int AvoidEdgeLong	= rmCreateBoxConstraint	("CB0", rmXTilesToFraction(30), rmZTilesToFraction(30), 1.0-rmXTilesToFraction(30), 1.0-rmZTilesToFraction(30));
	int AvoidEdgeMed	= rmCreateBoxConstraint	("CB1", rmXTilesToFraction(4), rmZTilesToFraction(4), 1.0-rmXTilesToFraction(4), 1.0-rmZTilesToFraction(4));
	int AvoidEdgeShort	= rmCreateBoxConstraint	("CB2", rmXTilesToFraction(2), rmZTilesToFraction(2), 1.0-rmXTilesToFraction(2), 1.0-rmZTilesToFraction(2));

	int AvoidAll				= rmCreateTypeDistanceConstraint ("CT0", "all", 6.0);
	int AvoidFish				= rmCreateTypeDistanceConstraint ("CT1", "fish", rmRandInt(14,25));
	int AvoidFood				= rmCreateTypeDistanceConstraint ("CT2", "food", 15.0);
	int AvoidHunt				= rmCreateTypeDistanceConstraint ("CT3", "huntable", 20.0);
	int AvoidSettlementSlightly = rmCreateTypeDistanceConstraint ("CT4", "AbstractSettlement", 10.0);
	int AvoidSettlementAbit		= rmCreateTypeDistanceConstraint ("CT5", "AbstractSettlement", 20.0);
	int AvoidSettlementSomewhat = rmCreateTypeDistanceConstraint ("CT6", "AbstractSettlement", 32.0);
	int AvoidGold				= rmCreateTypeDistanceConstraint ("CT7", "gold", 25.0);
	int AvoidHerdable			= rmCreateTypeDistanceConstraint ("CT8", "herdable", 20.0);
	int AvoidPredator			= rmCreateTypeDistanceConstraint ("CT9", "animalPredator", 20.0);
	int AvoidRelic				= rmCreateTypeDistanceConstraint ("CT10", "relic", 40.0);
	int AvoidAllLong			= rmCreateTypeDistanceConstraint ("CT11", "all", 8.0);
	
	int AvoidPlayerShort		= rmCreateClassDistanceConstraint ("CC0", classPlayer, 1.0);
	int AvoidTower				= rmCreateClassDistanceConstraint ("CC1", classTower, 20.0);
	int AvoidForest				= rmCreateClassDistanceConstraint ("CC2", classForest, rmRandInt(15.0,25.0));
	int AvoidStartingSettle		= rmCreateClassDistanceConstraint ("CC3", classSettlement, rmRandInt(15.0,20.0));
	int AvoidStartingSettleMed	= rmCreateClassDistanceConstraint ("CC4", classSettlement, 40.0);
	int AvoidCenter				= rmCreateClassDistanceConstraint ("CC5", classCenter, 30.0);
	int AvoidBonusIsland		= rmCreateClassDistanceConstraint ("CC6", classBonusIsland, 10.0);
	int AvoidCliff				= rmCreateClassDistanceConstraint ("CC7", classCliff, 20.0);
	int AvoidPlayerMed			= rmCreateClassDistanceConstraint ("CC8", classPlayer, 5.0);
	int AvoidIsland				= rmCreateClassDistanceConstraint ("CC9", classIsland, rmRandFloat(25,35));
	int AvoidForestShort		= rmCreateClassDistanceConstraint ("CC10", classForest, rmRandInt(12.0,18.0));
	int AvoidStartingSettleLong	= rmCreateClassDistanceConstraint ("CC11", classSettlement, 80.0);
	int AvoidPlayerCore			= rmCreateClassDistanceConstraint ("CC12", classPlayerCore, 20.0);
	int AvoidPassage			= rmCreateClassDistanceConstraint ("CC13", classPassage, 10.0);
	int AvoidChainIsland		= rmCreateClassDistanceConstraint ("CC14", classChain, 15.0);
	int AvoidPlayerCoreLong		= rmCreateClassDistanceConstraint ("CC15", classPlayerCore, 40.0);
	int AvoidIslandShort		= rmCreateClassDistanceConstraint ("CC16", classIsland, 20);
	
	int AvoidImpassableLand	= rmCreateTerrainDistanceConstraint("CTR1", "land", false, 5.0);
	int AvoidShore			= rmCreateTerrainDistanceConstraint("CTR2", "land", true, 8.0);
	
	int NearShore			= rmCreateTerrainMaxDistanceConstraint("CTM1", "land", true, 12.0);
	
	rmSetStatusText("",0.20);
	///OBJECT DEFINITION
	//Starting objects
	int IDStartingSettlement 	= rmCreateObjectDef("starting settlement");
	rmAddObjectDefItem			(IDStartingSettlement, "Settlement Level 1", 1, 0.0);
	rmSetObjectDefMinDistance	(IDStartingSettlement, 0.0);
	rmSetObjectDefMaxDistance	(IDStartingSettlement, 0.0);
	rmAddObjectDefToClass    	(IDStartingSettlement, classSettlement);
	
	int GoldDistance = rmRandInt(10,32);
	
	int IDStartingGold		 	= rmCreateObjectDef("starting gold");
	
	if (StartingGoldIsSmall) { 
		rmAddObjectDefItem		(IDStartingGold, "gold mine tiny", 1, 0.0);
	} else if (StartingGoldIsLarge) {
		rmAddObjectDefItem		(IDStartingGold, "gold mine", 1, 0.0);
	} else {
		rmAddObjectDefItem		(IDStartingGold, "gold mine small", 1, 0.0);
	}
	rmSetObjectDefMinDistance	(IDStartingGold, GoldDistance);
	rmSetObjectDefMaxDistance	(IDStartingGold, GoldDistance);
	rmAddObjectDefConstraint	(IDStartingGold, AvoidAll);
	rmAddObjectDefConstraint	(IDStartingGold, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDStartingGold, AvoidImpassableLand);
	
	int IDStartingTower		 	= rmCreateObjectDef("starting tower");
	rmAddObjectDefItem       	(IDStartingTower, "Tower", 1, 0.0);
	rmSetObjectDefMinDistance	(IDStartingTower, 20.0);
	rmSetObjectDefMaxDistance	(IDStartingTower, 30.0);
	rmAddObjectDefToClass    	(IDStartingTower, classTower);
	rmAddObjectDefConstraint	(IDStartingTower, AvoidTower);
	rmAddObjectDefConstraint	(IDStartingTower, AvoidAll);
	rmAddObjectDefConstraint	(IDStartingTower, AvoidEdgeShort);
	
	int IDStartingHunt		 	= rmCreateObjectDef("starting hunt");
	rmAddObjectDefItem       	(IDStartingHunt, GetHuntable(), rmRandInt(1,9), 4.0);
	rmSetObjectDefMinDistance	(IDStartingHunt, 15.0);
	rmSetObjectDefMaxDistance	(IDStartingHunt, 26.0);
	rmAddObjectDefConstraint	(IDStartingHunt, AvoidAll);
	rmAddObjectDefConstraint	(IDStartingHunt, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDStartingHunt, AvoidImpassableLand);
	
	int IDStartingFood		 	= rmCreateObjectDef("starting food");
	rmAddObjectDefItem       	(IDStartingFood, GetOtherFood(), rmRandInt(1,12), 4.0);
	rmSetObjectDefMinDistance	(IDStartingFood, 20.0);
	rmSetObjectDefMaxDistance	(IDStartingFood, 30.0);
	rmAddObjectDefConstraint	(IDStartingFood, AvoidAll);
	rmAddObjectDefConstraint	(IDStartingFood, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDStartingFood, AvoidImpassableLand);
	
	int IDStartingAnimal	 	= rmCreateObjectDef("starting animal");
	rmAddObjectDefItem       	(IDStartingAnimal, GetLandAnimal(), rmRandInt(1,3), 4.0);
	rmSetObjectDefMinDistance	(IDStartingAnimal, 20.0);
	rmSetObjectDefMaxDistance	(IDStartingAnimal, 30.0);
	rmAddObjectDefConstraint	(IDStartingAnimal, AvoidAll); 
	rmAddObjectDefConstraint	(IDStartingAnimal, AvoidEdgeShort); 
	rmAddObjectDefConstraint	(IDStartingAnimal, AvoidImpassableLand); 
	
	int IDStartingHerd		 	= rmCreateObjectDef("starting herd");
	rmAddObjectDefItem       	(IDStartingHerd, GetHerdable(), rmRandInt(1,6), 4.0);
	rmSetObjectDefMinDistance	(IDStartingHerd, 20.0);
	rmSetObjectDefMaxDistance	(IDStartingHerd, 30.0);
	rmAddObjectDefConstraint	(IDStartingHerd, AvoidAll); 
	rmAddObjectDefConstraint	(IDStartingHerd, AvoidEdgeShort); 
	rmAddObjectDefConstraint	(IDStartingHerd, AvoidImpassableLand); 
	
	int IDStartingTower2	 	= rmCreateObjectDef("starting tower 2");
	rmAddObjectDefItem       	(IDStartingTower2, GetTowerType(), 1, 0.0);
	rmSetObjectDefMinDistance	(IDStartingTower2, 20.0);
	rmSetObjectDefMaxDistance	(IDStartingTower2, 28.0);
	rmAddObjectDefToClass    	(IDStartingTower2, classTower);
	rmAddObjectDefConstraint	(IDStartingTower2, AvoidTower);
	rmAddObjectDefConstraint	(IDStartingTower2, AvoidAll);
	rmAddObjectDefConstraint	(IDStartingTower2, AvoidImpassableLand);
	rmAddObjectDefConstraint	(IDStartingTower2, AvoidEdgeShort);
	
	int IDStandardFish		 	= rmCreateObjectDef("fish");
	rmAddObjectDefItem       	(IDStandardFish, GetFishType(), 3, 9.0);
	rmSetObjectDefMinDistance	(IDStandardFish, 0.0);
	rmSetObjectDefMaxDistance	(IDStandardFish, 250.0);
	rmAddObjectDefConstraint	(IDStandardFish, AvoidFish);
	rmAddObjectDefConstraint	(IDStandardFish, AvoidShore);
	
	int IDStandardFish2		 	= rmCreateObjectDef("fish2");
	rmAddObjectDefItem       	(IDStandardFish2, GetFishType(), 3, 9.0);
	rmSetObjectDefMinDistance	(IDStandardFish2, 0.0);
	rmSetObjectDefMaxDistance	(IDStandardFish2, 250.0);
	rmAddObjectDefConstraint	(IDStandardFish2, AvoidFish);
	rmAddObjectDefConstraint	(IDStandardFish2, AvoidShore);
	
	int IDStragglerTree			= rmCreateObjectDef("straggler trees");
	rmAddObjectDefItem			(IDStragglerTree, GetRandomTree(), 1, 0.0);
	rmSetObjectDefMinDistance	(IDStragglerTree, 10.0);
	rmSetObjectDefMaxDistance	(IDStragglerTree, 18.0);
	
	int IDRandomTree			= rmCreateObjectDef("random trees");
	rmAddObjectDefItem			(IDRandomTree, GetRandomTree(), 1, 0.0);
	rmSetObjectDefMinDistance	(IDRandomTree, 0.0);
	rmSetObjectDefMaxDistance	(IDRandomTree, rmXFractionToMeters(0.5));
	rmAddObjectDefConstraint	(IDRandomTree, AvoidAll);
	
	//medium objects
	int IDMediumHunt		 	= rmCreateObjectDef("medium hunt");
	rmAddObjectDefItem       	(IDMediumHunt, GetWeakHuntable(), rmRandInt(2,7), 4.0);
	rmSetObjectDefMinDistance	(IDMediumHunt, 50.0);
	rmSetObjectDefMaxDistance	(IDMediumHunt, 70.0);
	rmAddObjectDefConstraint	(IDMediumHunt, AvoidAll);
	rmAddObjectDefConstraint	(IDMediumHunt, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDMediumHunt, AvoidHunt);
	rmAddObjectDefConstraint	(IDMediumHunt, AvoidImpassableLand);
	rmAddObjectDefConstraint	(IDMediumHunt, AvoidBonusIsland);
	rmAddObjectDefConstraint	(IDMediumHunt, AvoidChainIsland);
	
	if (BuildRiver) {
		rmAddObjectDefConstraint	(IDMediumHunt, AvoidPassage);
	}
	
	int IDMediumGold		 	= rmCreateObjectDef("medium gold");
	rmAddObjectDefItem       	(IDMediumGold, "gold mine", 1, 0.0);
	rmSetObjectDefMinDistance	(IDMediumGold, 50.0);
	rmSetObjectDefMaxDistance	(IDMediumGold, 70.0);
	rmAddObjectDefConstraint	(IDMediumGold, AvoidAll);
	rmAddObjectDefConstraint	(IDMediumGold, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDMediumGold, AvoidGold);
	rmAddObjectDefConstraint	(IDMediumGold, AvoidImpassableLand);
	rmAddObjectDefConstraint	(IDMediumGold, AvoidBonusIsland);
	rmAddObjectDefConstraint	(IDMediumGold, AvoidChainIsland);
	
	if (BuildRiver) {
		rmAddObjectDefConstraint	(IDMediumGold, AvoidPassage);
	}
	
	int IDMediumHerd		 	= rmCreateObjectDef("medium herd");
	rmAddObjectDefItem       	(IDMediumHerd, GetHerdable(), rmRandInt(1,4), 3.0);
	rmSetObjectDefMinDistance	(IDMediumHerd, 50.0);
	rmSetObjectDefMaxDistance	(IDMediumHerd, 100.0);
	rmAddObjectDefConstraint	(IDMediumHerd, AvoidAll);
	rmAddObjectDefConstraint	(IDMediumHerd, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDMediumHerd, AvoidHerdable);
	rmAddObjectDefConstraint	(IDMediumHerd, AvoidImpassableLand);
	
	if (BuildRiver) {
		rmAddObjectDefConstraint	(IDMediumHerd, AvoidPassage);
	}
	
	//far objects
	int IDFarGold			 	= rmCreateObjectDef("far gold");
	rmAddObjectDefItem       	(IDFarGold, "gold mine", 1, 0.0);
	rmSetObjectDefMinDistance	(IDFarGold, 70.0);
	rmSetObjectDefMaxDistance	(IDFarGold, 135.0);
	rmAddObjectDefConstraint	(IDFarGold, AvoidAll);
	rmAddObjectDefConstraint	(IDFarGold, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDFarGold, AvoidGold);
	
	rmAddObjectDefConstraint	(IDFarGold, AvoidImpassableLand);
	
	if (BuildRiver) {
		rmAddObjectDefConstraint	(IDFarGold, AvoidPassage);
	}
	
	if (BuildIslands || BuildChainLands) {
		rmAddObjectDefConstraint	(IDFarGold, AvoidPlayerShort);	
	}
	
	int IDFarHunt			 	= rmCreateObjectDef("far hunt");
	rmAddObjectDefItem       	(IDFarHunt, GetHuntable(), rmRandInt(1,12), 5.0);
	rmSetObjectDefMinDistance	(IDFarHunt, 75.0);
	rmSetObjectDefMaxDistance	(IDFarHunt, 130.0);
	rmAddObjectDefConstraint	(IDFarHunt, AvoidAll);
	rmAddObjectDefConstraint	(IDFarHunt, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDFarHunt, AvoidHunt);
	rmAddObjectDefConstraint	(IDFarHunt, AvoidImpassableLand);
	rmAddObjectDefConstraint	(IDFarHunt, AvoidPlayerShort);
	
	if (BuildRiver) {
		rmAddObjectDefConstraint	(IDFarHunt, AvoidPassage);
	}
	
	int IDBonusHunt			 	= rmCreateObjectDef("bonus hunt");
	rmAddObjectDefItem       	(IDBonusHunt, GetHuntable(), rmRandInt(2,8), 5.0);
	rmSetObjectDefMinDistance	(IDBonusHunt, 75.0);
	rmSetObjectDefMaxDistance	(IDBonusHunt, 130.0);
	rmAddObjectDefConstraint	(IDBonusHunt, AvoidAll);
	rmAddObjectDefConstraint	(IDBonusHunt, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDBonusHunt, AvoidHunt);
	rmAddObjectDefConstraint	(IDBonusHunt, AvoidImpassableLand);
	rmAddObjectDefConstraint	(IDBonusHunt, AvoidPlayerShort);
	
	int IDBonusGold			 	= rmCreateObjectDef("bonus gold");
	rmAddObjectDefItem       	(IDBonusGold, "Gold mine", 1, 0.0);
	rmSetObjectDefMinDistance	(IDBonusGold, 80.0);
	rmSetObjectDefMaxDistance	(IDBonusGold, 110.0);
	rmAddObjectDefConstraint	(IDBonusGold, AvoidAll);
	rmAddObjectDefConstraint	(IDBonusGold, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDBonusGold, AvoidGold);
	rmAddObjectDefConstraint	(IDBonusGold, AvoidImpassableLand);
	rmAddObjectDefConstraint	(IDBonusGold, AvoidPlayerShort);
	
	int IDFarAnimal			 	= rmCreateObjectDef("far animal");
	rmAddObjectDefItem       	(IDFarAnimal, GetLandAnimal(), rmRandInt(1,6), 5.0);
	rmSetObjectDefMinDistance	(IDFarAnimal, 75.0);
	rmSetObjectDefMaxDistance	(IDFarAnimal, 110.0);
	rmAddObjectDefConstraint	(IDFarAnimal, AvoidAll);
	rmAddObjectDefConstraint	(IDFarAnimal, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDFarAnimal, AvoidFood);
	rmAddObjectDefConstraint	(IDFarAnimal, AvoidImpassableLand);
	rmAddObjectDefConstraint	(IDFarAnimal, AvoidPlayerShort);
	
	if (BuildRiver) {
		rmAddObjectDefConstraint	(IDFarAnimal, AvoidPassage);
	}
	
	int IDFarPredator		 	= rmCreateObjectDef("far pred");
	rmAddObjectDefItem       	(IDFarPredator, GetPredator(), rmRandInt(1,4), 5.0);
	rmSetObjectDefMinDistance	(IDFarPredator, 60.0);
	rmSetObjectDefMaxDistance	(IDFarPredator, 120.0);
	rmAddObjectDefConstraint	(IDFarPredator, AvoidAll);
	rmAddObjectDefConstraint	(IDFarPredator, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDFarPredator, AvoidPredator);
	rmAddObjectDefConstraint	(IDFarPredator, AvoidImpassableLand);
	
	//other ded
	int IDRelic				 	= rmCreateObjectDef("relic");
	rmAddObjectDefItem       	(IDRelic, "relic", 1, 0.0);
	rmSetObjectDefMinDistance	(IDRelic, 0.0);
	rmSetObjectDefMaxDistance	(IDRelic, 150.0);
	rmAddObjectDefConstraint	(IDRelic, AvoidAll);
	rmAddObjectDefConstraint	(IDRelic, AvoidEdgeShort);
	rmAddObjectDefConstraint	(IDRelic, AvoidStartingSettleMed);
	rmAddObjectDefConstraint	(IDRelic, AvoidImpassableLand);
	rmAddObjectDefConstraint	(IDRelic, AvoidRelic);
	
	rmSetStatusText("",0.35);
	///DEFINE PLAYER LOCATIONS
	if (BuildChainLands) {
		rmPlacePlayersCircular(0.40, 0.43, rmDegreesToRadians(3.0));
	} else if (BuildCenterLand) {
		rmPlacePlayersCircular(0.25, 0.35, rmDegreesToRadians(3.0));
	} else {
		rmPlacePlayersCircular(0.25, 0.40, rmDegreesToRadians(5.0));
	}
	
	rmSetStatusText("",0.40);
	/// Connection Definition Start
    int IslandConnection		  	  = rmCreateConnection("IslandConection1");
	
	if (ClusterConnection) {
		rmSetConnectionType				  (IslandConnection, cConnectAreas, false, 100);
		rmSetConnectionWidth			  (IslandConnection, 15, 2);
	} else if (BuildLine) {
		rmSetConnectionType				  (IslandConnection, cConnectPlayers, false, 100);
		rmSetConnectionWidth			  (IslandConnection, rmRandFloat(50,80), 2);
	} else {
	//	rmSetConnectionType				  (IslandConnection, cConnectAreas, false, 0);
	//	rmSetConnectionWidth			  (IslandConnection, rmRandFloat(20,30), 2);
	}
		
	if (BuildRiver) {
		rmSetConnectionType				  (IslandConnection, cConnectPlayers, false, 100);
		rmSetConnectionWidth			  (IslandConnection, rmRandFloat(20,50), 2);
	}
	rmSetConnectionBaseHeight		  (IslandConnection, 7.0);
	rmSetConnectionSmoothDistance	  (IslandConnection, 3.0);
	
	string ConnectionTerrainType = "GrassA";
	
	if  (UseInsaneTextures)
		ConnectionTerrainType  = GetInsaneWalkableTerrainType();
	else ConnectionTerrainType = GetNormalWalkableTerrainType();
	rmAddConnectionTerrainReplacement (IslandConnection, "RiverSandyA", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "RiverSandyB", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "RiverSandyC", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "RiverSandyShallowA", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "RiverGrassyA", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "RiverGrassyB", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "RiverGrassyC", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "RiverIcyA", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "RiverIcyB", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "RiverIcyC", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "RiverMarshA", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "RiverMarshB", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "RiverMarshC", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "Black", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineAegeanA", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineAegeanB", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineAegeanC", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineAtlanticA", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineAtlanticB", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineAtlanticC", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineMediterraneanA", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineMediterraneanB", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineMediterraneanC", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineMediterraneanD", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineNorwegianA", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineNorwegianB", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineNorwegianC", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineRedSeaB", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineRedSeaA", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineRedSeaC", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineSandA", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineTundraA", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineTundraB", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineTundraC", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "ShorelineTundraD", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "UnderwaterIceA", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "UnderwaterIceB", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "UnderwaterIceC", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "UnderwaterRockA", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "UnderwaterRockB", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "UnderwaterRockC", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "UnderwaterRockD", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "UnderwaterRockE", ConnectionTerrainType);
	rmAddConnectionTerrainReplacement (IslandConnection, "UnderwaterRockF", ConnectionTerrainType);
	rmSetConnectionPositionVariance	  (IslandConnection, -1);
	rmSetConnectionWarnFailure		  (IslandConnection, true);
	rmSetConnectionHeightBlend		  (IslandConnection, 2);
	rmAddConnectionToClass			  (IslandConnection, classPassage);
	rmAddConnectionStartConstraint	  (IslandConnection, AvoidPassage);
	rmAddConnectionStartConstraint	  (IslandConnection, AvoidEdgeLong);
	rmAddConnectionEndConstraint	  (IslandConnection, AvoidPassage);
	rmAddConnectionEndConstraint	  (IslandConnection, AvoidEdgeLong);
	// Connection Definition End
	
	rmSetStatusText("",0.45);
	///AREA DEFINITION
	int IDCenterCore		= rmCreateArea("center core");
	rmSetAreaSize			(IDCenterCore, 0.001, 0.001);
	rmSetAreaLocation		(IDCenterCore, 0.5, 0.5);
	rmAddAreaToClass		(IDCenterCore, classCenter);
	rmBuildArea				(IDCenterCore); 
	
	if (BuildCenterLand) {
		int IDCenterLand		= rmCreateArea("center land");
		rmSetAreaSize			(IDCenterLand, 0.35, 0.60);
		rmSetAreaLocation		(IDCenterLand, 0.5, 0.5);
		rmAddAreaToClass		(IDCenterLand, classCenter);
		rmSetAreaBaseHeight		(IDCenterLand, 5.0);
		rmSetAreaTerrainType	(IDCenterLand, GetNormalWalkableTerrainType());
		rmSetAreaSmoothDistance	(IDCenterLand, 0);
		rmSetAreaHeightBlend	(IDCenterLand, 2);
		rmAddAreaConstraint		(IDCenterLand, AvoidEdgeShort);
		rmSetAreaMinBlobs		(IDCenterLand, 0);
		rmSetAreaMaxBlobs		(IDCenterLand, 5);
		rmBuildArea				(IDCenterLand); 
	}

	for(i=1; <cNumberPlayers)
		{
			int AreaPlayerCore		 = rmCreateArea("PlayerCore"+i);
	
			rmSetPlayerArea			(i, AreaPlayerCore);
			rmSetAreaSize			(AreaPlayerCore, rmAreaTilesToFraction(200), rmAreaTilesToFraction(200));
			rmAddAreaToClass		(AreaPlayerCore, classPlayer);
			rmSetAreaLocPlayer		(AreaPlayerCore, i);
			rmAddAreaToClass		(AreaPlayerCore, classPlayerCore);
			rmSetAreaBaseHeight		(AreaPlayerCore, 2);
			rmSetAreaHeightBlend	(AreaPlayerCore, 2);
			
			rmBuildArea(AreaPlayerCore);
		}
		//rmBuildAllAreas();
	
	float playerFraction=rmAreaTilesToFraction(rmRandInt(2200,3500));
	
	if (BuildCenterLand)
	{
		for(i=1; <cNumberPlayers)
		{
			int AreaPlayer			= rmCreateArea("Player"+i);
			rmSetPlayerArea			(i, AreaPlayer);
			rmSetAreaSize			(AreaPlayer, 0.45*playerFraction, 0.5*playerFraction);
			rmAddAreaToClass		(AreaPlayer, classPlayer);
			rmAddAreaToClass		(AreaPlayer, classIsland);
			rmSetAreaMinBlobs		(AreaPlayer, 1);
			rmSetAreaMaxBlobs		(AreaPlayer, 3);
			rmSetAreaMinBlobDistance(AreaPlayer, 10.0);
			rmSetAreaMaxBlobDistance(AreaPlayer, 15.0);
			rmSetAreaBaseHeight		(AreaPlayer, 5.0);
			rmSetAreaSmoothDistance	(AreaPlayer, 10);
			rmSetAreaHeightBlend	(AreaPlayer, 2);
			rmSetAreaLocPlayer		(AreaPlayer, i);
			rmSetAreaCoherence		(AreaPlayer, 0.5);
			
			if (UseInsaneTextures)
				 rmSetAreaTerrainType	(AreaPlayer, GetInsaneWalkableTerrainType());
			else rmSetAreaTerrainType	(AreaPlayer, GetNormalWalkableTerrainType());

		}
		rmBuildAllAreas();
	}
	
	if (BuildPlayerAreaIsland)
	{
		for(i=1; <cNumberPlayers)
		{
			AreaPlayer			= rmCreateArea("Player"+i);
			rmSetPlayerArea			(i, AreaPlayer);
			rmSetAreaSize			(AreaPlayer, 0.9*playerFraction, 1.1*playerFraction);
			rmAddAreaToClass		(AreaPlayer, classPlayer);
			rmAddAreaToClass		(AreaPlayer, classIsland);
			rmSetAreaMinBlobs		(AreaPlayer, 1);
			rmSetAreaMaxBlobs		(AreaPlayer, 3);
			rmSetAreaMinBlobDistance(AreaPlayer, 10.0);
			rmSetAreaMaxBlobDistance(AreaPlayer, 15.0);
			rmSetAreaBaseHeight		(AreaPlayer, 5.0);
			rmSetAreaSmoothDistance	(AreaPlayer, 10);
			rmSetAreaHeightBlend	(AreaPlayer, 2);
			rmSetAreaLocPlayer		(AreaPlayer, i);
			rmSetAreaCoherence		(AreaPlayer, 0.5);
			
			if (ClusterConnection)
				rmAddConnectionArea(IslandConnection, AreaPlayer);


			if (rmRandFloat(0,1) < 0.4) {
				rmAddAreaConstraint(AreaPlayer, AvoidCenter);
			}
			
			if (UseInsaneTextures)
				 rmSetAreaTerrainType	(AreaPlayer, GetInsaneWalkableTerrainType());
			else rmSetAreaTerrainType	(AreaPlayer, GetNormalWalkableTerrainType());

			rmAddAreaConstraint(AreaPlayer, AvoidIsland); 
			rmAddAreaConstraint(AreaPlayer, AvoidEdgeMed); 
		}
		rmBuildAllAreas();
	}
	
	if (BuildRiver)
	{
		for(i=1; <cNumberPlayers)
		{
			AreaPlayer			= rmCreateArea("Player"+i);
			rmSetPlayerArea			(i, AreaPlayer);
			rmSetAreaSize			(AreaPlayer, playerFraction*4.5, playerFraction*4.5);
			rmAddAreaToClass		(AreaPlayer, classPlayer);
			rmAddAreaToClass		(AreaPlayer, classIsland);
			rmSetAreaMinBlobs		(AreaPlayer, 1);
			rmSetAreaMaxBlobs		(AreaPlayer, 3);
			rmSetAreaMinBlobDistance(AreaPlayer, 10.0);
			rmSetAreaMaxBlobDistance(AreaPlayer, 15.0);
			rmSetAreaBaseHeight		(AreaPlayer, 5.0);
			rmSetAreaSmoothDistance	(AreaPlayer, 10);
			rmSetAreaHeightBlend	(AreaPlayer, 2);
			rmSetAreaLocPlayer		(AreaPlayer, i);
			rmSetAreaCoherence		(AreaPlayer, 0.0);

			if (rmRandFloat(0,1) < 0.25) {
				rmAddAreaConstraint(AreaPlayer, AvoidCenter);
			}
			
			if (UseInsaneTextures)
				 rmSetAreaTerrainType	(AreaPlayer, GetInsaneWalkableTerrainType());
			else rmSetAreaTerrainType	(AreaPlayer, GetNormalWalkableTerrainType());

			rmAddAreaConstraint(AreaPlayer, AvoidIsland); 
		}
		rmBuildAllAreas();
	}
	
	if (BuildBonusIslands) {
		for (i=0; < BonusNum)
		{
			int AreaBonusIsland		= rmCreateArea("BonusIsland"+i);
			rmSetAreaSize			(AreaBonusIsland, 0.3*playerFraction, 0.6*playerFraction);
			rmAddAreaToClass		(AreaBonusIsland, classIsland);
			rmAddAreaToClass		(AreaBonusIsland, classBonusIsland);
			rmSetAreaMinBlobs		(AreaBonusIsland, 1);
			rmSetAreaMaxBlobs		(AreaBonusIsland, 3);
			rmSetAreaMinBlobDistance(AreaBonusIsland, 10.0);
			rmSetAreaMaxBlobDistance(AreaBonusIsland, 15.0);
			rmSetAreaBaseHeight		(AreaBonusIsland, 5.0);
			rmSetAreaSmoothDistance	(AreaBonusIsland, 10);
			rmSetAreaHeightBlend	(AreaBonusIsland, 2);
			rmSetAreaCoherence		(AreaBonusIsland, 0.5);
			rmAddAreaConstraint		(AreaBonusIsland, AvoidIsland);
			
			if (ClusterConnection)
				rmAddConnectionArea( IslandConnection, AreaBonusIsland);
			
			if (UseInsaneTextures)
				 rmSetAreaTerrainType	(AreaBonusIsland, GetInsaneWalkableTerrainType());
			else rmSetAreaTerrainType	(AreaBonusIsland, GetNormalWalkableTerrainType());
			
			rmBuildArea(AreaBonusIsland);
		}
	}
	float ChainNum = rmRandInt(2,5);
	int tileCount = 2800; 
	if (BuildChainLands) {
		for (i=0; < ChainNum)
		{
			int AreaChainIsland		= rmCreateArea("ChainIsland"+i);
			rmSetAreaSize			(AreaChainIsland, 0.9*tileCount, 1.1*tileCount);
			rmAddAreaToClass		(AreaChainIsland, classChain);
			rmAddAreaConstraint		(AreaChainIsland, AvoidPlayerCoreLong);
			rmSetAreaMinBlobs		(AreaChainIsland, 1);
			rmSetAreaMaxBlobs		(AreaChainIsland, 3);
			rmSetAreaMinBlobDistance(AreaChainIsland, 10.0);
			rmSetAreaMaxBlobDistance(AreaChainIsland, 15.0);
			rmSetAreaBaseHeight		(AreaChainIsland, 5.0);
			rmSetAreaSmoothDistance	(AreaChainIsland, 10);
			rmSetAreaHeightBlend	(AreaChainIsland, 2);
			rmSetAreaCoherence		(AreaChainIsland, 0.5);
			rmAddAreaConstraint		(AreaChainIsland, AvoidEdgeLong);
			rmAddAreaConstraint		(AreaChainIsland, AvoidChainIsland);
			
			if (ConnectionAddBonus)
				rmAddConnectionArea( IslandConnection, AreaChainIsland);
			
			if (UseInsaneTextures)
				 rmSetAreaTerrainType	(AreaChainIsland, GetInsaneWalkableTerrainType());
			else rmSetAreaTerrainType	(AreaChainIsland, GetNormalWalkableTerrainType());
			
		}
		rmBuildAllAreas();
	}
	if (BuildPlayerAreaIslandChain)
			{for(i=1; <cNumberPlayers)
		{
			int AreaPlayerChain		= rmCreateArea("Playerchain"+i);
			rmSetPlayerArea			(i, AreaPlayerChain);
			rmSetAreaSize			(AreaPlayerChain, 1.9*playerFraction, 2.1*playerFraction);
			rmAddAreaToClass		(AreaPlayerChain, classPlayer);
			rmAddAreaToClass		(AreaPlayerChain, classIsland);
			rmSetAreaMinBlobs		(AreaPlayerChain, 1);
			rmSetAreaMaxBlobs		(AreaPlayerChain, 3);
			rmSetAreaMinBlobDistance(AreaPlayerChain, 10.0);
			rmSetAreaMaxBlobDistance(AreaPlayerChain, 15.0);
			rmSetAreaBaseHeight		(AreaPlayerChain, 5.0);
			rmSetAreaSmoothDistance	(AreaPlayerChain, 10);
			rmSetAreaHeightBlend	(AreaPlayerChain, 2);
			rmSetAreaLocPlayer		(AreaPlayerChain, i);
			rmSetAreaCoherence		(AreaPlayerChain, 0.5);
			
			if (ConnectionAddPlayer)
				rmAddConnectionArea(IslandConnection, AreaPlayerChain);


			if (rmRandFloat(0,1) < 0.4) {
				rmAddAreaConstraint(AreaPlayerChain, AvoidCenter);
			}
			
			if (UseInsaneTextures)
				 rmSetAreaTerrainType	(AreaPlayerChain, GetInsaneWalkableTerrainType());
			else rmSetAreaTerrainType	(AreaPlayerChain, GetNormalWalkableTerrainType());

			rmAddAreaConstraint(AreaPlayerChain, AvoidChainIsland);  
			rmAddAreaConstraint(AreaPlayerChain, AvoidIslandShort);  
		}
		rmBuildAllAreas();
	}
	
	if (BuildConnections)
	{
		rmBuildConnection(IslandConnection);
	}
	
	for(i=0; < amountBeautyPatchesA)
	{
		int AreaPatch			= rmCreateArea("patch A"+i);
		rmSetAreaSize			(AreaPatch, rmAreaTilesToFraction(10), rmAreaTilesToFraction(150));
		
		if (UseInsaneTextures)
			 rmSetAreaTerrainType	(AreaPatch, GetInsaneWalkableTerrainType());
		else rmSetAreaTerrainType	(AreaPatch, GetNormalWalkableTerrainType());
		
		rmSetAreaMinBlobs		(AreaPatch, 1);
		rmSetAreaMaxBlobs		(AreaPatch, 5);
		rmSetAreaMinBlobDistance(AreaPatch, 16.0);
		rmSetAreaMaxBlobDistance(AreaPatch, 40.0);
		rmSetAreaCoherence		(AreaPatch, 0.0);
		
		rmBuildArea(AreaPatch);
	}
	
	for(i=0; < amountElevPatchesA)
	{
		int AreaElev			= rmCreateArea("Elev A"+i);
		rmSetAreaSize			(AreaElev, rmAreaTilesToFraction(30), rmAreaTilesToFraction(150));
		rmSetAreaMinBlobs		(AreaElev, 1);
		rmSetAreaMaxBlobs		(AreaElev, 5);
		rmSetAreaMinBlobDistance(AreaElev, 16.0);
		rmSetAreaMaxBlobDistance(AreaElev, 40.0);
		rmSetAreaCoherence		(AreaElev, 0.0);
		rmSetAreaBaseHeight		(AreaElev, rmRandInt(2,7));
		rmSetAreaHeightBlend	(AreaElev, 2);
		rmAddAreaConstraint		(AreaElev, AvoidImpassableLand);
		
		rmBuildArea(AreaElev);
	}
	rmSetStatusText("",0.60);
	///SETTLEMENTS
	
	rmPlaceObjectDefPerPlayer (IDStartingSettlement, true);
	if (BuildRiver) {
		int AreaSettle=rmAddFairLoc("Settlement", false, true,  50, 80, 40, 15);
		rmAddFairLocConstraint(AreaSettle, AvoidImpassableLand);
		
		AreaSettle=rmAddFairLoc("Settlement", true, false,  65, 100, 50, 16);
		rmAddFairLocConstraint(AreaSettle, AvoidImpassableLand);
	} else if (BuildChainLands) {
		AreaSettle=rmAddFairLoc("Settlement", false, true,  50, 90, 40, 15);
		rmAddFairLocConstraint(AreaSettle, AvoidImpassableLand);
		
		AreaSettle=rmAddFairLoc("Settlement", true, false,  60, 100, 70, 16);
		rmAddFairLocConstraint(AreaSettle, AvoidPlayerMed);
		rmAddFairLocConstraint(AreaSettle, AvoidImpassableLand);
	} else {
		AreaSettle=rmAddFairLoc("Settlement", false, true,  40, 80, 40, 15);
		rmAddFairLocConstraint(AreaSettle, AvoidImpassableLand);
		
		AreaSettle=rmAddFairLoc("Settlement", true, false,  45, 85, 50, 16);
		rmAddFairLocConstraint(AreaSettle, AvoidImpassableLand);
	}
	
	if (BuildLine == false || BuildChainLands == false) {
		rmAddFairLocConstraint(AreaSettle, AvoidPassage);
	}
	
	if (ThirdSettlement) {
		AreaSettle=rmAddFairLoc("Settlement", false, false,  80, 120, 60, 20);
		rmAddFairLocConstraint(AreaSettle, AvoidImpassableLand);
		rmAddFairLocConstraint(AreaSettle, AvoidPassage);
		if (BuildIslands) {
			rmAddFairLocConstraint(AreaSettle, AvoidPlayerShort);
		}
	}
	
	if(rmPlaceFairLocs())
	{
		AreaSettle=rmCreateObjectDef("far settlement2");
		rmAddObjectDefItem(AreaSettle, "Settlement", 1, 0.0);
		for(i=1; <cNumberPlayers)
		{
			for(j=0; <rmGetNumberFairLocs(i))
				rmPlaceObjectDefAtLoc(AreaSettle, i, rmFairLocXFraction(i, j), rmFairLocZFraction(i, j), 1);
		}
	}
	rmSetStatusText("",0.65);
	///PLACE OBJECTS
	if (FishChance) {
		rmPlaceObjectDefPerPlayer (IDStandardFish, false, rmRandInt(5,12));
		rmPlaceObjectDefPerPlayer (IDStandardFish2, false, rmRandInt(2,10));
	}
	
	rmPlaceObjectDefPerPlayer (IDStartingGold, false, 1);
	rmPlaceObjectDefPerPlayer (IDStartingHunt, false, rmRandInt(0,2));
	rmPlaceObjectDefPerPlayer (IDStartingFood, false, rmRandInt(1,2));
	rmPlaceObjectDefPerPlayer (IDStartingHerd, true, rmRandInt(0,2));
	rmPlaceObjectDefPerPlayer (IDStragglerTree, false, rmRandInt(1,12));
	
	if (rmRandFloat(0,1) < 0.1) {
		rmPlaceObjectDefPerPlayer (IDStartingAnimal, false, 1);
	}
	
	if (TowerChance < 0.10) {
		rmPlaceObjectDefPerPlayer (IDStartingTower2, true, 4);
	} else if (TowerChance < 0.4) {
		rmPlaceObjectDefPerPlayer (IDStartingTower, true, 4);
	} else {
		rmPlaceObjectDefPerPlayer (IDStartingTower, true, 3);
		rmPlaceObjectDefPerPlayer (IDStartingTower2, true, 1);
	}
	
	rmPlaceObjectDefPerPlayer (IDMediumHunt, false, rmRandInt(0,1));
	rmPlaceObjectDefPerPlayer (IDMediumGold, false, 1);
	rmPlaceObjectDefPerPlayer (IDMediumHerd, false, rmRandInt(0,4));
	
	rmPlaceObjectDefPerPlayer (IDFarGold, false, rmRandInt(1,4));
	rmPlaceObjectDefPerPlayer (IDFarHunt, false, rmRandInt(0,2));
	rmPlaceObjectDefPerPlayer (IDFarAnimal, false, rmRandInt(0,1));
	rmPlaceObjectDefPerPlayer (IDFarPredator, false, rmRandInt(1,2));
	
	if (BuildChainLands) {
		rmPlaceObjectDefPerPlayer (IDBonusHunt, false, rmRandInt(1,4));
		rmPlaceObjectDefPerPlayer (IDBonusGold, false, rmRandInt(0,1));
	}
	
	if (MonsterRelics) {
		rmPlaceObjectDefPerPlayer (IDRelic, false, rmRandInt(2,8));
	} else 
	rmPlaceObjectDefPerPlayer (IDRelic, false, rmRandInt(1,2));

	rmSetStatusText("",0.75);
	///FORESTS
	int forestCount = rmRandInt(8,12)*cNumberNonGaiaPlayers;
	int failCount=0;
		
		for(i=0; <forestCount)
		{
			int IDForest			= rmCreateArea("forest"+i);
			rmSetAreaSize			(IDForest, rmAreaTilesToFraction(40), rmAreaTilesToFraction(150));
			rmSetAreaWarnFailure	(IDForest, false);
			rmSetAreaForestType 	(IDForest, GetForestType());
			rmAddAreaConstraint 	(IDForest, AvoidSettlementSlightly);
			rmAddAreaConstraint 	(IDForest, AvoidAllLong);
			rmAddAreaConstraint 	(IDForest, AvoidForest);
			rmAddAreaConstraint 	(IDForest, AvoidImpassableLand);
			rmAddAreaConstraint 	(IDForest, AvoidStartingSettle);
			rmAddAreaToClass		(IDForest, classForest);
			
			rmSetAreaMinBlobs		(IDForest, 0);
			rmSetAreaMaxBlobs		(IDForest, 2);
			rmSetAreaMinBlobDistance(IDForest, 16.0);
			rmSetAreaMaxBlobDistance(IDForest, 22.0);
			rmSetAreaCoherence		(IDForest, 0.1);
	
			if(rmBuildArea(IDForest)==false)
			{
				// Stop trying once we fail 3 times in a row.
				failCount++;
				if(failCount==3)
					break;
			}
			else
				failCount=0;
		}
		
	rmPlaceObjectDefAtLoc (IDRandomTree, 0, 0.5, 0.5, rmRandFloat(10,25)*cNumberNonGaiaPlayers);
	
	rmSetStatusText("",0.85);
	//BEAUTIFICATION
	//water beautification
	if (SpawnsBeautificationWaterPads)
	{
		int IDLily					= rmCreateObjectDef("pads");
		rmAddObjectDefItem			(IDLily, "water lilly", rmRandInt(3,5), 4.0);
		rmSetObjectDefMinDistance	(IDLily, 0.0);
		rmSetObjectDefMaxDistance	(IDLily, rmXFractionToMeters(0.5));
		rmAddObjectDefConstraint	(IDLily, AvoidAll);
		rmPlaceObjectDefAtLoc		(IDLily, 0, 0.5, 0.5, rmRandFloat(1,5)*cNumberNonGaiaPlayers);
	}

	if (SpawnsBeautificationWaterWeed)
	{
		int IDSeaweed				= rmCreateObjectDef("seaweed");
		rmAddObjectDefItem			(IDSeaweed, "seaweed", rmRandFloat(1,5), 3.0);
		rmSetObjectDefMinDistance	(IDSeaweed, 0.0);
		rmSetObjectDefMaxDistance	(IDSeaweed, rmXFractionToMeters(0.5));
		rmAddObjectDefConstraint	(IDSeaweed, AvoidAll);
		rmAddObjectDefConstraint	(IDSeaweed, NearShore);
		rmAddObjectDefConstraint	(IDSeaweed, AvoidShore);
		rmPlaceObjectDefAtLoc		(IDSeaweed, 0, 0.5, 0.5, rmRandFloat(1,6)*cNumberNonGaiaPlayers);
	}
	
	//normal beautification
	if (SpawnsBeautificationGrass)
	{
		int IDGrass					=rmCreateObjectDef("grass");
		rmAddObjectDefItem			(IDGrass, "grass", 1, 0.0);
		rmSetObjectDefMinDistance	(IDGrass, 0.0);
		rmSetObjectDefMaxDistance	(IDGrass, rmXFractionToMeters(0.5));
		rmAddObjectDefConstraint	(IDGrass, AvoidAll);
		rmAddObjectDefConstraint	(IDGrass, AvoidImpassableLand);
		rmPlaceObjectDefAtLoc		(IDGrass, 0, 0.5, 0.5, 30*cNumberNonGaiaPlayers);
	}

	if (SpawnsBeautificationRock)
	{
		int IDRock				 	 = rmCreateObjectDef("rock");
		rmAddObjectDefItem		 	 (IDRock, "rock granite sprite", 1, 0.0);
		rmSetObjectDefMinDistance	 (IDRock, 0.0);
		rmSetObjectDefMaxDistance	 (IDRock, rmXFractionToMeters(0.5));
		rmAddObjectDefConstraint 	 (IDRock, AvoidAll);
		rmPlaceObjectDefAtLoc	 	 (IDRock, 0, 0.5, 0.5, 20*cNumberNonGaiaPlayers);
	}

	if (SpawnsBeautificationRune)
	{
		int IDRune				 	 = rmCreateObjectDef("runestone");
		rmAddObjectDefItem		 	 (IDRune, "runestone", 1, 0.0);
		rmSetObjectDefMinDistance	 (IDRune, 0.0);
		rmSetObjectDefMaxDistance	 (IDRune, rmXFractionToMeters(0.5));
		rmAddObjectDefConstraint 	 (IDRune, AvoidAll);
		rmAddObjectDefConstraint 	 (IDRune, AvoidSettlementSlightly);
		rmAddObjectDefConstraint 	 (IDRune, rmCreateTypeDistanceConstraint("Rune vs Rune", "runestone", 70.0));
		rmPlaceObjectDefAtLoc	 	 (IDRune, 0, 0.5, 0.5, 2*cNumberNonGaiaPlayers);
	}

	if (SpawnsBeautificationFlowers)
	{
		int IDFlowers				= rmCreateObjectDef("flowers");
		rmAddObjectDefItem			(IDFlowers, "flowers", rmRandInt(1.0, 3.0), 4.0);
		rmSetObjectDefMinDistance	(IDFlowers, 0.0);
		rmSetObjectDefMaxDistance	(IDFlowers, rmXFractionToMeters(0.5));
		rmAddObjectDefConstraint	(IDFlowers, AvoidAll);
		rmAddObjectDefConstraint	(IDFlowers, AvoidImpassableLand);
		rmPlaceObjectDefAtLoc		(IDFlowers, 0, 0.5, 0.5, 5*cNumberNonGaiaPlayers);
	}
	
	if (SpawnsBeautificationDrift)
	{
		int IDSandDrift				= rmCreateObjectDef("blowing sand");
		rmAddObjectDefItem			(IDSandDrift, "sand drift patch", 1, 0.0);
		rmSetObjectDefMinDistance	(IDSandDrift, 0.0);
		rmSetObjectDefMaxDistance	(IDSandDrift, rmXFractionToMeters(0.5));
		rmAddObjectDefConstraint	(IDSandDrift, AvoidAll);
		rmAddObjectDefConstraint	(IDSandDrift, AvoidEdgeMed);
		rmAddObjectDefConstraint	(IDSandDrift, AvoidStartingSettleMed);
		rmPlaceObjectDefAtLoc		(IDSandDrift, 0, 0.5, 0.5, rmRandFloat(1,5)*cNumberNonGaiaPlayers);
	}
	rmSetStatusText("",0.95);
}
	
void main(void)
{
	///INITIALIZE MAP
	rmSetStatusText("",0.01);
	
	bool isWaterMap = Chance(40);
	
	rmSetSeaLevel(rmRandInt(-1,4));
	rmSetGaiaCiv(cCivZeus);	

	if (isWaterMap) WaterMap();
	else LandMap();
	
	rmSetStatusText("",1.00);
}