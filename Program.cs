using System;

abstract class Geographical_object
{
    int coordinate_x;
    int coordinate_y;
    string name;
    string description;
    string method_of_obtaining_information = "virtual";

}

class River : Geographical_object
{
    int speed;
    int lenght;
}

class Mountain : Geographical_object
{
    int highest_point;

}