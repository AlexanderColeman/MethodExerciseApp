using MethodExercise;

Methods method = new Methods();

var name = method.GetString("what is your name");
var color = method.GetString("What is your favorite Color");
var animal = method.GetString("what is your favorite animal");
var profession = method.GetString("What do you do for work");

string newString = ($"Today we are going to learn about {name}. {name}'s favorite color is {color} and his favoite animal is {animal}. he is an aspiring {profession}," +
    $"and hopes to one day make a living doing just that.");

Console.WriteLine(newString);
