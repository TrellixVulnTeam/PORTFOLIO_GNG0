#include<stdio.h>
#include<math.h>
//10250¹ø ACMÈ£ÅÚ

main()
{
	int m = 0;
	int h, w, n;
	scanf_s("%d", &m);
	int chung = 0;
	int ho = 0;
	for (int i = 0; i < m; i++)
	{
		scanf_s("%d %d %d", &h, &w, &n);
		chung = n % h;
		if (n % h == 0)
			chung = h;
		ho = ceil(n / (double)h);
		if (ho >= 10)
			printf("%d%d\n", chung, ho);
		else if (ho < 10)
			printf("%d0%d\n", chung, ho);
	}
	return 0;
}