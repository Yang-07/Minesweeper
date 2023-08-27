<h1 class="code-line" data-line-start=0 data-line-end=1 ><a id="Minesweeper_Console_Game_0"></a>Minesweeper Console Game</h1>
<h2 class="code-line" data-line-start=1 data-line-end=2 ><a id="Liam_Liu_Avepoint_1"></a>Liam Liu, Avepoint</h2>
<p class="has-line-data" data-line-start="2" data-line-end="3">Welcome to the Minesweeper Console Game! This application simulates the classic Minesweeper game on a square grid. Players can reveal squares to uncover numbers indicating the adjacent mines or detonate mines.</p>
<h2 class="code-line" data-line-start=4 data-line-end=5 ><a id="Table_of_Contents_4"></a>Table of Contents</h2>
<ul>
<li class="has-line-data" data-line-start="6" data-line-end="7">Introduction</li>
<li class="has-line-data" data-line-start="7" data-line-end="8">Design and Assumptions</li>
<li class="has-line-data" data-line-start="8" data-line-end="9">Usage</li>
<li class="has-line-data" data-line-start="9" data-line-end="10">Gameplay</li>
<li class="has-line-data" data-line-start="10" data-line-end="11">Contributing</li>
<li class="has-line-data" data-line-start="11" data-line-end="13">License</li>
</ul>
<h2 class="code-line" data-line-start=13 data-line-end=14 ><a id="Introduction_13"></a>Introduction</h2>
<p class="has-line-data" data-line-start="15" data-line-end="16">This Minesweeper Console Game is a C# application that provides an interactive Minesweeper gaming experience through the command line interface. Players can select grid size and mine count, and then reveal squares to uncover adjacent mine information.</p>
<h2 class="code-line" data-line-start=17 data-line-end=18 ><a id="Design_and_Assumptions_17"></a>Design and Assumptions</h2>
<p class="has-line-data" data-line-start="18" data-line-end="19">The application follows the principles of clean code and modularity. The codebase is organized into three main classes:</p>
<ol>
<li class="has-line-data" data-line-start="20" data-line-end="21">MinesweeperGame (Main class): Responsible for managing the game loop and user interactions.</li>
<li class="has-line-data" data-line-start="21" data-line-end="22">PlayGame: Handles the core game logic, including initializing the grid, placing mines, and processing user inputs.</li>
<li class="has-line-data" data-line-start="22" data-line-end="24">Grid: Manages grid-related operations such as initializing the grid and displaying it.</li>
</ol>
<p class="has-line-data" data-line-start="24" data-line-end="25">Some assumptions made during the development include:</p>
<ul>
<li class="has-line-data" data-line-start="26" data-line-end="27">The grid size is limited to a range of 2 to 10.</li>
<li class="has-line-data" data-line-start="27" data-line-end="28">The number of mines is limited to 35% of the total squares in the grid.</li>
<li class="has-line-data" data-line-start="28" data-line-end="29">The game is played using the keyboard in a command line environment.</li>
<li class="has-line-data" data-line-start="29" data-line-end="31">The player can restart the game after each round.</li>
</ul>
<h2 class="code-line" data-line-start=31 data-line-end=32 ><a id="Usage_31"></a>Usage</h2>
<h4 class="code-line" data-line-start=32 data-line-end=33 ><a id="Prerequisites_32"></a>Prerequisites</h4>
<p class="has-line-data" data-line-start="33" data-line-end="34">.NET Core SDK (3.1 or later) installed on your machine.</p>
<h4 class="code-line" data-line-start=34 data-line-end=35 ><a id="Running_the_Game_34"></a>Running the Game</h4>
<ol>
<li class="has-line-data" data-line-start="35" data-line-end="36">Clone this repository to your local machine or download the code as a ZIP file.</li>
<li class="has-line-data" data-line-start="36" data-line-end="37">Open a command prompt or terminal window.</li>
<li class="has-line-data" data-line-start="37" data-line-end="38">Navigate to the directory containing the code files.</li>
<li class="has-line-data" data-line-start="38" data-line-end="39">Run the following command to build the application:</li>
</ol>
<pre><code class="has-line-data" data-line-start="40" data-line-end="42" class="language-sh">dotnet build
</code></pre>
<ol start="5">
<li class="has-line-data" data-line-start="42" data-line-end="43">Run the following command to start the Minesweeper game:</li>
</ol>
<pre><code class="has-line-data" data-line-start="44" data-line-end="46" class="language-sh">dotnet run
</code></pre>
<h2 class="code-line" data-line-start=47 data-line-end=48 ><a id="Gameplay_47"></a>Gameplay</h2>
<ol>
<li class="has-line-data" data-line-start="48" data-line-end="49">Start the game by entering the grid size (2 to 10) and the number of mines (within limits).</li>
<li class="has-line-data" data-line-start="49" data-line-end="50">The game displays the initial grid with underscores representing unrevealed squares.</li>
<li class="has-line-data" data-line-start="50" data-line-end="51">Enter a square to reveal (e.g., A1) and follow the prompts.</li>
<li class="has-line-data" data-line-start="51" data-line-end="52">If you reveal a mine, the game ends. Otherwise, numbers indicate adjacent mines.</li>
<li class="has-line-data" data-line-start="52" data-line-end="54">Win the game by revealing all non-mine squares.</li>
</ol>
<h2 class="code-line" data-line-start=54 data-line-end=55 ><a id="Contributing_54"></a>Contributing</h2>
<p class="has-line-data" data-line-start="55" data-line-end="56">Contributions to this Minesweeper Console Game are welcome! Feel free to submit issues and pull requests to enhance the game.</p>
<h2 class="code-line" data-line-start=56 data-line-end=57 ><a id="License_56"></a>License</h2>
<p class="has-line-data" data-line-start="57" data-line-end="58">This Minesweeper Console Game is licensed under the Avepoint.</p>