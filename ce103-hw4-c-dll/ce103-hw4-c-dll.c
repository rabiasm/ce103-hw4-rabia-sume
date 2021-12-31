#include "ce103-hw4-c-dll.h"

__declspec(dllexport) int ce103_fibonacciNumber(int fiIndex)
{
	//TODO:Start from Here...

	int r = 0, s = 1, k;  1.;
	for (int b = 1; b < fiIndex; b++)
	{
		k = r + s;
		r = s;
		s = k;
	}
	return r;
}
	

__declspec(dllexport) char* ce103_strrev(char* fiStr)
{
	//TODO:Start from Here...

	char ia;     /* We created ia.*/
	char* r = fiStr;
	char* s = fiStr;

	for (; *s != '\0'; s++);   /* */
	;
	s--;
	for (; r < s; r++, s--)
	{
		ia = *r;
		*r = *s;
		*s = ia;
	}
	return fiStr;
}

__declspec(dllexport) int ce103_strlen(const char* fiStr)
{
	//TODO:Start from Here...
	int a = 0;
	char* brg = fiStr;
	while (*brg != '\0')
	{
		++a;
		++brg;
	}
	return a;
}

__declspec(dllexport) char* ce103_strcat(char* fiDest, char* fiSrc)
{
	//TODO:Start from Here...

	char* rs = fiDest;

	while (*rs)

		rs++;

	while (*rs++ = *fiSrc++);

	return(fiDest);
}

__declspec(dllexport) int ce103_strcmp(const char* fiLhs, const char* fiRhs)
{
	//TODO:Start from Here...

	while (*fiLhs && (*fiLhs == *fiRhs)) {
		fiLhs++;
		fiRhs++;
	}
	return *fiLhs - *fiRhs;
}
__declspec(dllexport) char* ce103_strcpy(char* foDestination, const char* fiSource)
{
	//TODO:Start from Here...
	char* r = foDestination;
	while (*fiSource)
	{
		*foDestination++ = *fiSource++;
	}
	*foDestination = '\0';
	return r;
}


__declspec(dllexport) void ce103_hex2bin(char* fiHex, int fiHexLen, unsigned char* foBin)
{
	//TODO:Start from Here...

	int r, s;
	for (;;) {
		r = *fiHex++; if (r == 0) break;
		if (r > 96) r -= 87;
		else if (r > 64) r -= 55;
		else r -= 48;
		s = *fiHex++; if (s == 0) { *foBin = s << 4; break; }


		if (s > 96) s -= 87;
		else if (s > 64) s -= 55;
		else s -= 48;

		*foBin++ = (r << 4) | s;
	}
	return fiHex;
}

__declspec(dllexport) void ce103_bin2hex(unsigned char* fiBin, int fiBinLen, char* foHex)
{
	//TODO:Start from Here...

	int r, s, * end = fiBin + fiBinLen;
	while (fiBin < end)
	{
		r = *(fiBin++);
		s = r >> 4;
		*(foHex++) = s + (s > 9 ? 55 : 48);
		s = r & 15;
		*(foHex++) = s + (s > 9 ? 55 : 48);
	}
	*foHex = 0;

	return fiBin;

}
