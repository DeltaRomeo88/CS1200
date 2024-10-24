using System;

// Class representing a character in the game
public class Character
{
    // Property for the character's name
    public string Name { get; set; }
    // Property for the character's health
    public int Health { get; set; }
    // Property for the character's attack power
    public int AttackPower { get; set; }

    // Constructor to initialize a character with name, health, and attack power
    public Character(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }
}

// Class representing an enemy attack
public class Enemy
{
    // Property for the enemy's name
    public string Name { get; set; }
    // Property for the enemy's health
    public int Health { get; set; }
    // Property for the enemy's attack power
    public int AttackPower { get; set; }

    // Constructor to initialize an enemy with name, health, and attack power
    public Enemy(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }
}

// Class containing the game logic
public class Game
{
    // Method to simulate a battle between a character and an enemy
    public static void Battle(Character character, Enemy enemy)
    {
        // Loop until either the character or the enemy is defeated
        while (character.Health > 0 && enemy.Health > 0)
        {
            // Character attacks the enemy
            enemy.Health -= character.AttackPower;
            Console.WriteLine($"{character.Name} attacks {enemy.Name} for {character.AttackPower} damage. {enemy.Name} has {enemy.Health} health left.");

            // Check if the enemy is defeated
            if (enemy.Health <= 0)
            {
                Console.WriteLine($"{enemy.Name} has been defeated!");
                break;
            }

            // Enemy attacks the character
            character.Health -= enemy.AttackPower;
            Console.WriteLine($"{enemy.Name} attacks {character.Name} for {enemy.AttackPower} damage. {character.Name} has {character.Health} health left.");

            // Check if the character is defeated
            if (character.Health <= 0)
            {
                Console.WriteLine($"{character.Name} has been defeated!");
                break;
            }
        }
    }

    // Main method to run the game
    public static void Main(string[] args)
    {
        // Create a new character and an enemy
        Character hero = new Character("Hero", 100, 20);
        Enemy goblin = new Enemy("Goblin", 50, 10);

        // Start the battle
        Battle(hero, goblin);
    }
}
