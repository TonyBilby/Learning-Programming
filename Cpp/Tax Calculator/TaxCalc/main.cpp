
#include <iostream>
#include <math.h>

using namespace std;

int main(void){

	double taxperc, taxdec, subtot, tax, total;
	char again;
	do {
		system("cls");
		cout << "Tony's Easy Tax Calculator" << endl;
		cout << "Enter the tax percentage (Ex. 6.5 or 7): ";
		cin >> taxperc;
		cout << "Enter your subtotal: ";
		cin >> subtot;
		taxdec = taxperc / 100;
		total = ceilf((subtot * taxdec + subtot) * 100.0) / 100.0;
		tax = ceilf((subtot * taxdec) * 100.0) / 100.0;
		cout << endl << "Your tax is: $" << tax << endl << "Making your total: $" << total;

		cout << endl << endl << "Again? (y/n): ";
		cin >> again;
	}
	while (again == 'y');
	
	return 0;
}