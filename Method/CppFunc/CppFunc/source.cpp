#include "Student.h"
#include <iostream>

int main() {
	Student *pStu = new Student();
	pStu->SayHello();
	double x = 30;
	double y = 40;
	double result = pStu->Add(x, y);
	std::cout << result;
	return 0;
}