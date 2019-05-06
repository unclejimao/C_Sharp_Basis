#include "Student.h"
#include <iostream>


Student::Student()
{
}


Student::~Student()
{
}

void Student::SayHello() {
	std::cout << "Hello, I'm a student!";
}

double Student::Add(double a, double b) {
	return a + b;
}