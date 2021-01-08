#include<stdio.h>
//2292번 벌집

main() {
	//계차수열을 통해 문제를 해결할 수 있다.
	//2번째 만에 접근가능 수 = 2~7
	//3번째 = 8~19
	//4번째 = 20~37
	//등차수열 an의 공차 bn = 3n(n-1)로 표현가능하다 (계차수열 참고해보기)
	int result = 0;
	int N = 0;//입력받는수
	int n = 1;//몇번째
	int d = 0;//공차
	scanf_s("%d", &N, sizeof(int) / 4);
	for (int n = 1; N > d; n++) {
		d = 1 + (3 * n * (n - 1));
		result = n;
	}
	printf("%d", result);
	return 0;
}