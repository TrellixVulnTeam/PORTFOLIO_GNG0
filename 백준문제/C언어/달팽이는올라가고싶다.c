#include<stdio.h>
#include<math.h>
//2869번 달팽이는 올라가고 싶다

main()
{
	//목표등반 V
	//낮에:등반 A  밤에:하강 B 목표점V도달시 종료.
	//V+B(X-1)<= AX (마지막날은 낮에 올라가면끝, 밤이되기전에 목표점에 도달한다.=>내려갈 일 없음)
	//(V-B)/(A-B) <= X(몇일)
	//4.xxxx일이 나온다면 4일+1일이 더 필요하단 뜻.

	//막힌부분
	//1.ceil함수 : 4.2 = 5올림해준다. 4.0000 = 4이다
	//2.정수/정수 하면 값이 안나옴. 하나를 형변환 해줘야한다.


	int V = 0;//목표점
	int A = 0;//낮에 올라간다
	int B = 0;//밤에 미끄러진다
	double dresult = 0;
	scanf_s("%d %d %d", &A, &B, &V); 
	dresult = (V - B) / (double)(A - B);
	printf("%.0f", ceil(dresult));
	return 0;
}