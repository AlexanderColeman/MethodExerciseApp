using MethodExercise;



Methods method = new Methods();

var name = method.GetString("what is your name");
var color = method.GetString("what is your favorite color");
var animal = method.GetString("what is your favorite animal");
var profession = method.GetString("what do you do for work");

string newstring = ($"Today we are going to learn about {name}. {name}'s favorite color is {color} and his favoite animal is {animal}. He is an aspiring {profession}," +
    $"and hopes to one day make a living doing just that.");

Console.WriteLine(newstring);


//exercise two
 
int x = 45;
int y = 5;
method.Add();
method.Subtract(54,24);

var product = method.Mulitply(x, y);
var quotient = method.Divide(x, y);
var methodProduct = method.Mulitply(product, quotient);

Console.WriteLine($"\nNext we will do some Multiplication and Division of two numbers {x} and {y}. " +
    $"the product of these two numbers is {product} and the quotient is: {quotient}. and if we wanted to multiply those two values we could do that also which is: {methodProduct}");


int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
method.AddParam(ints);

