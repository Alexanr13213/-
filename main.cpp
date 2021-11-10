#include <iostream>
#include "tbitfield.h"
#include <iomanip>
#include <conio.h>

int main(int argc, char* argv[])
{

	TBitField  Elem1(12);
	TBitField  Elem2;
	TBitField  Elem3=Elem1;
	if (Elem1 == Elem3)
		std::printf("Kakoyto tekst");

	Elem1.clear();
	Elem2.clear();
	Elem3.clear();
	system("pause");
	return 0;
};