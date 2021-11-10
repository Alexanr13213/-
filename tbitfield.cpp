// ����, ���, ���� "������ ����������������-2", �++, ���
//
// tbitfield.cpp - Copyright (c) ������� �.�. 07.05.2001
//   ������������ ��� Microsoft Visual Studio 2008 �������� �.�. (19.04.2015)
//
// ������� ����

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
TBitField::TBitField() // ����������� �� ���������
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
TBitField::TBitField(const TBitField& bf) // ����������� �����������
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

TBitField::~TBitField() // ����������
{
    delete[] pMem;
}
void TBitField::clear()
{
   this->~TBitField();
}

int TBitField::GetLength(void) const // �������� ����� (�-�� �����)
{
    //std::printf("\n razmer");
    return this->_razmer;
}

void TBitField::SetBit(const int i) // ���������� ���
{
    pMem[i] = 1;
    cout << pMem[i];
}

void TBitField::ClrBit(const int i) // �������� ���
{
    pMem[i] = 0;
}

int TBitField::GetBit(const int i) const // �������� �������� ����
{
    //cout<< this->pMem[i]<<" ";
    return pMem[i];
}

/*TBitField TBitField::operator~(void) // ���������
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
int TBitField::GetMemIndex(const int n) const // ������ ��� ��� ���� n
{
    return FAKE_INT;
}

TELEM TBitField::GetMemMask(const int n) const // ������� ����� ��� ���� n
{
    return FAKE_INT;
}

// ������ � ����� �������� ����

// ������� ��������
*/
TELEM* TBitField::operator=(const TBitField& bf) // ������������
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

int TBitField::operator==(const TBitField& bf) // ���������
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

int TBitField::operator!=(const TBitField& bf) // ���������
{
    return ;
}
/*
TBitField TBitField::operator|(const TBitField& bf) // �������� "���"
{
    return FAKE_BITFIELD;
}

TBitField TBitField::operator&(const TBitField& bf) // �������� "�"
{
    return FAKE_BITFIELD;
}



// ����/�����
/*
istream& operator>>(istream& istr, TBitField& bf) // ����
{
    return istr;
}

ostream& operator<<(ostream& ostr, const TBitField& bf) // �����
{
    return ostr;
}
*/