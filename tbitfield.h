// ����, ���, ���� "������ ����������������-2", �++, ���
//
// tbitfield.h - Copyright (c) ������� �.�. 07.05.2001
//   ������������ ��� Microsoft Visual Studio 2008 �������� �.�. (19.04.2015)
//
// ������� ����

#ifndef __BITFIELD_H__
#define __BITFIELD_H__

#include <iostream>

using namespace std;

typedef int TELEM;

class TBitField
{
private:
	int  BitLen; // ����� �������� ���� - ����. �-�� �����
	int _razmer;
	TELEM* pMem; // ������ ��� ������������� �������� ����
	int  MemLen, Elem; // �-�� ��-��� ��� ��� ������������� ���.����
	/*
	// ������ ����������
	int   GetMemIndex(const int n) const; // ������ � p��� ��� ���� n       (#�2)
	TELEM GetMemMask(const int n) const; // ������� ����� ��� ���� n       (#�3)
	*/
public:
				   //                                   (#�1)
	TBitField(const TBitField& bf);  //                                   (#�1)

	TBitField(int Elem);

	TBitField();

	~TBitField();
	// ������ � �����
	int GetLength(void) const;      // �������� ����� (�-�� �����)           (#�)
	void SetBit(const int i);       // ���������� ���                       (#�4)
	void ClrBit(const int i);       // �������� ���                         (#�2)
	int  GetBit(const int i) const; // �������� �������� ����               (#�1)
	TELEM* operator=(const TBitField& bf); // ������������              (#�3)
	int operator==(const TBitField& bf); // ��������� 
	int operator!=(const TBitField& bf); // ���������
	void clear();
	//TBitField  operator~(void);                // ���������                  (#�)
	
};
	// 
	
	// ������� ��������
	
	
	/*
	
	                (#�5)
	TBitField  operator|(const TBitField& bf); // �������� "���"            (#�6)
	TBitField  operator&(const TBitField& bf); // �������� "�"              (#�2)

	friend istream& operator>>(istream& istr, TBitField& bf);       //      (#�7)
	friend ostream& operator<<(ostream& ostr, const TBitField& bf); //      (#�4)
};
// ��������� �������� �������� ����
//   ���.���� - ����� ����� � �������� �� 0 �� BitLen
//   ������ p��� ��������������� ��� ������������������ MemLen ���������
//   ���� � ��-��� p��� ���������� ������ ������ (�� ������� � �������)
// �8 �2 �4 �2
*/
#endif