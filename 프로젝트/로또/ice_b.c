#include<stdio.h>
#include<stdlib.h>
#include<time.h>
void Print()
{
	printf("-------------------------------\n");
	printf("-------------ICE---------------\n");
	printf("-----------breaking------------\n");
	printf("-------------------------------\n");
	printf("Enter.를 입력해주세요.......");
}
main()
{
	Print();
	srand(time(NULL));
	
	char* room[15] = { "곽상우","허선용","노진우", "박상우", "서주형", "송진영", "이승원", "이은수", "강충만",
		"이상헌","김현우","임형욱","윤철희","박상신 교수님","김홍근 교수님" };
	char* win[3] = { "0", };
	for (int i = 2; i >= 0; i--)
	{
		getchar();
		win[i] = room[rand() % 15];
		
		if(i==2)
			printf("%d등. %s", i + 1, win[i]);
		else
		{
			for (int j = 2; j > i; j--)
			{
				if (win[i] == win[j])
				{
					while (win[i] == win[j])
					{
						/*printf("------------------\n");
						printf("%s\n", win[i]);
						printf("------------------\n");*/ //
						win[i] = room[rand() % 13];
					}
				}
			}
			printf("%d등. %s", i + 1, win[i]);
		}
	}
	printf("\n");
	system("pause");
}

