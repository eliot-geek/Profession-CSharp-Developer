#include <iostream>
using namespace std;
float givePoints(float*points){
    int min=0,max=0;
    for(int i=1;i<10;i++){
        if(points[i]>points[max])
            max=i;
        if(points[i]<points[min])
            min=i;
    }
    if(min==max)
        max=9;
    float sum=0.0;
    for(int i=0;i<10;i++){
        if(i!=max&&i!=min)
            sum+=points[i];
    }
    return sum/=8;
}
int main(){
    setlocale(LC_ALL,"Russian");
    cout<<"Введите 10 оценок"<<endl;
    float*points=new float[10];
    for(int i=0;i<10;i++)
    cin>>points[i];
    cout<<"Итоговый балл:"<<givePoints(points)<<endl;
    return 0;
}
