// ННГУ, ВМК, Курс "Методы программирования-2", С++, ООП
//
// tbitfield.cpp - Copyright (c) Гергель В.П. 07.05.2001
//   Переработано для Microsoft Visual Studio 2008 Сысоевым А.В. (19.04.2015)
//
// Битовое поле

#include "tbitfield.h"
// Fake variables used as placeholders in tests
//static const int FAKE_INT = -1;
//static TBitField FAKE_BITFIELD(1);
//static TBitField FAKE_BITFIELD1(0);

TBitField::TBitField(int Elem)
{
    std::printf("Constructor \n");
    int razmer,ostatok,buffer;
    buffer = Elem;
    if (Elem < 16 and Elem >= 0) { razmer = 4; }
    if (Elem > 16 and Elem < 255) { razmer = 8; }
    if (Elem >= 256 and Elem < 4095) { razmer = 12; }
    if (Elem >=4095 and Elem < 4294967295) { razmer = 32; }
    this->_razmer = razmer;

    this->pMem = new TELEM[razmer];
    for (int i = razmer - 1; i >= 0; i--) 
    {
        ostatok = buffer % 2;
        buffer = buffer / 2;
        pMem[i] = ostatok;
    }
 }
TBitField::TBitField() // конструктор по умолчанию
{
    int razmer = 32;
    std::printf("Constructor po umolchaniu ");
    this->pMem = new TELEM[razmer];
    this->_razmer = razmer;
    for (int i = 0; i < razmer; i++)
    {
        this->pMem[i] = 0;
    }
}
TBitField::TBitField(const TBitField& bf) // конструктор копирования
{   
    std::printf("\n konstr cop ");
    _razmer = bf.GetLength();
    std::printf("%d,",_razmer);
    this->pMem = new TELEM[_razmer];
    if (pMem != NULL)
    {
        for (int i = 0; i < _razmer; i++)
        {
            this->pMem[i] = bf.GetBit(i);
            cout << pMem[i];
        }

    }
        
 
}

TBitField::~TBitField() // деструктор
{
    delete[] pMem;
}
void TBitField::clear()
{
   this->~TBitField();
}

int TBitField::GetLength(void) const // получить длину (к-во битов)
{
    //std::printf("\n razmer");
    return this->_razmer;
}

void TBitField::SetBit(const int i) // установить бит
{
    pMem[i] = 1;
    cout << pMem[i];
}

void TBitField::ClrBit(const int i) // очистить бит
{
    pMem[i] = 0;
}

int TBitField::GetBit(const int i) const // получить значение бита
{
    //cout<< this->pMem[i]<<" ";
    return pMem[i];
}

/*TBitField TBitField::operator~(void) // отрицание
{
    int i;
    for (i = _razmer; i >= 0; i--) {
        if (pMem[i] = 1)
            pMem[i] = 0;
        else
            pMem[i] = 1;
    }
}

/*
int TBitField::GetMemIndex(const int n) const // индекс Мем для бита n
{
    return FAKE_INT;
}

TELEM TBitField::GetMemMask(const int n) const // битовая маска для бита n
{
    return FAKE_INT;
}

// доступ к битам битового поля

// битовые операции
*/
TELEM* TBitField::operator=(const TBitField& bf) // присваивание
{
    _razmer = bf.GetLength();
    this->pMem = new TELEM[_razmer];
        for (int i = 0; i < _razmer; i++)
        {
            this->pMem[i] = bf.GetBit(i);
            cout << pMem[i];
        }
        return this->pMem;
}

int TBitField::operator==(const TBitField& bf) // сравнение
{
    int i;
    _razmer = bf.GetLength();
    this->pMem = new TELEM[_razmer];
    for (i = 0; i < _razmer; i++)
    {
        if (pMem[i] != bf.GetBit(i)) { return 0; }
        std::printf("%d ", i );
    }
    return 1;
}

int TBitField::operator!=(const TBitField& bf) // сравнение
{
    return ;
}
/*
TBitField TBitField::operator|(const TBitField& bf) // операция "или"
{
    return FAKE_BITFIELD;
}

TBitField TBitField::operator&(const TBitField& bf) // операция "и"
{
    return FAKE_BITFIELD;
}



// ввод/вывод
/*
istream& operator>>(istream& istr, TBitField& bf) // ввод
{
    return istr;
}

ostream& operator<<(ostream& ostr, const TBitField& bf) // вывод
{
    return ostr;
}
*/