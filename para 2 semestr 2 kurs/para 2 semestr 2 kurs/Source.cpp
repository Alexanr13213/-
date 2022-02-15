#include "Header.h"
void List::add(int d) {
	Node* pv = new Node(d);
	if (pbeg == 0)pbeg = pend = pv;
	else {
		pv->prev = pend;
		pend->next = pv;
		pend = pv;
	}
}

Node * List::find(int d) {
	Node* pv = pbeg;
	while (pv) {
		if (pv->d == d)break;
		pv = pv->next;
	}
	return pv;
}

Node *List::insert(int key, int d) {
	if (Node* pkey = find(key)) {
		Node* pv = new Node(d);
		pv->next = pkey->next;
		pv->prev = pkey;
		pkey->next = pv;
		if (pkey != pend)(pv->next)->prev = pv;
		else pend = pv;
		return pv;
	}
	return 0;
}

bool List::remove(int key) {
	if (Node* pkey = find(key)) {
		if (pkey == pbeg) {
			pbeg = pbeg->next;
			pbeg->prev = 0;
		}
		else if (pkey == pend) {
			pend = pend->prev;
			pend->next = 0;
		}
		else {
			(pkey->prev)->next = pkey->next;
			(pkey->next)->prev = pkey->prev;
		}
		delete pkey;
		return true;
	}
	return false;
}

void List::print() {
	Node* pv = pbeg;
	cout << endl << "list: ";
	while (pv) {
		cout << pv->d << " ";
		pv = pv->next;
	}
	cout << endl;
}

void List::print_back() {
	Node* pv = pend;
	cout << endl << "list back: ";
	while (pv) {
		cout << pv->d << " ";
		pv = pv->prev;
	}
	cout << endl;
}

List::~List() {
	if (pbeg != 0) {
		Node* pv = pbeg;
		while (pv) {
			pv = pv->next;
			delete pbeg;
			pbeg = pv;
		}
	}
}