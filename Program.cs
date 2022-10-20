//Reed Goodwin
//10-19-2022
//10-20-2022
//mini challenge #5
//This is a console project where you create your own story 
//There are 10 inputs to fill out and it will autofill your story
//Peer Review 




string stop = "";
while( stop != "no"){

Console.Clear();
Console.WriteLine("");
Console.WriteLine("Welcome to Reeds Madlib experience!!");
Console.WriteLine("");
Console.WriteLine("Please follow the directions below!!");
Console.WriteLine("");

Console.WriteLine("Name a Time of Day");
string time = Console.ReadLine();

Console.WriteLine("Name A Person");
string person = Console.ReadLine();

Console.WriteLine("Name a Feeling");
string feels = Console.ReadLine();

Console.WriteLine("Name a Place");
string place = Console.ReadLine();

Console.WriteLine("Name a car");
string car = Console.ReadLine();

Console.WriteLine("Name a Celebrity");
string celeb = Console.ReadLine();

Console.WriteLine("Name a Restaurant");
string food = Console.ReadLine();

Console.WriteLine("Name a Second Person");
string persontwo = Console.ReadLine();

Console.WriteLine("Name a Object");
string obj = Console.ReadLine();

Console.WriteLine("Name a Musician");
string music = Console.ReadLine();

Console.Write("One fine " + time + " our protagonist " + person + ",");
Console.WriteLine(" was feeling " + feels + " so they decided to");
Console.Write(" go for a drive to " + place + ". " );
Console.WriteLine("They walked out of the house and looked at their " + car + ". ");
Console.Write("They get in a start driving, while on the road they");
Console.Write(" stop for gas and spot " + celeb + ". 'Hey! Im a huge fan!' ");
Console.Write( person + " Says excitedly! " + celeb + " walks up and ");
Console.Write("asks to join you on the drive! You both get in a keep ");
Console.Write("Cruisin, While driving " + celeb + " Calls " + persontwo + " and ");
Console.Write("Invited them to come along! They pick up " + persontwo );
Console.Write(" and continue their drive! They arrive in " + place );
Console.Write($" and they decide to go to the restaurant, {food} " );
Console.Write($"They sat down and while they were eating they ");
Console.Write($"spotted {music} and {celeb} invites them over to join.");
Console.Write($" {music} walks over, sits down, and pulls out an {obj} and ");
Console.Write("sets it on the table to see everyones reaction. 'Woah how did you get that?'");
Console.Write($" {celeb} asked. 'Found it' {music} says, then {music} ");
Console.Write($"gets up to use the bathroom and {persontwo} immediatley grabs");
Console.Write($" the {obj} and gets up to leave, {person} and {celeb} both get");
Console.Write($" up and follow, they get outside and {persontwo} throws the {obj} ");
Console.Write($" into the street and runs off. Deciding to distamce themselves from");
Console.WriteLine($" the situation {person} and {celeb} decide to head home.");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Thank you For playing! WOuld you like to play again?");
Console.WriteLine("Please type 'yes or no'");
Console.WriteLine("");
stop = Console.ReadLine();
}