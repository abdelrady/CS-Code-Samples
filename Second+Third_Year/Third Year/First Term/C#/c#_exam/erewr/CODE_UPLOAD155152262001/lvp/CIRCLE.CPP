
/* Lawrenceville Press CircleClass type IMPLEMENTATION */
/*	October 1997                                        */

//-----------------------------------------------------
CircleClass::CircleClass()
	:PI(3.14159)
{
}
//-----------------------------------------------------
void CircleClass::SetRadius(double R)
{
	Radius=R;
}

//-----------------------------------------------------
double CircleClass::Area() const
{
	return (PI*Radius*Radius);
}

//-----------------------------------------------------
double CircleClass::Circumference() const
{
	return (2*PI*Radius);
}
