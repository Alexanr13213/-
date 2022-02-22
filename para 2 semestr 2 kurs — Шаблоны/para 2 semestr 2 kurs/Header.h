#include <iostream>
#include <cstdlib>

using namespace std;

template <class Data> class List {
	class Node {
	public:
		int d;
		Node* next;
		Node* prev;
		Node(int dat = 0) {d = dat; next = 0; prev = 0;}
	};
	Node *pbeg, *pend;
public:
	List() { pbeg = 0; pend = 0; };
	~List();
	void add(Data d);
	Node *find(Data d);
	Node *insert(Data key, Data d);
	bool remove(Data key);
	void print();
	void print_back();

	template <class Data>
	bool remove(Data key) {
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
			return 1;
		}
		return 0;
	}

	template <class Data>
	List::Node* insert(Data key, Data d) {
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
	template <class Data>
	void add(Data d) {
		Node* pv = new Node(d);
		if (pbeg == 0)pbeg = pend = pv;
		else {
			pv->prev = pend;
			pend->next = pv;
			pend = pv;
		}
	}

	template <class Data>
	List::Node* find(Data d)
	{
		Node* pv = pbeg;
		while (pv) {
			if (pv->d == d)break;
			pv = pv->next;
		}
		return pv;
	}
};

template <class Data> void List<Data>::print() {
	Node* pv = pbeg;
	cout << endl << "list: ";
	while (pv) {
		cout << pv->d << " ";
		pv = pv->next;
	}
	cout << endl;
}

template <class Data>
void List<Data>::print_back() {
	Node* pv = pend;
	cout << endl << "list back: ";
	while (pv) {
		cout << pv->d << " ";
		pv = pv->prev;
	}
	cout << endl;
}

template <class Data>
List <Data>::~List()
{
	if (pbeg != 0) {
		Node* pv = pbeg;
		while (pv) {
			pv = pv->next; delete pbeg;
			pbeg = pv;
		}
	}
};


