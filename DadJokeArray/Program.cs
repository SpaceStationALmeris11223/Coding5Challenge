﻿using System;

class Program{
    static void Main(){


var rand = new Random();
string [] DadJokes = new string [12];
DadJokes [0] = "What kind of felines can bowl? Alley cats.";
DadJokes [1] = "What has five toes and isn't your foot? My foot.";
DadJokes [2] = "What’s the best way to get the hospital after breaking your foot? With a tow truck.";
DadJokes [3] = "Why did the rabbit go to the salon? It was having a bad hare day.";
DadJokes [4] = "What's a witch's favorite subject in school? Spelling.";
DadJokes [5] = "What's the easiest building to lift? A lighthouse.";
DadJokes [6] = "Why shouldn't you tell secrets in a cornfield? There are too many ears all around.";
DadJokes [7] = "What do you call it when a cow grows facial hair? A moo-stache.";
DadJokes [8] = "Did you hear about the two rowboats that got into an argument? It was an oar-deal.";
DadJokes [9] = "Did you hear about the cleaners who went to space? They ended up scrubbing the mission.";
DadJokes [10] = "Why do turkeys play percussion? They have drumsticks.";
DadJokes [11] = "I adopted a dog from a blacksmith. As soon as I brought him home, he made a bolt for the door.";

string YorN = "yes";
int Numb = rand.Next(1,13); //creates a number between 1-12

    //Ask the user if they'd like another joke
    while (YorN.ToLower() == "yes")
    {
        //The code below will randomly select a dad joke
        int Dad1 = rand.Next(0, DadJokes.Length);
        int Dad2 = rand.Next(0, DadJokes.Length);
        //The code below makes sure that the 2 jokes are different
        if (Dad1 == Dad2) {
            Dad2 = rand.Next(0, DadJokes.Length);
        }
        //The new jokes will be displayed below
        Console.WriteLine($"The first Joke: {DadJokes[Dad1]}");
        Console.WriteLine($"The first Joke: {DadJokes[Dad2]}");
    
    Console.WriteLine("Would you like to hear more jokes? Enter Yes or No");
    YorN = Console.ReadLine();    
    }
    //Exit message
    Console.WriteLine("We hope you had laugh with our Dad Joke Dispenser. Have a great day");
 }
}