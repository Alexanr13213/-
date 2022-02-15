#include <iostream>
#include <cstdlib>

using namespace std;

class List {
	class Node {
	public:
		int d;
		Node* next;
		Node* prev;
		Node(int dat = 0) {
			d = dat; next = 0; prev = 0;
		}
	};
	Node *pbeg, *pend;
public:
	List() { pbeg = 0; pend = 0;}
	~List();
	void add(int d);
	Node *find(int i);
	Node *insert(int key, int d);
	bool remove(int key);
	void print();
	void print_back();
};

