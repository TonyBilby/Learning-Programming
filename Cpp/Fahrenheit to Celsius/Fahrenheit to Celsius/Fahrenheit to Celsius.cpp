// Fahrenheit to Celsius.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <cstdio>
#include <cstdlib>
#include <iostream>

int _tmain(int argc, _TCHAR* argv[])
{
	

	double fahrenheit;
	std::cout << "Enter the temperature in Fahrenheit : ";
	std::cin >> fahrenheit;

	double celsius;
	celsius = (fahrenheit - 32) * 5 / 9;

	std::cout << "Celsius value is : ";
	std::cout << celsius << std::endl;

	system("PAUSE");
	return 0;
}

