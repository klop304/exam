#include<stdio.h>
#include<math.h>
main()
{
    int x,y;
    printf("Vvedite chislo x:\n");
    scanr("%d",&x);
    y=(x+5)/(x-5);
    printf("y=%d",y);
    getchar();
}
