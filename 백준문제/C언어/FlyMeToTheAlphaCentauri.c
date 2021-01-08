#include<stdio.h>
#include<math.h>

//1011번 Fly me to the Alpha Centauri

int main()
{
	int T = 0;//테스트케이스
	int x, y;//현재,도착위치
	int n = 0;
	scanf_s("%d", &T);
	for (int i = 0; i < T; i++)
	{
		scanf_s("%d %d", &x, &y);
		int dist = y - x;
		int cnt = 0;
		n = ceil(sqrt(dist));
		int maxn = (n * n);
		if (maxn - (n - 1) <= dist)
			printf("%d\n", (2 * n) - 1);
		else
		{
			printf("%d\n", 2 * (n-1));
		}
	}
	return 0;
}
//1 = 1
//2 = 1 1
//3 = 1 1 1
//4 = 1 2 1
//5 = 1 2 1 1
//6 = 1 2 2 1
//7 = 1 2 2 1 1
//8 = 1 2 2 2 1
//9 = 1 2 3 2 1
//10 = 1 2 3 2 1 1
//11 = 1 2 3 2 2 1
//12 = 1 2 3 3 2 1
//13 = 1 2 3 3 2 1 1
//14 = 1 2 3 3 2 2 1
//15 = 1 2 3 3 3 2 1
//16 = 1 2 3 4 3 2 1
//
//2 = 3개(2n - 1)개
//3 = 5개
//4 = 7개
//
//1.n ^ 2찾기
//2.n ^ 2 - (n - 1) <= value <= n ^ 2 = > (2n - 1)개
//3.(n - 1) ^ 2 <= value < n ^ 2 - (n - 1) = >(2n)개