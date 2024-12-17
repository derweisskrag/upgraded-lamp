Create a console application that represents a simplified version of a slot machine. 
The machine has a structure of 1 row and 3 columns.
Each column should contain 1 symbol as a result.
The symbol for each column should be taken randomly from maths.xls (column1, column2, column3).
If each column has the same symbol, the payout should be awarded.
"Wild" symbol can substitute for any other symbol to complete a winning combination.
The payout is calculated as the symbol win multiplier (maths.xls paytable) multiplied by the bet value.
For each spin, the bet amount should be deducted from the balance.
If there is a win, it should be added to the balance.
Win statistics should be collected and displayed at the end of each spin.
Reel and payout information presented in Excel file: maths.xls

The console application should ask for and read the following user input:
1. Starting balance (long)
2. Bet (long)
3. Number of spins (long)

User input example:
==========================================
Starting balance (in cents): 
1000
Bet (in cents):
10
Number of spins to play:
10
==========================================

Play log should have following entries for every spin:
1. Representation of reel machine: | Symbol name | Symbol name | Symbol name |
2. Spin log: Spin: #  Win, Balance

Play log example outcome:
==========================================
-------------------------------
|    Bar   |   Bar   |  Wild  |
-------------------------------
Spin: 0, Win: 10 (Bar), Balance: 1000

-------------------------------
|    777   |   Bar   |  Wild  |
-------------------------------
Spin: 1, Win: 0, Balance: 990

...
==========================================

At the end of all spins, the RTP (return to player) value should be displayed (formula is total bet / total win * 100.00), followed by the symbol win hits / total stats.

Win Stats example outcome:
==========================================
RTP: 210.00%, Spins: 10, Total bet: 100, Total win: 210
Win Stats:
  "777"     - 0 hit, Total win: 0
  "Cherry"  - 1 hit, Total win: 180
  "Bar"     - 3 hits, Total win: 30
  "Wild"    - 0 hit, Total win: 0
==========================================