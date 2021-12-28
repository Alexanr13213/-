#include <iostream>
#pragma once

using namespace std;

typedef int TELEM;

class TBitField
{
private:
	int _razmer;
	TELEM* pMem; 
	int  MemLen, Elem; 
	int   GetMemIndex(const int n) const; 
	TELEM GetMemMask(const int n) const; 


public:
	TBitField(const TBitField& bf);  
	TBitField(int Elem);
	TBitField();

	TBitField& resize(int size);  

	~TBitField(); 
	int GetLength(void) const;     
	void SetBit(const int i);       
	void ClrBit(const int i);       
	int  GetBit(const int i) const; 
	TBitField& operator=(const TBitField& bf); 

	TBitField operator>>(int k); 
	TBitField operator<<(int k); 
	bool operator==(const TBitField& bf); 
	bool operator!=(const TBitField& bf); 
	TBitField operator|(const TBitField& bf); 
	TBitField operator~(void);

	TBitField  operator&(const TBitField& bf);
	void print_array();
	bool test();
}; 
