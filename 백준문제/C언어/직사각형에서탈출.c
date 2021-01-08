#include<stdio.h>
//1085번 직사각형에서 탈출

int Min(int x, int y, int w, int h)
{
	int a[4];
	a[0] = x; a[1] = y; a[2] = w; a[3] = h;
	int min;
	min = a[0];
	for (int i = 1; i < 4; i++)
	{
		if (min > a[i])
			min = a[i];
	}
	return min;
}
main()
{
	int x, y, w, h;
	scanf_s("%d %d %d %d", &x, &y, &w, &h);
	printf("%d", Min(w-x, h-y, x, y));
}