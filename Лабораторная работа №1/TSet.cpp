#include "tset.h"
#pragma once
TSet::TSet(int mp) :MaxPower(mp), BitField(mp)
{
	BitField = TBitField(mp);
	MaxPower = mp;
}

TSet::TSet(const TSet& s) : MaxPower(s.MaxPower), BitField(s.BitField)
{
	BitField = s.BitField;
	MaxPower = s.MaxPower;
}

void  TSet::print_array()
{
	BitField.print_array();
}

TSet& TSet::operator=(const TSet& s) 
{
	this->BitField = s.BitField;
	this->MaxPower = s.GetMaxPower();
	return *this;
}

int TSet::GetMaxPower(void) const
{
	return MaxPower;
}

TSet::operator TBitField()
{
	std::printf("\nîïåğàòîğ TBitField()");
	return (TBitField)*this;
}

int TBitField::GetMemIndex(const int n) const 
{

	if ((n < 0) || (n >= _razmer))
		throw "íåâåğíûå äàííûå";
	return int(n / (sizeof(TELEM) * 8));

}

TELEM TBitField::GetMemMask(const int n) const  
{

	if ((n < 0) || (n >= _razmer))
		throw "íåâåğíûå äàííûå";
	return 1 << (n % (8 * sizeof(TELEM) - 1));

}

TSet TSet::operator<<(int k) 
{
	this->BitField = BitField << k;
	return *this;

}


bool TSet::operator==(const TSet& s) 
{

	return  (BitField == s.BitField);
}



TSet::TSet(const TBitField& bf)
{
	TSet(bf.GetLength());
}



int TSet::IsMember(int Elem) const 
{
	if (Elem < 0 || Elem >= MaxPower)
	{
		throw std::logic_error("ÍÅÂÅĞÍÛÉ İËÅÌÅÍÒ!");
	}
	return BitField.GetBit(Elem);
}

void TSet::InsElem(const int Elem) 
{
	if (Elem < 0 || Elem >= MaxPower)
	{
		throw std::logic_error("ÍÅÂÅĞÍÛÉ İËÅÌÅÍÒ!");
	}
	BitField.SetBit(Elem);
}

void TSet::DelElem(const int Elem)
{
	if (Elem < 0 || Elem >= MaxPower)
	{
		throw std::logic_error("ÍÅÂÅĞÍÛÉ İËÅÌÅÍÒ!");
	}
	BitField.ClrBit(Elem);
}

int TSet::operator!=(const TSet& s) 
{
	return BitField != s.BitField;
}

TSet TSet::operator+(const TSet& s) 
{
	int len = MaxPower;
	if (s.MaxPower > MaxPower)
	{
		len = s.MaxPower;
	}
	TSet temp(len);

	temp.BitField = BitField | s.BitField;
	return temp;
}

TSet TSet::operator+(const int Elem) {
if (Elem < 0 || Elem >= MaxPower)
{
	throw std::logic_error("ÍÅÂÅĞÍÛÉ İËÅÌÅÍÒ!");
}

BitField.SetBit(Elem);
return *this;
}

TSet TSet::operator-(const int Elem) 
{
	if (Elem < 0 || Elem >= MaxPower)
	{
		throw std::logic_error("ÍÅÂÅĞÍÛÉ İËÅÌÅÍÒ!");
	}

	BitField.ClrBit(Elem);
	return *this;
}

TSet TSet::operator*(const TSet& s) 
{
	int len = MaxPower;
	if (s.MaxPower > MaxPower)
	{
		len = s.MaxPower;
	}
	TSet temp(len);
	temp = BitField & s.BitField;
	return temp;
}

TSet TSet::operator~(void) 
{
	BitField = ~BitField;
	return *this;
}

istream& operator>>(istream& istr, TSet& s) 
{
	int temp;
	char ch;
	do { istr >> ch; } while (ch != '{');
	do {
		istr >> temp;
		s.InsElem(temp);
		do { istr >> ch; } while ((ch != ',') && (ch != '}'));
	} while (ch != '}');
	return istr;
}

ostream& operator<<(ostream& ostr, const TSet& s) 
{
	int i, n; char ch = ' ';
	ostr << "{";
	n = s.GetMaxPower();
	for (i = 0; i < n; i++) {
		if (s.IsMember(i)) {
			ostr << ch << ' ' << i;
			ch = ',';
		}
	}
	ostr << " }";
	return ostr;
}