#include <iostream>
#include <string>
#include "cpu.h"
#include <locale.h>
using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
	int Qsize, time, yadres;
	double powerCPU, powerQue;
	Qsize = 100;
	yadres = 4; 
	powerCPU = 2;
	powerQue = 2;
	time = 2;
	CPUssor cpussor1;
	cpussor1.Work(Qsize, time, yadres, powerCPU, powerQue);
	return 0;
}