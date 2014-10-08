// Celsius to Fahrenheit.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <cstdio>
#include <cstdlib>
#include <iostream>

int _tmain(int argc, _TCHAR* argv[])
{

	double celsius;
	std::cout << "Enter the temperature in Celsius : ";
	std::cin >> celsius;

	double fahrenheit;
	fahrenheit = (celsius * 1.8) + 32;

	std::cout << "Fahrenheit value is : ";
	std::cout << fahrenheit << std::endl;

	system("PAUSE");
	return 0;
}

