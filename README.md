# Dungeon-Cells

*Dungeon Cells* is a turn-based dungeon-crawling game implemented in C# using the SplashKit SDK. Players navigate through procedurally generated dungeons within a 3x3 grid, killing enemies and collecting coins.




## Features

- **Procedural Dungeon Generation:** The dungeon master generates new entities into empty cells, constantly shifting the situation in the dungeon.
  
- **Turn-Based Gameplay:** The player and the dungeon master each take turns, with players moving into new cells and interacting with entities, whilst the dungeon master moves the enemies around and generates new entities.
  
- **Grid-Based Movement:** The 3x3 grid environment can be navigated using arrow keys (Up, Down, Left, Right) or WASD keys.
  
- **Entity Interactions:** Encounter various entities such as enemies, treasures, weapons and potions, each impacting gameplay strategy.
  
- **Strategic Depth:** Manage player stats, plan movements, and make strategic decisions to survive and maximize your score.

## Getting Started

### Prerequisites

- Visual Studio with C# support
- SplashKit SDK (Installation instructions [here](https://splashkit.io/installation/))

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/jjv7/Dungeon-Cells.git

2. Open the solution file `DungeonCells.sln` in Visual Studio.

3. Build and run the project.

## Controls
- `Up Arrow Key` / `W Key`: Move the player up
- `Left Arrow Key` / `A Key`: Move the player left
- `Down Arrow Key`, `S Key`: Move the player down
- `Right Arrow Key` / `D Key`: Move the player right
- `ESC key`: Pause

## Credits

- **SplashKit SDK:** Graphics and input handling library used for game development.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
