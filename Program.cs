﻿//  Guided project for students grade calculator

int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;


int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;


int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;


int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

Console.WriteLine("Student   Grade");
Console.WriteLine($"Sophia    {(decimal)(sophia1+sophia2+sophia3+sophia4+sophia5) / currentAssignments}   A");
Console.WriteLine($"Nicolas   {(decimal)(nicolas1+nicolas2+nicolas3+nicolas4+nicolas5) / currentAssignments}   B");
Console.WriteLine($"Zahirah   {(decimal)(zahirah1+zahirah2+zahirah3+zahirah4+zahirah5) / currentAssignments}   B");
Console.WriteLine($"Jeong     {(decimal)(jeong1+jeong2+jeong3+jeong4+jeong5) / currentAssignments}   A");

