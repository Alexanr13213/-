#define Max_Mem_Size   100 
using namespace std;
template <class New>
class Queue
{
	int EVbegin; 
	int EVend;
	int EVCounter; 
	int MemSize;
	New* pMem;
public:
	Queue(int _size)
	{
		MemSize = _size;
		if (MemSize > Max_Mem_Size)
			throw "ошибка";
		else
		{
			if (MemSize < 1)
				throw "ошибка";
			EVCounter = 0;
			EVbegin = 0;
			EVend = 0;
			pMem = new New[MemSize];
		}
	}
	~Queue()
	{
		delete[]pMem;
	}
	int EVNextIndex(int index)
	{
		return (++index % MemSize);
	}
	int EVEmpty()
	{
		return (EVCounter == 0);
	}
	int EVFull()
	{
		return (EVCounter == MemSize);
	}
	void EVPut(New elem)
	{
		if (!EVFull())
		{
			pMem[EVend++] = elem;
			EVCounter++;
			if (EVend > MemSize - 1)
				EVend = 0;
		}
		else
		{
			throw "Ошибка: заполнено";
		}
	}
	New EVGet()
	{
		if (EVEmpty())
			throw "Ошибка: здесь пусто";
		New res = pMem[EVbegin];
		EVbegin += 1;
		if (EVbegin > MemSize - 1)
			EVbegin = 0;
		EVCounter -= 1;
		return res;
	}
	New EVCheck()
	{
		if (!EVEmpty())
		{
			return pMem[EVbegin];
		}
		else
			throw "Ошибка: здесь пусто";
	}
	int EVSize()
	{
		return EVCounter;
	}
}; 
