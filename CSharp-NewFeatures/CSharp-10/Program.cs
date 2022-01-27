using CSharp_10;

var a = new Test()
{
  P1 = new Test1()
};
var isTrue = a is { P1.P2: "" or null };
Console.WriteLine(isTrue);

const string b = "b";
const string b1 = "b1";
const string b2 = "b2";
const string c = $"{b}{b1}{b2}";

Point point = new()
{
  X = 1, Y = 2
};
// Initialization:
(int x, int y) = point;

// assignment:
int x1 = 0;
int y1 = 0;
(x1, y1) = point;

int x2 = 0;
(x2, int y2) = point;