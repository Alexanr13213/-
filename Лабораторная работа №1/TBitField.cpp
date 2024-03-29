#pragma once
#include "tbitfield.h"
TBitField::TBitField(int Elem)
{
	int razmer, ostatok, buffer;
	buffer = Elem;
	if (Elem < 16 and Elem >= 0) { razmer = 4; }
	if (Elem > 16 and Elem < 255) { razmer = 8; }
	if (Elem >= 256 and Elem < 4095) { razmer = 12; }
	if (Elem >= 4095 and Elem < 4294967295) { razmer = 32; }
	this->_razmer = razmer;

	this->pMem = new TELEM[razmer];
	for (int i = 0; i < razmer; i++)
	{
		ostatok = buffer % 2;
		buffer = buffer / 2;
		pMem[i] = ostatok;
	}
}

TBitField::TBitField()
{
	this->_razmer = 0;
	this->pMem = nullptr;
}

TBitField::TBitField(const TBitField& bf)
{
	_razmer = bf.GetLength();
	std::printf("%d,", _razmer);
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

TBitField& TBitField::operator=(const TBitField& bf)
{
	std::printf("\n ��������=");
	this->_razmer = bf.GetLength();
	std::printf("\n! ������ = %d\n", bf.GetLength());
	std::printf("\n! ��� = %d\n", bf.GetBit(0));

	this->pMem = new TELEM[_razmer];

	for (int x = 0; x < _razmer; x++)
	{
		std::printf(" %d ", bf.GetBit(x));
	}

	for (int i = 0; i < _razmer; i++)
	{
		this->pMem[i] = bf.GetBit(i);
	}
	return *this;
}

TBitField::~TBitField()
{
	delete[] pMem;
}

int TBitField::GetLength(void) const
{
	return this->_razmer;
}

void TBitField::SetBit(const int i)
{
	pMem[i] = 1;
}

void TBitField::ClrBit(const int i)
{
	pMem[i] = 0;
}

int TBitField::GetBit(const int i) const
{
	return pMem[i];
}

void TBitField::print_array()
{
	std::printf("\n");
	int size = GetLength();
	std::printf("������ ������� %d \n", size);
	if (size == 0) return;
	for (int x = size - 1; x >= 0; x--)
	{
		std::printf(" %d[%d] ", pMem[x], x);
	}
}


bool TBitField::operator==(const TBitField& bf)
{


	this->_razmer = bf.GetLength();

	for (int i = 0; i < _razmer; i++)
	{
		std::printf("\n %d ", pMem[i]);
		std::printf(" %d", bf.GetBit(i));
		if (pMem[i] != bf.GetBit(i)) { return 0; }
	}
	return 1;
}

bool TBitField::operator!=(const TBitField& bf)
{
	std::printf("\noperator!=");
	this->_razmer = bf.GetLength();

	for (int i = 0; i < _razmer; i++)
	{
		std::printf("\n %d ", pMem[i]);
		std::printf(" %d", bf.GetBit(i));
		if (pMem[i] == bf.GetBit(i)) { return 0; }
	}
	return 1;
}

TBitField& TBitField::resize(int size)
{
	delete[] this->pMem;
	this->_razmer = size;
	this->pMem = new TELEM[_razmer];
	for (int x = 0; x < _razmer; x++) this->pMem[x] = 0;
	return *this;
}

TBitField TBitField::operator~(void)
{
	std::printf("\n �������� ~ ");
	int size_of_result = this->GetLength();
	TBitField result;  
	result.resize(size_of_result);  
	for (int i = 0; i < size_of_result; i++)
	{
		if (this->GetBit(i) == 0) result.SetBit(i);    
		std::printf("  %d ", result.GetBit(i));        
	}
	return result;
}

TBitField TBitField::operator|(const TBitField& bf)
{
	std::printf("\n �������� | ");

	TBitField result;
	int size_of_result = 0;
	if (this->_razmer > bf.GetLength())
	{
		size_of_result = this->_razmer;
	}
	else size_of_result = bf.GetLength();
	result.resize(size_of_result);
	for (int i = 0; i < _razmer; i++)
	{
		std::printf("\n%d ", bf.GetBit(i));
		std::printf("  %d ", this->pMem[i]);
		if (bf.GetBit(i) == 1 && this->pMem[i] == 1)
			result.SetBit(i);


		std::printf("  %d ", result.GetBit(i));
	}
	return result;
}

TBitField TBitField::operator>>(int k)
{
	std::printf("\n �������� >> ");
	int size_of_result = this->GetLength() - k;
	TBitField result;
	result.resize(size_of_result);

	for (int new_mas = size_of_result - 1, old_mas = this->GetLength() - 1; new_mas >= 0; new_mas--, old_mas--)
	{
		result.pMem[new_mas] = this->pMem[old_mas];    //
		std::printf("\n%d (%d)   %d (%d)", this->pMem[old_mas], old_mas, result.GetBit(new_mas), new_mas);
	}
	std::printf("\n result = ");
	result.print_array();
	return result;
}

TBitField TBitField::operator<<(int k)
{
	std::printf("\n �������� >> ");
	int size_of_result = this->GetLength() + k;
	TBitField result;
	result.resize(size_of_result);


	for (int new_mas = size_of_result - 1, old_mas = this->GetLength() - 1;
		new_mas >= k; new_mas--, old_mas--)
	{
		result.pMem[new_mas] = this->pMem[old_mas];    //
		std::printf("\n%d (%d)   %d (%d)", this->pMem[old_mas], old_mas, result.GetBit(new_mas), new_mas);
	}
	std::printf("\n result = ");
	result.print_array();
	return result;
}


TBitField TBitField::operator&(const TBitField& bf)
{
	std::printf("\n �������� | ");

	TBitField result;
	int size_of_result = 0;
	if (this->_razmer > bf.GetLength())
	{
		size_of_result = this->_razmer;
	}
	else size_of_result = bf.GetLength();
	result.resize(size_of_result);
	for (int i = 0; i < _razmer; i++)
	{
		std::printf("\n%d ", bf.GetBit(i));
		std::printf("  %d ", this->pMem[i]);
		if (bf.GetBit(i) == 1 && this->pMem[i] == 1)
			result.SetBit(i);
		std::printf("  %d ", result.GetBit(i));
	}
	return result;
}