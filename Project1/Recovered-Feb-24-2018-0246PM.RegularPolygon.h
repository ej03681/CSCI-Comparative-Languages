#include <math.h>
#include <stdio.h>

class RegularPolygon {
public: 
	int sides = 1;
	double length = 1;
	double x = 0;
	double y = 0;
	
	RegularPolygon() {
		sides = 3;
		length = 1;
		x = 0;
		y = 0;
	}
	RegularPolygon(int newS, double newLength){
		sides = newS;
		length = newLength;
		x = 0;
		y = 0;
	}
	RegularPolygon(int newS, double newLength, double newX, double newY) {
		sides = newS;
		length = newLength;
		x = newX;
		y = newY;
	}
	double getPerimeter() {
		return length * sides;
	}
	double getArea() {
		return (sides * pow(length, 2) / (4 * tan(3.141592653589793 / sides)));
	}
	double getLength() {
		return length;
	}
	double getSides() {
		return sides;
	}
	void setLength(double newLength) {
		length = newLength;
	}
	void setSides(double newS) {
		sides = newS;
	}
	void set(int newS, double newLength, double newX, double newY) {
		sides = newS;
		length = newLength;
		x = newX;
		y = newY;
	}
	void set(int newS, double newLength) {
		sides = newS;
		length = newLength;
		x = 0;
		y = 0;
	}
};