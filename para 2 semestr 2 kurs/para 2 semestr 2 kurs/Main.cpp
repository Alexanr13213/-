#include "Header.h"
int main() {
	List L;
	for (int i = 1; i < 6; i++) L.add(i);
	L.print();
	L.print_back();
	L.insert(2, 200);
	if (!L.remove(5)) cout << "not found";
	L.print();
	L.print_back();
}
