# Task 2 Game 360 Sweeney Repository
Task 2 Project

# Falling Coin Collector

GAME 360 - Aidan Sweeney

 

## How to play

Use A and D or the left and right arrow keys to control the player.
You're trying to collect coins as they fall to get points.
If you miss a coin you lose a life.
You have 3 lives till the game ends.

 

## Singleton

Class: GameManager.cs

What it holds: score and lives and restarts the game

Why it's a singleton: It makes sure that it keeps only one GameManager running at a time.

 

## Observer

Event: ScoreChanged in GameManager

Listener 1: ScoreUI - It updates the score text when the score changes.

Listener 2: CoinSound.cs - It plays a sound when the score changes.

 

## Help I used

Copilot- It helped with syntax errors and troubleshooting for when I couldn't find out what the problem was. It also helped me figure out what unity wanted me to type to get my methods working.
https://youtu.be/ThKWyHW4K5Y?si=mna279A7dXCaCCYI A video that helped me understand how to make the player collect coins.
https://youtu.be/NaJODwP_L0s?si=rxav_5B4Zkk32kAD This helped me understand how to set up my Observer patterns.