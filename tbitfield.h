// ННГУ, ВМК, Курс "Методы программирования-2", С++, ООП
//
// tbitfield.h - Copyright (c) Гергель В.П. 07.05.2001
//   Переработано для Microsoft Visual Studio 2008 Сысоевым А.В. (19.04.2015)
//
// Битовое поле

#ifndef __BITFIELD_H__
#define __BITFIELD_H__

#include <iostream>

using namespace std;

typedef int TELEM;

class TBitField
{
private:
	int  BitLen; // длина битового поля - макс. к-во битов
	int _razmer;
	TELEM* pMem; // память для представления битового поля
	int  MemLen, Elem; // к-во эл-тов Мем для представления бит.поля
	/*
	// методы реализации
	int   GetMemIndex(const int n) const; // индекс в pМем для бита n       (#О2)
	TELEM GetMemMask(const int n) const; // битовая маска для бита n       (#О3)
	*/
public:
				   //                                   (#О1)
	TBitField(const TBitField& bf);  //                                   (#П1)

	TBitField(int Elem);

	TBitField();

	~TBitField();
	// доступ к битам
	int GetLength(void) const;      // получить длину (к-во битов)           (#О)
	void SetBit(const int i);       // установить бит                       (#О4)
	void ClrBit(const int i);       // очистить бит                         (#П2)
	int  GetBit(const int i) const; // получить значение бита               (#Л1)
	TELEM* operator=(const TBitField& bf); // присваивание              (#П3)
	int operator==(const TBitField& bf); // сравнение 
	int operator!=(const TBitField& bf); // сравнение
	void clear();
	//TBitField  operator~(void);                // отрицание                  (#С)
	
};
	// 
	
	// битовые операции
	
	
	/*
	
	                (#О5)
	TBitField  operator|(const TBitField& bf); // операция "или"            (#О6)
	TBitField  operator&(const TBitField& bf); // операция "и"              (#Л2)

	friend istream& operator>>(istream& istr, TBitField& bf);       //      (#О7)
	friend ostream& operator<<(ostream& ostr, const TBitField& bf); //      (#П4)
};
// Структура хранения битового поля
//   бит.поле - набор битов с номерами от 0 до BitLen
//   массив pМем рассматривается как последовательность MemLen элементов
//   биты в эл-тах pМем нумеруются справа налево (от младших к старшим)
// О8 Л2 П4 С2
*/
#endif